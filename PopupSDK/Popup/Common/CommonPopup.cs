using Popup.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Popup.Common
{
    public abstract class CommonPopup : MonoBehaviour
    {
        public abstract void SetConfig(PopupConfig config);
        public abstract void SetBackgroundCommonUI(Color configColor);


    }
}
