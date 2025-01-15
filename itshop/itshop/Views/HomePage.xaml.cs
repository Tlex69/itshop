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
            // ตรวจสอบว่าหน้าปัจจุบันไม่ใช่ ProfilePage
            if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is ProfilePage))
            {
                await Navigation.PushAsync(new ProfilePage());
            }
        }

        private async void OnCartClicked(object sender, EventArgs e)
        {
            // ตรวจสอบว่าหน้าปัจจุบันไม่ใช่ CartPage
            if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is CartPage))
            {
                await Navigation.PushAsync(new CartPage());
            }
        }

        private async void OnAccessoriesTapped(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า AccessoriesPage หรือแสดงข้อความ
            await DisplayAlert("Tapped", "You tapped Accessories", "OK");
        }

        private async void OnCameraTapped(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า CameraPage หรือแสดงข้อความ
            await DisplayAlert("Tapped", "You tapped Camera", "OK");
        }

        private async void OnLaptopTapped(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า LaptopPage หรือแสดงข้อความ
            await DisplayAlert("Tapped", "You tapped Laptop", "OK");
        }

        private async void OnSmartphoneTapped(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า SmartphonePage หรือแสดงข้อความ
            await DisplayAlert("Tapped", "You tapped Smartphone", "OK");
        }

        private async void OnViewAllTapped(object sender, EventArgs e)
        {
            // นำทางไปยังหน้า ProductsPage
            await Navigation.PushAsync(new ProductsPage());
        }


        private async void OnMenuButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Menu", "Cancel", null,
                "Home", "Products", "Settings", "Logout");

            switch (action)
            {
                case "Home":
                    // ตรวจสอบว่าหน้าปัจจุบันไม่ใช่ HomePage
                    if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is HomePage))
                    {
                        await Navigation.PushAsync(new HomePage());
                    }
                    break;
                case "Settings":
                    // ตรวจสอบว่าหน้าปัจจุบันไม่ใช่ SettingPage
                    if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is SettingPage))
                    {
                        await Navigation.PushAsync(new SettingPage());
                    }
                    break;
                case "Products":
                    // ตรวจสอบว่าหน้าปัจจุบันไม่ใช่ ProductsPage
                    if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is ProductsPage))
                    {
                        await Navigation.PushAsync(new ProductsPage());
                    }
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
