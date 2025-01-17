using System;
using Xamarin.Forms;

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
            if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is ProfilePage))
            {
                await Navigation.PushAsync(new ProfilePage());
            }
        }

        // เมื่อกดที่ไอคอนรถเข็น
        private async void OnCartClicked(object sender, EventArgs e)
        {
            if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is CartPage))
            {
                await Navigation.PushAsync(new CartPage());
            }
        }
        private async void OnAccessoriesTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetailPage("Accessories"));
        }
        // เมื่อกดการ์ด Accessories
        private async void OnCartTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetailPage("Accessories"));
        }

        // เมื่อกดการ์ด Camera
        private async void OnCameraTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetailPage("Camera"));
        }

        // เมื่อกดการ์ด Laptop
        private async void OnLaptopTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetailPage("Laptop"));
        }

        // เมื่อกดการ์ด Smartphone
        private async void OnSmartphoneTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetailPage("Smartphone"));
        }

        // เมื่อกด View All
        private async void OnViewAllTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }



        // เมนูหลัก
        private async void OnMenuButtonClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Menu", "Cancel", null,
                "Home", "Products", "Settings", "Logout");

            switch (action)
            {
                case "Home":
                    if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is HomePage))
                    {
                        await Navigation.PushAsync(new HomePage());
                    }
                    break;

                case "Products":
                    if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is ProductsPage))
                    {
                        await Navigation.PushAsync(new ProductsPage());
                    }
                    break;

                case "Settings":
                    if (!(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1] is SettingPage))
                    {
                        await Navigation.PushAsync(new SettingPage());
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
