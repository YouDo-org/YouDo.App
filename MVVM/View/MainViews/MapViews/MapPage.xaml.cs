using YouDo.MVVM.ViewModel.MainViewModels;

namespace YouDo.MVVM.View.MainViews;

public partial class MapPage : ContentPage {
	public MapPage(MapViewModel viewModel) {
		InitializeComponent();
        BindingContext = viewModel;
    }
}