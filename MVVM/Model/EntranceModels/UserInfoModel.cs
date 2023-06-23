using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo.MVVM.Model.EntranceModels;
public class UserInfoModel{

    private string username;
    private string code = "";
    private string userinfo = "";
    private string email = "";
    private string phonenumber = "";
    private string password = "";
    private string password2 = "";


        
    public string Username { get { return username; } set { username = value; } }
    public string Code { get { return code; } set { code = value; } } // forgot password
    public string Userinfo { get { return userinfo; } set { userinfo = value; } } // main entrance page
    public string Email { get { return email; } set { email = value; } } // register
    public string Phonenumber { get { return phonenumber; } set { phonenumber = value; } } // register
    public string Password { get { return password; } set { password = value; } } // register / forgot password / main entrance
    public string Password2 { get { return password2; } set { password2 = value; } } // register / forgot password

}
