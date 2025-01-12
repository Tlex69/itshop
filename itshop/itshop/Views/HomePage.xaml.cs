using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace itshop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void MenuButton_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.MainPage is MasterDetailPage masterDetailPage)
            {
                masterDetailPage.IsPresented = !masterDetailPage.IsPresented; // Toggle Flyout
            }
        }
    }
}
