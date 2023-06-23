using YouDo.MVVM.ViewModel;
using System.Diagnostics;
using YouDo.MVVM.ViewModel.EntranceViewModels;

namespace YouDo.MVVM.View.EntranceView;

public partial class ForgotPasswordPage : ContentPage {

    public ForgotPasswordPage(ForgotPasswordViewModel viewModel) {
        InitializeComponent();
        BindingContext = viewModel;
    }
}