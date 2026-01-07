using CommunityToolkit.Mvvm.ComponentModel;

namespace UnifyMESWpf.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Unify MES";

        [ObservableProperty]
        private ObservableObject currentViewModel;

        public MainViewModel(LoginViewModel loginViewModel)
        {
            CurrentViewModel = loginViewModel;
        }
    }
}
