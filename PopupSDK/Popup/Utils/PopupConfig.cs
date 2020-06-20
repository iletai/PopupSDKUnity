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
        public Color BackgroundCanvasPopup { get; set; }

        public static PopupConfig DefaulConfigPopup()
        {
            return new PopupConfig
            {
                BackgroundCanvasPopup = Color.white
            };
        }
    }
}
