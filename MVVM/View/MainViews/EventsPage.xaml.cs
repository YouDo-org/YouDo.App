using YouDo.MVVM.ViewModel.MainViewModels;

namespace YouDo.MVVM.View.MainViews;

public partial class EventsPage : ContentPage {
	public EventsPage(EventsViewModel viewModel) {
		InitializeComponent();
        BindingContext = viewModel;
    }
}