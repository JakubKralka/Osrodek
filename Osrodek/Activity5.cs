using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Osrodek
{
    [Activity(Label = "Activity5")]
    public class Activity5 : Activity
    {


        Android.Support.V7.Widget.RecyclerView mRecyclerView;
        Android.Support.V7.Widget.RecyclerView.LayoutManager mLayoutManager;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout3);
            mRecyclerView = FindViewById<Android.Support.V7.Widget.RecyclerView>(Resource.Id.recyclerView);

            // Plug in the linear layout manager:
            mLayoutManager = new Android.Support.V7.Widget.LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            // Plug in my adapter:
            var mAdapter = new RecyclerAdapter(Resource.Mipmap.promo);
            mRecyclerView.SetAdapter(mAdapter);
        }
    }
}