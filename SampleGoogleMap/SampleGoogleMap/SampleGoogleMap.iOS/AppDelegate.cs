using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace SampleGoogleMap.iOS
{

    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsGoogleMaps.Init("アクセスキー"); //追加
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
