using YouDo.MVVM.ViewModel.MainViewModels;

namespace YouDo.MVVM.View.MainViews;

public partial class CampaignsPage : ContentPage {
	public CampaignsPage(CampaignsViewModel viewModel) {
		InitializeComponent();
        BindingContext = viewModel;
    }
}