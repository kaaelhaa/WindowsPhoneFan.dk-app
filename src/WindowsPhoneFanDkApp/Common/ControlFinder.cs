﻿using System.Windows;
using System.Windows.Media;

namespace WindowsPhoneFanDkApp.Common
{
    public static class ControlFinder
    {
        //Created a controlfinder - for easier finding parent controls of an UIelement
        public static T FindParent<T>(UIElement control) where T : UIElement
        {
            UIElement p = VisualTreeHelper.GetParent(control) as UIElement;
            if (p != null)
            {
                if (p is T)
                    return p as T;
                else
                    return ControlFinder.FindParent<T>(p);
            }
            return null;
        }
    }
}
