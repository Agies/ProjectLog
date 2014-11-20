using ProjectLog.Core.Services;

namespace ProjectLog.Core.ViewModels
{
    public class ShellViewModel
    {
        private readonly IMessageBoxService _messageBoxService;

        public ShellViewModel(IMessageBoxService messageBoxService)
        {
            _messageBoxService = messageBoxService;
        }
    }
}