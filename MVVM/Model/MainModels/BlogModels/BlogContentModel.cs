using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using YouDo.MVVM.ViewModel;

namespace YouDo.MVVM.Model.MainModels;

public partial class BlogContentModel : BaseContentModel{
    /// <summary>
    /// Sub class of BaseContentModel
    /// Blog content includes other related informations like blog content text, visibility of comments, comments (another data type).
    /// </summary>

    [ObservableProperty]
    string content = "";

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
        content = temp_BlogContent;
        ExpandedContent();

        // Adding new comments for testing
        comments = new ObservableCollection<CommentModule> {
            new CommentModule("Alex", "Developer", "Nice Bro !!!", DateTime.Now, "userimage.png"),
            new CommentModule("Alice", "Writer", "O yeah", new DateTime(2023, 7, 10, 18, 5, 0), "userimage.png"),
            new CommentModule("Jim", "Editor","Thanks", new DateTime(2023, 7, 10), "userimage.png")
        };
    }
    
    /// <summary>
    /// Normally a content has 3 lines.
    /// Expand the content to see all lines and words.
    /// This method removes See more (...) part too.
    /// This works reverse too.
    /// </summary>
    private void ExpandedContent() {
        if (isExpanded) {
            MaxLines = temp_maxLines;
            if (temp_BlogContent.Length >= maxCharacters) {
                Content = temp_BlogContent.Substring(0, maxCharacters) + "...";
            }
        } else {
            MaxLines = int.MaxValue;
            Content = temp_BlogContent;
        }

        isExpanded = !isExpanded;
    }


    [RelayCommand]
    void ChangeCommentVisibility() {
        CommentVisibility = !CommentVisibility;
    }


    /// <summary>
    /// If user tab to content label (which include the source text)
    /// The content is expanded or collapsed
    /// </summary>
    /// <param name="contentLabel">Self label</param>
    [RelayCommand]
    private void LabelTapped(Label contentLabel) {
        ExpandedContent();
        contentLabel.MaxLines = MaxLines;
        contentLabel.Text = Content;
    }


}