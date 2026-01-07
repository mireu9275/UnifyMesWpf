using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace UnifyMESWpf.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private bool isBusy;

        public LoginViewModel()
        {
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            if (IsBusy) return;

            IsBusy = true;
            // TODO: ?ㅼ젣 濡쒓렇??濡쒖쭅 援ы쁽
            await Task.Delay(2000); // 濡쒓렇???쒕??덉씠??
            IsBusy = false;
        }
    }
}
