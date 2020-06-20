using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePopupDeliver : MonoBehaviour
{

    private GameObject _popupManager;
    private void OnEnable()
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
        const string PopupManager = "PopupSDK/PopupManager";
        _popupManager = (GameObject)Instantiate(Resources.Load(PopupManager, typeof(GameObject)));

    }
}
