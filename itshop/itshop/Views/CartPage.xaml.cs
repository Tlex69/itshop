using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace itshop
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();

            // ตั้งค่ารายการสินค้าในตะกร้า
            CartListView.ItemsSource = CartService.CartItems;
        }
    }
}
