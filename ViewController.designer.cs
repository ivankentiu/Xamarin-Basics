// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace MyFirstApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch colorSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progressView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel switchLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider textSizeSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView textView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (button != null) {
                button.Dispose ();
                button = null;
            }

            if (colorSwitch != null) {
                colorSwitch.Dispose ();
                colorSwitch = null;
            }

            if (progressView != null) {
                progressView.Dispose ();
                progressView = null;
            }

            if (switchLabel != null) {
                switchLabel.Dispose ();
                switchLabel = null;
            }

            if (textField != null) {
                textField.Dispose ();
                textField = null;
            }

            if (textSizeSlider != null) {
                textSizeSlider.Dispose ();
                textSizeSlider = null;
            }

            if (textView != null) {
                textView.Dispose ();
                textView = null;
            }
        }
    }
}