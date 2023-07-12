using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using YouDo.MVVM.ViewModel;

namespace YouDo.MVVM.Model.MainModels.BlogModels;

public partial class BlogContentModel : BaseContentModel{

    [ObservableProperty]
    string blogContent = "";

    string temp_BlogContent;

    [ObservableProperty]
    bool commentVisibility = false;

    [ObservableProperty]
    ObservableCollection<CommentModule> comments;

    static int temp_maxLines = 3;

    [ObservableProperty]
    int maxLines = temp_maxLines;

    int maxCharacters = 110;

    private bool isExpanded = true;

    public BlogContentModel(string username, string userdefenition, string blogcontent, DateTime releasedate, string userIconPath) :
        base(username, userdefenition, releasedate, userIconPath)
        {
        
        temp_BlogContent = blogcontent;
        blogContent = temp_BlogContent;
        ExpandedContent();

        comments = new ObservableCollection<CommentModule> {
            new CommentModule("Alex", "Developer", "Nice Bro !!!", DateTime.Now, "userimage.png"),
            new CommentModule("Alice", "Writer", "O yeah", new DateTime(2023, 7, 10, 18, 5, 0), "userimage.png"),
            new CommentModule("Jim", "Editor","Thanks", new DateTime(2023, 7, 10), "userimage.png")
        };
    }
    
    private void ExpandedContent() {
        if (isExpanded) {
            MaxLines = temp_maxLines;
            if (temp_BlogContent.Length >= maxCharacters) {
                BlogContent = temp_BlogContent.Substring(0, maxCharacters) + "...";
            }
        } else {
            MaxLines = int.MaxValue;
            BlogContent = temp_BlogContent;
        }

        isExpanded = !isExpanded;
    }


    [RelayCommand]
    void ChangeCommentVisibility() {
        CommentVisibility = !CommentVisibility;
    }


    [RelayCommand]
    private void LabelTapped(Label contentLabel) {
        ExpandedContent();
        contentLabel.MaxLines = MaxLines;
        contentLabel.Text = BlogContent;
    }


}