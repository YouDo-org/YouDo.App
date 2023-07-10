using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo.MVVM.Model.MainModels.BlogModels;

public partial class BlogContentModel : BaseContentModel {

    [ObservableProperty]
    string blogContent = "";

    [ObservableProperty]
    bool commentVisibility = false;

    [ObservableProperty]
    public ObservableCollection<CommentModule> comments;

    public BlogContentModel(string username, string userdefenition, string blogcontent, DateTime releasedate, string userIconPath) :
        base(username, userdefenition, releasedate, userIconPath) {
        
        blogContent = blogcontent;

        comments = new ObservableCollection<CommentModule> {
            new CommentModule("Alex", "Developer", "Nice Bro !!!", DateTime.Now, "userimage.png"),
            new CommentModule("Alice", "Writer", "O yeah", new DateTime(2023, 7, 10, 18, 5, 0), "userimage.png"),
            new CommentModule("Jim", "Editor","Thanks", new DateTime(2023, 7, 10), "userimage.png")
        };
    }

    [RelayCommand]
    void ChangeCommentVisibility() {
        CommentVisibility = !CommentVisibility;
    }
}