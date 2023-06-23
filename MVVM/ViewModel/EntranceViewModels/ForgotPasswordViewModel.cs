using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YouDo.MVVM.View;
using YouDo.Resources.Localization;

namespace YouDo.MVVM.ViewModel.EntranceViewModels;

[QueryProperty("UserInfoModel", "UserInfoModel")]
public partial class ForgotPasswordViewModel : BaseViewModel{
    
    [ObservableProperty]
    private Model.EntranceModels.UserInfoModel userInfoModel;

    [RelayCommand]
    async Task MoveBackAsync() {
        await Shell.Current.GoToAsync($"..", true);
    }

    [RelayCommand]
    async Task ChangePassword() {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        if (accessType == NetworkAccess.Internet) {
            // Change Password Operation Here
        } else {
            await Shell.Current.DisplayAlert(AppResource.InternetConnection, AppResource.InternetConnectionMessage, AppResource.InternetConnectionCancel);
            IsBusy = true;
        }
    }
}
