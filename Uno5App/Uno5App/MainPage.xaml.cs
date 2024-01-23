namespace Uno5App;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        MyWebView.NavigationStarting += MyWebView_NavigationStarting;
    }

    private void MyWebView_NavigationStarting(WebView2 sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs args)
    {
        NavigationStatusTextBlock.Text = "NavigationStarting has been raised";
    }
}
