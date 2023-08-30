using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo.MVVM.Model.EntranceModels;
public partial class UserInfoModel : ObservableObject {
    /// <summary>
    /// Necassary informations for user profile
    /// </summary>

    [ObservableProperty]
    private string username = "";

    [ObservableProperty]
    private string code = "";

    [ObservableProperty]
    private string userinfo = "";

    [ObservableProperty]
    private string email = "";

    [ObservableProperty]
    private string phonenumber = "";

    [ObservableProperty]
    private string password = "";

    [ObservableProperty]
    private string password2 = "";
}
