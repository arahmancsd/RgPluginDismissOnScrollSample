using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace RgPluginDismissOnScrollSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SamplePopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public SamplePopup()
        {
            InitializeComponent();
        }
        private void ScrollView_Scrolled(object sender, Xamarin.Forms.ScrolledEventArgs e)
        {
            // sample to close form when scroll down reaches certian limit
            if (e.ScrollY < 100)
            {
                PopupNavigation.Instance.PopAsync();
            }
        }
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}