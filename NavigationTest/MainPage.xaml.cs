using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace NavigationTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var hotline = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(10, 0, 10, 0),
            };
            Container.Children.Add(hotline);

            var phoneCall = new Button
            {
                Text = "CALL",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200,
                BorderColor = Color.Blue,
                BorderWidth = 1,
                TextColor = Color.Red,
            };
            var lbl_HotLine = new Label
            {
                Text = "Hotline: ",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            hotline.Children.Add(lbl_HotLine);
            hotline.Children.Add(phoneCall);
        
            phoneCall.Clicked += (sender, e) =>
            {
                var phoneNumber = "01693338069";
                DependencyService.Get<IPhoneCall>().MakePhoneCall(phoneNumber);
            };
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
