using System;
using Xamarin.Forms;
using Android.Content;
using NavigationTest.Droid;

[assembly: Dependency(typeof(PhoneCall_Android))]
namespace NavigationTest.Droid
{
    public class PhoneCall_Android : IPhoneCall
    {
        public PhoneCall_Android()
        {
            
        }

        public void MakePhoneCall(string phoneNumber)
        {
            Intent call = new Intent(Intent.ActionCall);
            call.SetData(Android.Net.Uri.Parse("tel:" + phoneNumber));
            Forms.Context.StartActivity(call);
        }
    }
}
