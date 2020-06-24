using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Popup.Utils;
using UnityEngine.EventSystems;
using Popup.Extension;
using Popup.Common;

namespace PopupSDK.Popup
{
    public class PopupManager : CommonPopup
    {
        const string PATH_POPUP_CANVAS = "PopupSDK/CommonPopupCanvas";
        const string PATH_CONTENT_POPUP = "PopupSDK/CommonPopupButton";

        private static PopupManager _instance;
        private UIConfigPopup UIPopup;
        private PopupConfig PopupConfig;

        private GameObject _commonCanvasPopup;
        private GameObject _eventSystems;
        private GameObject _commonContentPopup;

        private List<PopupContentUI> listContentPopup = new List<PopupContentUI>();


        public static PopupManager Instance
        {
            //Just create instance and find it's in scene. So I don't recommend "Name" it. Becase it could duplicate with your scripts or object.
            get => _instance == null ? _instance = GameObject.FindObjectOfType<PopupManager>() : _instance;
        }

        public void Awake()
        {
            _commonCanvasPopup = (GameObject)Instantiate(Resources.Load(PATH_POPUP_CANVAS, typeof(GameObject)));
            _commonContentPopup = (GameObject)Resources.Load(PATH_CONTENT_POPUP, typeof(GameObject));
            UIPopup = _commonCanvasPopup.GetComponent<UIConfigPopup>();
        }

        public void DefaulInitCreatePopup()
        {
            if (_commonCanvasPopup)
            {
                _commonCanvasPopup.GetComponent<CanvasGroup>().alpha = 0.0f;
                _commonCanvasPopup.GetComponent<CanvasGroup>().interactable = false;
                _commonCanvasPopup.GetComponent<CanvasGroup>().blocksRaycasts = false;

                EventSystem[] objects = (EventSystem[])GameObject.FindObjectsOfType<EventSystem>();
                if (objects.Length == 0)
                {
                    _eventSystems = new GameObject("PopupEventSystem", typeof(EventSystem));
                    _eventSystems.AddComponent<StandaloneInputModule>().forceModuleActive = true;
                }
                else
                {
                    objects[0].gameObject.GetComponent<StandaloneInputModule>().forceModuleActive = true;
                }
            }
        }

        public void AddContentToPopupCanvas(string contentTextMessageButton, Action _OnClickContentPopup)
        {
            AddButtonContent(contentTextMessageButton, _OnClickContentPopup);
        }

        public void AddButtonContent(string textbtn, Action ClickPopupContent)
        {
            listContentPopup.Add(new PopupContentUI(textbtn, PopupConfig.DefaulConfigPopup().ColorCommonText, PopupConfig.DefaulConfigPopup().ColorCommonBackground, UIPopup.Content.transform, _commonContentPopup, ClickPopupContent));


        }

        public void ShowPopup(string textShowTitle, Action confirmbutton)
        {
            foreach (PopupContentUI item in listContentPopup)
            {
                item.CreateButtonInsidePopup();
            }
            UIPopup.SetTitleText(textShowTitle);
            UIPopup.ConfirmButtonClick(confirmbutton);
            ///Sample using config
          SetBackgroundCommonUI(PopupConfig.BackgroundCanvasPopupColor);
            ///
        }

        /// <summary>
        /// By create new config. We have a config for handle set param. If you don't create config.
        /// Static method in config will auto create config. We can using it with method like this: PopupConfig cf = new PopupConfig.DefaulConfig()
        /// </summary>
        /// <param name="config"></param>
        public override void SetConfig(PopupConfig config)
        {
            PopupConfig = config;
        }

        ///Example set background:
        public override void SetBackgroundCommonUI(Color color)
        {
            UIPopup.SetBackgroundColor(color);
        }
    }
}
