using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace itshop.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void OnEditProfileClicked(object sender, EventArgs e)
        {
            // นำทางไปยังหน้าจัดการโปรไฟล์ (แก้ไขข้อมูลผู้ใช้)
            await DisplayAlert("Edit Profile", "You can edit your profile here.", "OK");
        }

        private async void OnChangePasswordClicked(object sender, EventArgs e)
        {
            // ฟังก์ชันเปลี่ยนรหัสผ่าน
            await DisplayAlert("Change Password", "Change your password here.", "OK");
        }

        private async void OnManagePaymentsClicked(object sender, EventArgs e)
        {
            // ฟังก์ชันจัดการวิธีการชำระเงิน
            await DisplayAlert("Manage Payments", "Manage your payment methods here.", "OK");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // ฟังก์ชันออกจากระบบ
            await DisplayAlert("Logout", "You have logged out successfully.", "OK");
            // เพิ่มการเซ็นเอาท์หรือการนำทางไปยังหน้า login
            await Navigation.PopToRootAsync(); // นำทางกลับไปที่หน้า login
        }
    }
}
