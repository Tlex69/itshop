using itshop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace itshop
{
    public partial class LoginPage : ContentPage
    {
        // ตั้งค่าชื่อผู้ใช้และรหัสผ่านที่กำหนดไว้ล่วงหน้า
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "123";

        public LoginPage()
        {
            InitializeComponent();
        }

        // เมื่อคลิกปุ่ม Login
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var username = UsernameEntry.Text;
            var password = PasswordEntry.Text;

            // ตรวจสอบชื่อผู้ใช้และรหัสผ่าน
            if (username == CorrectUsername && password == CorrectPassword)
            {
                // ถ้าถูกต้อง ไปยังหน้า Home
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                // ถ้าผิดพลาดแสดงข้อความเตือน
                await DisplayAlert("Login Failed", "Invalid username or password.", "OK");
            }
        }

        // เมื่อคลิกปุ่ม Register
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            // นำไปยังหน้าลงทะเบียน
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
