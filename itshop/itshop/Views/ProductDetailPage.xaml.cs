using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace itshop
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(string v)
        {
            InitializeComponent();
        }

        private async void OnBuyNowClicked(object sender, EventArgs e)
        {
            // เพิ่มสินค้าลงในตะกร้า (ตัวอย่าง)
            var product = new
            {
                Name = "Product Name",
                Price = 99.99,
                Quantity = 1
            };

            // เก็บสินค้าในตะกร้า (คุณสามารถใช้ระบบจัดการตะกร้าของคุณเอง)
            CartService.AddToCart(product);

            // นำทางไปยังหน้า CartPage
            await Navigation.PushAsync(new CartPage());
        }
    }

    // ตัวอย่าง CartService
    public static class CartService
    {
        public static List<object> CartItems { get; private set; } = new List<object>();

        public static void AddToCart(object product)
        {
            CartItems.Add(product);
        }
    }
}
