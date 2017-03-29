// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOSToastNotification
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDefault { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnError { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnNotice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnWarning { get; set; }

        [Action ("BtnDefault_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnDefault_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnError_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnError_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnInfo_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnInfo_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnNotice_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnNotice_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnWarning_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnWarning_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnDefault != null) {
                btnDefault.Dispose ();
                btnDefault = null;
            }

            if (btnError != null) {
                btnError.Dispose ();
                btnError = null;
            }

            if (btnInfo != null) {
                btnInfo.Dispose ();
                btnInfo = null;
            }

            if (btnNotice != null) {
                btnNotice.Dispose ();
                btnNotice = null;
            }

            if (btnWarning != null) {
                btnWarning.Dispose ();
                btnWarning = null;
            }
        }
    }
}