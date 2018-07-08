﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamaFilm.Controls;
using XamaFilm.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HyperLinkControl), typeof(HyperLinkControlRenderer))]

namespace XamaFilm.iOS.Renderers
{
    public class HyperLinkControlRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var label = Control;
                label.TextColor = UIColor.Red;
                label.BackgroundColor = UIColor.Clear;
                label.UserInteractionEnabled = true;
                var tap = new UITapGestureRecognizer();

                tap.AddTarget(() =>
                {
                    var hyperLinkLabel = Element as HyperLinkControl;

                    if (hyperLinkLabel != null)
                    {
                        var uri = hyperLinkLabel.NavigateUri;

                        if (uri.Contains("@") && !uri.StartsWith("mailto:"))
                            uri = string.Format("{0}{1}", "mailto:", uri);
                        else if (uri.StartsWith("www."))
                            uri = string.Format("{0}{1}", @"http://", uri);

                        UIApplication.SharedApplication.OpenUrl(new NSUrl(uri));
                    }
                });

                tap.NumberOfTapsRequired = 1;
                tap.DelaysTouchesBegan = true;
                label.AddGestureRecognizer(tap);
            }
        }
    }
}