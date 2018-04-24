using System;
using System.Linq;
using App.Shared;
using UIKit;

namespace App.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            foreach (var item in View.Subviews)
            {
                var label = item as UILabel;
                if (label != null)
                {
                    label.Text = Api.GetText();
                    label.TextColor = UIColor.Orange;

                    break;
                }
            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}