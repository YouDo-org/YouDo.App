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
        blogContents = new ObservableCollection<BlogContentModel> {
            new BlogContentModel("John", "Developer", "Hello", DateTime.Now),
            new BlogContentModel("Alice", "Designer", "Hi there", DateTime.Now)
        };
    }
}

