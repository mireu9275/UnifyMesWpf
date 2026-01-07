using CommunityToolkit.Mvvm.ComponentModel;

namespace UnifyMESWpf.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = "Unify MES - 초기 화면";

        public MainViewModel()
        {
        }
    }
}
