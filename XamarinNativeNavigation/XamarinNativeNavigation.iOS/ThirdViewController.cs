﻿using System;

using UIKit;

namespace XamarinNativeNavigation.iOS
{
    public partial class ThirdViewController : UIViewController
    {
        public ThirdViewController() : base("ThirdViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Third";
            // Perform any additional setup after loading the view, typically from a nib.

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

