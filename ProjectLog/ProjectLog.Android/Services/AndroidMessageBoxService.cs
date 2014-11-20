using System;
using Android.App;
using Android.Widget;
using ProjectLog.Core.Services;

namespace ProjectLog.Android.Services
{
    public class AndroidMessageBoxService: IMessageBoxService
    {
        public void Confirm(string title, string message, Action<bool> callback)
        {
            new AlertDialog.Builder(Application.Context)
                .SetPositiveButton("Ok", (sender, args) => { if (callback != null) callback(true); })
                .SetNegativeButton("Cancel", (sender, args) => { if (callback != null) callback(false); })
                .SetMessage(message)
                .SetTitle(title)
                .Show();
        }
    }
}