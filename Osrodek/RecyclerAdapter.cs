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
    public class RecyclerAdapter : Android.Support.V7.Widget.RecyclerView.Adapter
    {

        int resId;
        
        public RecyclerAdapter(int resid)
        {
            this.resId = resid;
        }

        public override Android.Support.V7.Widget.RecyclerView.ViewHolder
            OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.recycler_item, parent, false);
            RecyclerViewHolder vh = new RecyclerViewHolder(itemView);
            return vh;
        }

        public override void
            OnBindViewHolder(Android.Support.V7.Widget.RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder vh = holder as RecyclerViewHolder;
            vh.Image.SetImageResource(resId);
            vh.Caption.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod temp" +
                "or incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercit" +
                "ation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in repreh" +
                "enderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaeca" +
                "t cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }

        public override int ItemCount
        {
            get { return 5; }
        }
    }
}