// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CourtCalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getCourtDateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Main { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel secondMainLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton waiverFineButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel welcomeLabel { get; set; }

        [Action ("GetCourtDateButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GetCourtDateButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (getCourtDateButton != null) {
                getCourtDateButton.Dispose ();
                getCourtDateButton = null;
            }

            if (Main != null) {
                Main.Dispose ();
                Main = null;
            }

            if (secondMainLabel != null) {
                secondMainLabel.Dispose ();
                secondMainLabel = null;
            }

            if (waiverFineButton != null) {
                waiverFineButton.Dispose ();
                waiverFineButton = null;
            }

            if (welcomeLabel != null) {
                welcomeLabel.Dispose ();
                welcomeLabel = null;
            }
        }
    }
}