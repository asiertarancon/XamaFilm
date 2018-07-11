using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamaFilm.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly:ResolutionGroupName("XamaFilm")]
[assembly:ExportEffect(typeof(ShadowEffect), "ShadowEffect")]

namespace XamaFilm.Droid.Effects
{
    public class ShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = Control as TextView;

            if (label != null)
            {
                label.SetShadowLayer(5, 2, 2, Android.Graphics.Color.Black);
            }
        }

        protected override void OnDetached()
        {
            var label = Control as TextView;

            if (label != null)
            {
                label.SetShadowLayer(0, 0, 0, Android.Graphics.Color.Black);
            }
        }
    }
}