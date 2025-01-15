using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace itshop.Views
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void OnChangeLanguageClicked(object sender, EventArgs e)
        {
            // จัดการการเปลี่ยนภาษา
            // สามารถเพิ่มการเปลี่ยนภาษาในแอปของคุณได้
            DisplayAlert("Change Language", "Here you can change the language", "OK");
        }

        private void OnAccountSettingsClicked(object sender, EventArgs e)
        {
            // จัดการการตั้งค่าบัญชีผู้ใช้
            // นำทางไปยังหน้าที่เกี่ยวข้องกับการตั้งค่าบัญชี
            DisplayAlert("Account Settings", "Manage your account settings", "OK");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            
            await Navigation.PopToRootAsync(); // นำทางกลับไปยังหน้าแรก (หน้าล็อกอิน)
        }
    }
}
