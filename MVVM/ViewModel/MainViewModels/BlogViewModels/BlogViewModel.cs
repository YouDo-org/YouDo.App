using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using YouDo.MVVM.Model.MainModels.BlogModels;

namespace YouDo.MVVM.ViewModel.MainViewModels.BlogViewModels;
public partial class BlogViewModel : BaseViewModel {

    [ObservableProperty]
    public ObservableCollection<BlogContentModel> blogContents;

    public BlogViewModel() {
        blogContents = new ObservableCollection<BlogContentModel>() { };
        blogContents.Add(new BlogContentModel { UserName = "Jack", UserDefenition = "Software Developer", BlogContent = "Hi Guys" }); 
    }
}

