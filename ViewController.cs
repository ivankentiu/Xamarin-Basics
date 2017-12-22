using System;
using System.Threading.Tasks;
using UIKit;

namespace MyFirstApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            textField.KeyboardType = UIKeyboardType.NumberPad;

            button.TouchUpInside += Button_TouchUpInside;
            colorSwitch.ValueChanged += ColorSwitch_ValueChanged;
            textSizeSlider.ValueChanged += TextSizeSlider_ValueChanged;
        }

        void TextSizeSlider_ValueChanged(object sender, EventArgs e)
        {
            var value = textSizeSlider.Value;
            textView.Font = UIFont.SystemFontOfSize(value);
        }

        void ColorSwitch_ValueChanged(object sender, EventArgs e)
        {
            if (colorSwitch.On)
                switchLabel.Text = "De-activate Color";
            else
                switchLabel.Text = "Activate Color";
        }

        void Button_TouchUpInside(object sender, EventArgs e)
        {
            textField.ResignFirstResponder();

            transportText();

            if (colorSwitch.On)
            {
                var randSeed = new Random();
                var rand1 = (float)randSeed.NextDouble();
                var rand2 = (float)randSeed.NextDouble();
                var rand3 = (float)randSeed.NextDouble();

                View.BackgroundColor = UIColor.FromRGB(rand1, rand2, rand3);
            }


        }

        private async void transportText()
        {
            textView.Text = "";

            while (textField.Text != "")
            {
                await Task.Factory.StartNew(() =>
                {
                    InvokeOnMainThread(() => {
                        var letter = textField.Text.Substring(0, 1);
                        textView.Text = textView.Text + letter;
                        textField.Text = textField.Text.Substring(1);
                        updateProgressView();
                    });
                   
                });
                await Task.Delay(500); // wait for half a sec before continuing
            }
        }

        private void updateProgressView()
        {
            var textLength = (float)(textField.Text.Length + textView.Text.Length); // ratio is better in float or double
            var transferProgress = textView.Text.Length / textLength; // int / float = float
            progressView.Progress = transferProgress;
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
