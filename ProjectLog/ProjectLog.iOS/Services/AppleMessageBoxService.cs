using System;
using MonoTouch.UIKit;
using ProjectLog.Core.Services;

namespace ProjectLog.iOS.Services
{
    public class AppleMessageBoxService: IMessageBoxService
    {
        public void Confirm(string title, string message, Action<bool> callback)
        {
            var alert = new UIAlertView("Alert", message, null, "Cancel", "Ok");
            alert.Canceled += (sender, args) =>
                              {
                                  if (callback != null) callback(false); 
                              };
            alert.Clicked += (sender, args) =>
                             {
                                 if (callback != null) callback(true); 
                             };
            alert.Show();
        }
    }
}