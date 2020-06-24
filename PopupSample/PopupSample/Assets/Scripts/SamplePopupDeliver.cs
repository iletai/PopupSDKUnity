using Popup.Enum;
using Popup.Extension;
using Popup.Utils;
using PopupSDK.Popup;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SamplePopupDeliver : MonoBehaviour
{

    private GameObject _popupManager;
    private PopupConfig _popupConfig;

    [SerializeField] Dropdown       StylePopup;
    [SerializeField] InputField     WithPopup;
    [SerializeField] InputField     HeightPopup;
    [SerializeField] InputField     ColorCommonBackground;
    [SerializeField] InputField     ColorCommonText;
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TestShowPopupClicked()
    {
        const string _PopupManager = "PopupSDK/PopupManager";

        _popupManager = (GameObject)Instantiate(Resources.Load(_PopupManager, typeof(GameObject)));
        PopupManager.Instance.SetConfig(GetConfigPopup());
        PopupManager.Instance.AddButtonContent("I", () => { LogExtension.LogColor("Heelo"); });
        PopupManager.Instance.AddButtonContent("Love", () => { LogExtension.LogColor("Heelo"); });
        PopupManager.Instance.AddButtonContent("You", () => { LogExtension.LogColor("Heelo"); });
         PopupManager.Instance.ShowPopup("Sample Popup",ConfirmPopup);
    }

    public void ConfirmPopup()
    {
        LogExtension.LogColor("Click confirm".BoldLogDebug());
    }

    public PopupConfig GetConfigPopup()
    {
        _popupConfig = new PopupConfig();
        _popupConfig.DefaulStylePopup = StylePopup.value == 0 ? StyleViewPopup.DARK_STYLE : (StylePopup.value == 1 ? StyleViewPopup.LIGHT_STYLE : StyleViewPopup.NONE);
        try
        {
            Color colorCommonBackground, colorCommonText;


            if (ColorUtility.TryParseHtmlString(ColorCommonBackground.text, out colorCommonBackground))
                _popupConfig.ColorCommonBackground = colorCommonBackground;

            if (ColorUtility.TryParseHtmlString(ColorCommonText.text, out colorCommonText))
                _popupConfig.ColorCommonText = colorCommonText;

        }
        catch (Exception e)
        {
           
        }

      
        _popupConfig.WithPopup = float.Parse(WithPopup.text.Trim());
        _popupConfig.HeightPopup = float.Parse(HeightPopup.text.Trim());
        _popupConfig.BackgroundCanvasPopupColor = Color.white;
        return _popupConfig;
    }    
}
