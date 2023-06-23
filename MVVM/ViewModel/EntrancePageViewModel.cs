﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YouDo.MVVM.View;
using YouDo.Resources.Localization;
using System.Diagnostics;
using System.Text.RegularExpressions;
// using AndroidX.Lifecycle;
// using static Android.Renderscripts.ScriptGroup;

namespace YouDo.MVVM.ViewModel;
public partial class EntrancePageViewModel : BaseViewModel {

    [ObservableProperty]
    private Model.UserInfoModel userInfoModel = new Model.UserInfoModel();

    [RelayCommand]
    async Task MoveToForgotPasswordAsync() {
        /*ForgotPasswordPage forgotPasswordPage = new ForgotPasswordPage();
        forgotPasswordPage.BindingContext = this;

        await Application.Current.MainPage.Navigation.PushAsync(forgotPasswordPage);*/
        await Shell.Current.GoToAsync(nameof(ForgotPasswordPage), true,
            new Dictionary<string, object> {
                {"UserInfoModel", this.UserInfoModel}
            });
    }

    [RelayCommand]
    async Task MoveToCreateNewAccount() {
        /*CreateNewAccountPage createNewAccountPage = new CreateNewAccountPage();
        createNewAccountPage.BindingContext = this;

        await Application.Current.MainPage.Navigation.PushAsync(createNewAccountPage);*/

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
        } else {
            await Shell.Current.DisplayAlert(AppResource.InternetConnection, AppResource.InternetConnectionMessage, AppResource.InternetConnectionCancel);
            IsBusy = true;
        }
    }
}

