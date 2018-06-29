using System;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationTest.iOS.PhoneCall_iOS))]
namespace NavigationTest.iOS
{
    public class PhoneCall_iOS : IPhoneCall
    {
        public PhoneCall_iOS()
        {
            
        }

        public void MakePhoneCall( string phoneNumber)
        {
            var phoneSchemal = "telprompt://" + phoneNumber;
            var url = new NSUrl(phoneSchemal);
            if (UIApplication.SharedApplication.CanOpenUrl(url))
            {
                UIApplication.SharedApplication.OpenUrl(url);
            }
        }
    }
}
