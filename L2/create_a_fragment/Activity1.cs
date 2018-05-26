using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace CreateAFragment
{
    [Activity(Label = "Лабораторна робота 2",
        MainLauncher = true,
        Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
                int count = 1;
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.Main);
            var tv2 = FindViewById<TextView>(Resource.Id.textView2);
            tv2.Text= "Выберите автора и год издательства";
                Button button = FindViewById<Button>(Resource.Id.button1);
              
                var rb4 = FindViewById<RadioButton>(Resource.Id.radioButton4);
                var rb5 = FindViewById<RadioButton>(Resource.Id.radioButton5);
                TextView tv = FindViewById<TextView>(Resource.Id.textView1);
            button.Click += delegate
            {
                tv.Text = "Автор и год ";
                if (rb4.Checked) tv.Text += rb4.Text;
                if (rb5.Checked) tv.Text += rb5.Text;
            };
        }
        
    }
}