using Android.App;
using Android.Widget;
using Android.OS;
using App.Shared;

namespace App.Android
{
    [Activity(Label = "App.Android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var textView = FindViewById<TextView>(Resource.Id.myTextBox);
            textView.Text = Api.GetText();
        }
    }
}

