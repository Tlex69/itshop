using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace itshop.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        // เมื่อกดที่ไอคอนโปรไฟล์

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า ProfilePage
            await Navigation.PushAsync(new ProfilePage());
        }
        private async void OnCartClicked(object sender, EventArgs e)
        {
            // Navigate to the Cart Page (replace CartPage with your actual Cart page class)
            await Navigation.PushAsync(new CartPage());
        }

        private async void OnMenuButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Menu", "Cancel", null,
                "Home", "Settings", "Logout");

            switch (action)
            {
                case "Home":
                    await Navigation.PushAsync(new HomePage());
                    break;
                case "Settings":
                    await Navigation.PushAsync(new SettingPage());
                    break;
                case "Logout":
                  
                    await Navigation.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }
    }
}