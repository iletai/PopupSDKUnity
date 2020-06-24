using Popup.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Popup.Utils
{
  
    public class UIConfigPopup : MonoBehaviour
    {
        [SerializeField]
        public GameObject PanelPopup;

        [SerializeField]
        public GameObject ContentImage;

        [SerializeField]
        public GameObject ScrollView;

        [SerializeField]
        public GameObject Content;

        [SerializeField]
        public GameObject ConfirmButton; 
        
        [SerializeField]
        public GameObject PanelTitle;

        public void SetStyleMode(StyleViewPopup style)
        {
            if (style == StyleViewPopup.NONE)
            {

            }
            else if(style == StyleViewPopup.DARK_STYLE)
            {

            }
            else if (style == StyleViewPopup.LIGHT_STYLE)
            {

            }
        }

        public void ConfirmButtonClick(Action clickconfirmbutton)
        {
            ConfirmButton.transform.GetChild(0).gameObject.GetComponent<Button>().onClick.AddListener(() =>
            {
                clickconfirmbutton();
            });


        }

        public void SetTitleText(string texttile )
        {
            PanelTitle.GetComponentInChildren<Text>().text = texttile;
        }

        public void SetBackgroundColor(Color color)
        {
            //Using config get in Manager to send param and set for UI Popup.
            //GameObject.<Image/Text..>().color = color
        }
    }
}
