using Foundation;
using System;
using UIKit;

namespace XamarinNativeNavigation.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            Title = "First";
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            HelloLabel.Text = "Good bye";
            FirstNavigatioButton.SetTitle("First Navigation", UIControlState.Normal);
            FirstNavigatioButton.TouchUpInside += FirstNavigatioButton_TouchUpInside;
        }

        private void FirstNavigatioButton_TouchUpInside(object sender, EventArgs e)
        {
            var board = UIStoryboard.FromName("Main", null);
            var vc2 = board.InstantiateViewController("SecondSBViewController") as SecondSBViewController;
            this.NavigationController.PushViewController(vc2, true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
