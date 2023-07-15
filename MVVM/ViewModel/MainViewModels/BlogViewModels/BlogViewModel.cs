using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using YouDo.MVVM.Model.MainModels.BlogModels;
using YouDo.MVVM.View.MainViews.BlogViews;

namespace YouDo.MVVM.ViewModel.MainViewModels.BlogViewModels;
public partial class BlogViewModel : BaseViewModel {

    [ObservableProperty]
    ObservableCollection<BlogContentModel> blogContents;

    public BlogViewModel() {
        // YouDo.MVVM.ViewModel.MainViewModels.BlogViewModels.BlogViewModel
        blogContents = new ObservableCollection<BlogContentModel> {
            new BlogContentModel("John", "Developer", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In posuere vehicula quam, id varius est semper vitae. Vivamus a purus eu magna dapibus suscipit. Cras interdum vel purus quis finibus. Duis nec pellentesque massa. Vestibulum sollicitudin felis nulla, vitae sodales purus vulputate eu. Nam mollis diam sed placerat aliquet. Etiam tempus egestas justo nec dictum. ", DateTime.Now, "userimage.png"),
            new BlogContentModel("Alice", "Software Engineer", "Aliquam faucibus nec metus rhoncus bibendum. Fusce vulputate, tortor nec lobortis maximus, dolor lectus porta odio, nec tempus ligula nisl et eros. Nullam mattis at metus a lobortis. Sed a convallis diam. Curabitur quam sapien, cursus eu mauris vitae, sagittis porttitor libero. Fusce sed lacus sit amet massa pharetra porttitor et non arcu. Curabitur vel mattis dui, quis molestie justo. ", new DateTime(2023, 7, 10, 18, 5, 0), "userimage.png"),
            new BlogContentModel("Jack", "UI/UX Designer", "Praesent luctus odio eu tempor aliquam. Integer ut ex tristique, pulvinar sapien vitae, rutrum tortor. Aenean nisl arcu, tempor ac magna in, auctor pellentesque orci. Sed lacus enim, pretium lobortis nunc et, elementum lacinia mi. Sed rutrum, sem ut ullamcorper commodo, libero orci pretium nulla, eu volutpat nulla lectus in elit. ", new DateTime(2023, 7, 10), "userimage.png")
        };
    }

    [RelayCommand]
    async void GoToWriteBlogPageAsync() {
        await Shell.Current.GoToAsync($"../{nameof(BlogWritePage)}", true);
    }
}

