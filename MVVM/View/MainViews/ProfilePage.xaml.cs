using YouDo.MVVM.ViewModel.MainViewModels;

namespace YouDo.MVVM.View.MainViews;

public partial class ProfilePage : ContentPage {
	public ProfilePage(ProfileViewModel viewModel) {
		InitializeComponent();
        BindingContext = viewModel;
    }
}