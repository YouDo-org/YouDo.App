using System.Diagnostics;
using YouDo.MVVM.View.MainViews.BlogViews;

namespace YouDo.MVVM.View.MainViews;

public partial class BottomNavigationBar : ContentView {
	public BottomNavigationBar() {
		InitializeComponent();
	}

    private void Navigate(string page_name) {
        // Shell.Current.CurrentState.ToString()
        string[] path = Shell.Current.CurrentPage.ToString().Split(".");
        string class_name = path[path.Length - 1];

        if (class_name != page_name) {
            var task = new Task(() => { Shell.Current.GoToAsync(page_name, false); });
            task.RunSynchronously();
        }
    }

    private void NavigateMap(object sender, EventArgs e) {
        Navigate(nameof(MapPage));
    }

    private void NavigateEvents(object sender, EventArgs e) {
        Navigate(nameof(EventsPage));
    }

    private void NavigateCreate(object sender, EventArgs e) {
        Navigate(nameof(CreatePage));
    }

    private void NavigateCampaigns(object sender, EventArgs e) {
        Navigate(nameof(CampaignsPage));
    }

    private void NavigateBlog(object sender, EventArgs e) {
        Navigate(nameof(BlogPage));
    }
}