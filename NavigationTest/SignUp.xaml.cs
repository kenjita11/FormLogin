using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationTest
{
   
    public partial class SignUp : ContentPage
    {
        
        public SignUp()
        {
            InitializeComponent();
            
        }
        public void btn_SignUp(object sender, EventArgs args)
        {
             
            int count = 0;

            // kiểm tra tài khoản đăng kí đã tồn tại chưa
            for (int i = 0; i < UserData.UsrData.Count; i++)
            {
                if(username_signup.Text == UserData.UsrData[i].name)
                {
                    count++;
                }
            }
    
            if(count != 0)
            {
                DisplayAlert("GMO Z.Com Runsystem", "tài khoản đã tồn tại", "OK");
            }

            // nếu chưa tồn tại thì add vào List UserData
            else
            {
                UserModel user = new UserModel()
                {
                    name = username_signup.Text,
                    pw = password_signup.Text,
                    email = email_signup.Text,
                };
                UserData.UsrData.Add(user);
                DisplayAlert("GMO Z.Com Runsystem", "Đăng kí thành công", "OK");
            }
        }
    }

}
