﻿using Foundation;
using UIKit;

namespace Xamarin.CardIo.Sample
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // create a new window instance based on the screen size
            Window = new UIWindow(UIScreen.MainScreen.Bounds)
            {
                RootViewController = new UINavigationController(new CardIoViewController())
            };

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}

