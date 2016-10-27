using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace Test_Android
{
    [Activity(Label = "Proto_Pyt", MainLauncher = true, Icon = "@drawable/Gift_Icon_72")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            Button button1 = FindViewById<Button>(Resource.Id.pyt1_button);
            TextView textView = FindViewById<TextView>(Resource.Id.Pyt01);
            textView.SetBackgroundColor(Color.ParseColor("#696969"));
            String txtOne = "Du har valgt at sige pyt, så kom videre i livet!";
            String txtTwo = "Du har valg at trykke PYT, det betyder at du ikke skal bruge mere energi på det du har pyttet!";
            String txtThree = "PYT!! Og så er der fri bane fremad!";

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
            button.Click += delegate
            {
                if (DateTime.Now.Second % 3 == 1)
                {
                    textView.Text = txtOne;
                    textView.SetBackgroundColor(Color.Yellow);
                }
                else if (DateTime.Now.Second % 3 == 2)
                {
                    textView.Text = txtTwo;
                    textView.SetBackgroundColor(Color.ParseColor("#8DB600"));
                }
                else
                {
                    textView.Text = txtThree;
                    textView.SetBackgroundColor(Color.ParseColor("#00FF6F"));
                }
            };
            button1.Click += delegate {
                if (DateTime.Now.Second % 3 == 1)
                {
                    textView.Text = txtOne;
                    textView.SetBackgroundColor(Color.Yellow);
                }
                else if (DateTime.Now.Second % 3 == 2)
                {
                    textView.Text = txtTwo;
                    textView.SetBackgroundColor(Color.ParseColor("#8DB600"));
                }
                else
                {
                    textView.Text = txtThree;
                    textView.SetBackgroundColor(Color.ParseColor("#00FF6F"));
                }
            };
        }
    }
}

