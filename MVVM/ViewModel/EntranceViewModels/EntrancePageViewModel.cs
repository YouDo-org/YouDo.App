using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YouDo.Resources.Localization;
using YouDo.MVVM.View.MainViews;
using YouDo.MVVM.View.EntranceView;
// using AndroidX.Lifecycle;
// using static Android.Renderscripts.ScriptGroup;

namespace YouDo.MVVM.ViewModel.EntranceViewModels;
public partial class EntrancePageViewModel : BaseViewModel {

    [ObservableProperty]
    private Model.EntranceModels.UserInfoModel userInfoModel = new Model.EntranceModels.UserInfoModel();

    [RelayCommand]
    async Task MoveToForgotPasswordAsync() {
        await Shell.Current.GoToAsync(nameof(ForgotPasswordPage), true,
            new Dictionary<string, object> {
                {"UserInfoModel", this.UserInfoModel}
            });
    }

    [RelayCommand]
    async Task MoveToCreateNewAccount() {
        await Shell.Current.GoToAsync(nameof(CreateNewAccountPage), true,
            new Dictionary<string, object> {
                {"UserInfoModel", this.UserInfoModel}
            });
    }


    [RelayCommand]
    async Task Login() {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;
        if (accessType == NetworkAccess.Internet) {
            // Login Operation Here

            // Move to main page (Map)
            await Shell.Current.GoToAsync(nameof(MapPage), true);

        } else {
            await Shell.Current.DisplayAlert(AppResource.InternetConnection, AppResource.InternetConnectionMessage, AppResource.InternetConnectionCancel);
            IsBusy = true;
        }
    }
}

