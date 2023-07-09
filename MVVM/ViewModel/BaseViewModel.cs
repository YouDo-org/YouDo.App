using CommunityToolkit.Mvvm.ComponentModel;

namespace YouDo.MVVM.ViewModel {

    public partial class BaseViewModel : ObservableObject {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        public bool isBusy;

        [ObservableProperty]
        public string title;

        public bool IsNotBusy => !IsBusy;
    }
}
