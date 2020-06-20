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
    public class PopupManager : MonoBehaviour
    {
         const string PATH_POPUP_CANVAS         = "PopupSDK/CommonPopupCanvas";
         const string PATH_CONTENT_POPUP        = "PopupSDK/CommonPopupButton";

        private static PopupManager               _instance;
        private static PopupConfig                _configPopup;

        private GameObject                        _commonCanvasPopup;
        private GameObject                        _eventSystems;
        private GameObject                        _commonContentPopup;

        private List<PopupContentUI> listContentPopup = new List<PopupContentUI>();


        public static PopupManager Instance
        {
            get => _instance == null ? _instance = GameObject.FindObjectOfType<PopupManager>() : _instance;
        }

        public void Awake()
        {
            //Using defaul config 
            _configPopup = PopupConfig.DefaulConfigPopup();
            _commonCanvasPopup =  (GameObject)Instantiate(Resources.Load(PATH_POPUP_CANVAS, typeof(GameObject)));
            _commonContentPopup = (GameObject)Resources.Load(PATH_CONTENT_POPUP, typeof(GameObject));
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
            AddButtonContent();
        }

        public void AddButtonContent()
        {

        }


        public void ConfigTitlePopup()
        {

        }

        public void ShowPopup()
        {
            DefaulInitCreatePopup();


        }
    }
}
