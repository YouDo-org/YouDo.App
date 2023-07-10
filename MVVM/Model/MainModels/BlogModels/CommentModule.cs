using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo.MVVM.Model.MainModels.BlogModels;

public partial class CommentModule : BaseContentModel{

    [ObservableProperty]
    public string comment = "";

    public CommentModule(string username, string userdefenition, string comment, DateTime releasedate, string userIconPath) :
        base(username, userdefenition, releasedate, userIconPath) {

        this.comment = comment;
    }
}
