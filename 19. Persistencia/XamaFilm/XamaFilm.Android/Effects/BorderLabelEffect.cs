using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamaFilm.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(BorderLabelEffect), "BorderLabelEffect")]
namespace XamaFilm.Droid.Effects
{
    public class BorderLabelEffect : PlatformEffect
    {
        GradientDrawable _border;
        protected override void OnAttached()
        {
            _border = new GradientDrawable();

            var label = Control as TextView;

            if (label != null)
            {
                label.SetPadding(1, 1, 1, 1);
                _border.SetStroke(1, Android.Graphics.Color.Black);
                label.SetBackground(_border);
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