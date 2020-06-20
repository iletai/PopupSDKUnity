using Popup.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Popup.Utils
{
    public class PopupConfig
    {
        public Color                BackgroundCanvasPopupColor { get; set; }
        public GameObject           PrefabButton { get; set; }
        public Action               OnSelectOptionPopup { get; set; }
        public string               TextButtonPopup { get; set; }
        public Transform            ParentTransformButtonInsidePopup { get; set; }
        public TypePopupDefine      DefaulStylePopup { get; set; }

        public static PopupConfig DefaulConfigPopup()
        {
            return new PopupConfig
            {
                BackgroundCanvasPopupColor          = Color.white,
                PrefabButton                        = null,
                OnSelectOptionPopup                 = null,
                ParentTransformButtonInsidePopup    = null,
                DefaulStylePopup                    = TypePopupDefine.SINGLE_BUTTON_POPUP
            };
        }
    }
}
