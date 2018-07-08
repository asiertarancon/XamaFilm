using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Util;
using Android.Views;
using Android.Widget;
using XamaFilm.Controls;
using XamaFilm.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HyperLinkControl), typeof(HyperLinkControlRenderer))]

namespace XamaFilm.Droid.Renderers
{
    public class HyperLinkControlRenderer : LabelRenderer
    {
        public HyperLinkControlRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var nativeEditText = Control;
                Linkify.AddLinks(nativeEditText, MatchOptions.WebUrls);
            }
        }
    }
}