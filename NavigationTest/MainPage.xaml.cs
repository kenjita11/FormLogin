using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;



namespace NavigationTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        { 
            InitializeComponent();
        }
       
        private void btn_Login(object sender, EventArgs args)
        {
            // lấy dữ liệu người dùng nhập vào
            string usrname = username.Text;
            string pw = password.Text;
            if (string.IsNullOrEmpty(usrname) || string.IsNullOrEmpty(pw))
            {
                DisplayAlert("GMO Z.COM Runsystem", "bạn cần nhập đủ 2 thông tin", "OK");
            }
            else
            {
                int count = 0;

                // kiểm tra tài khoản + mật khẩu nhập vào
                for(int i = 0; i < UserData.UsrData.Count; i++)
                {
                    if(usrname == UserData.UsrData[i].name && pw == UserData.UsrData[i].pw)
                    {
                        count++;
                        break;
                    }
                }

                //----- nếu đúng thì chuyển trang-----//
                if(count != 0)
                    Navigation.PushAsync(new Login());
                else
                    DisplayAlert("GMO Z.COM Runsystem", "sai thông tin đăng nhập", "OK");
            }
        }
        private void btn_SignUp(object sender, EventArgs args)
        {
            Navigation.PushAsync(new SignUp());
        }
    }
}
