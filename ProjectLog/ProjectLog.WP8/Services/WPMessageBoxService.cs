using System;
using Windows.UI.Popups;
using ProjectLog.Core.Services;

namespace ProjectLog.WP8.Services
{
    public class WPMessageBoxService: IMessageBoxService
    {
        public void Confirm(string title, string message, Action<bool> callback)
        {
            var dialog = new MessageDialog(message, title);
            dialog.Commands.Add(new UICommand("Ok", command =>
                                                    {
                                                        if (callback != null) callback(true); 
                                                    }));
            dialog.Commands.Add(new UICommand("Cancel", command =>
                                                    {
                                                        if (callback != null) callback(true); 
                                                    }));
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;
            dialog.ShowAsync();
        }
    }
}