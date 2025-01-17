﻿using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;

namespace Osrodek
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            AppCompatButton image1 = FindViewById<AppCompatButton>(Resource.Id.image1);
            image1.Click += image1Click;

            AppCompatButton image2 = FindViewById<AppCompatButton>(Resource.Id.image2);
            image2.Click += image2Click;
            
            AppCompatButton image3 = FindViewById<AppCompatButton>(Resource.Id.image3);
            image3.Click += image3Click;
            
            AppCompatButton image4 = FindViewById<AppCompatButton>(Resource.Id.image4);
            image4.Click += image4Click;
            
            AppCompatButton image5 = FindViewById<AppCompatButton>(Resource.Id.image5);
            image5.Click += image5Click;

        }

        private void image1Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity1));
            StartActivity(intent);
        }

        private void image2Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity3));
            StartActivity(intent);
        }

        private void image3Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity2));
            StartActivity(intent);
        }

        private void image4Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity4));
            StartActivity(intent);
        }

        private void image5Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity5));
            StartActivity(intent);
        }


        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.menu_info)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
	}
}

