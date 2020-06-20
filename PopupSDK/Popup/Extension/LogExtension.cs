using System;
using UnityEngine;

namespace Popup.Extension
{
    public static class LogExtension
    {
        public static string BoldLogDebug(this string str) => "<b>" + str + "</b>";
        public static string ColorLogDebug(this string str, string clr) => string.Format("<color={0}>{1}</color>", clr, str);
        public static string ItalicLogDebug(this string str) => "<i>" + str + "</i>";
        public static string Size(this string str, int size) => string.Format("<size={0}>{1}</size>", size, str);
        public static void LogColor( string message, String color = "green") => Debug.Log($"<color={color}>{message}</color>");
        
    }
}
