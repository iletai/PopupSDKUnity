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
        public StyleViewPopup       DefaulStylePopup { get; set; }
        public Color                ColorCommonBackground { get; set; }
        public Color                ColorCommonText { get; set; }
        public float                WithPopup { get; set; }
        public float                HeightPopup { get; set; }


        /// <summary>
        /// Static method create deafaul config 
        /// </summary>
        /// <returns></returns>
        public static PopupConfig DefaulConfigPopup()
        {
            return new PopupConfig
            {
                DefaulStylePopup = StyleViewPopup.NONE,
                ColorCommonBackground = Color.white,
                ColorCommonText = Color.black,
                WithPopup = 500,
                HeightPopup = 500,
            };
        }
    }
}
