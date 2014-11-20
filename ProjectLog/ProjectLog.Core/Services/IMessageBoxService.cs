using System;

namespace ProjectLog.Core.Services
{
    public interface IMessageBoxService
    {
        void Confirm(string title, string message, Action<bool> dialogCallback);
    }
}