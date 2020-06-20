using UnityEngine;
using UnityEngine.UI;
using Popup.Extension;
using Popup.Utils;
using System;

namespace Popup.Common
{
    public class PopupContentUI
    {
        private string      TextButtonInsidePopup;
        private Color       ColorTextButton;
        private Color       ColorBackgroundButton;
        private Transform   ParentTransformForButton;
        private GameObject  PrefabsGameObjectButton;
        private Action      OnContentClick;

        private GameObject gameObjectParseForButtonInsidePopup;
        public PopupContentUI() { }

        public PopupContentUI(string textbutton, Color colortextbutton, Color bgcolorbutton, Transform transformbutton, GameObject prefabsetforbutton, Action ClickContentPopup) 
        {
            this.TextButtonInsidePopup = textbutton;
            this.ColorBackgroundButton = bgcolorbutton;
            this.ColorTextButton = colortextbutton;
            this.ParentTransformForButton = transformbutton;
            this.OnContentClick = ClickContentPopup;
        }
        public void CreateButtonInsidePopup()
        {
            gameObjectParseForButtonInsidePopup =(GameObject)GameObject.Instantiate(PrefabsGameObjectButton);
            gameObjectParseForButtonInsidePopup.transform.SetParent(ParentTransformForButton, false);
            gameObjectParseForButtonInsidePopup.transform.localPosition = new Vector3(1, 1, 1);
            gameObjectParseForButtonInsidePopup.GetComponent<Image>().color = ColorBackgroundButton;
            gameObjectParseForButtonInsidePopup.GetComponent<Button>().onClick.AddListener(() =>
            {
                OnContentClick();
            });

            if(gameObjectParseForButtonInsidePopup.transform.childCount != 0)
            {
                gameObjectParseForButtonInsidePopup.transform.GetChild(0).GetComponent<Text>().text = TextButtonInsidePopup;
                gameObjectParseForButtonInsidePopup.transform.GetChild(0).GetComponent<Text>().color = ColorTextButton;
            }
        }

        public void DestroyGameObjectButton()
        {
            if (gameObjectParseForButtonInsidePopup)
                GameObject.Destroy(gameObjectParseForButtonInsidePopup);
        }

    }
}
