using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using XamaFilm.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

namespace XamaFilm.UWP.Renderers
{
    public class HyperLinkControlRenderer : ViewRenderer<HyperLinkControl, HyperlinkButton>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HyperLinkControl> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
                return;

            var element = new HyperlinkButton
            {
                Content = Element.Text
            };

            element.Click += (sender, args) =>
            {
                 if (Element.NavigateUri.Contains("www.") ||
                    Element.NavigateUri.Contains("http:"))
                {
                    var uri = Element.NavigateUri.StartsWith("http:")
                                  ? new Uri(Element.NavigateUri)
                                  : new Uri(@"http://" + Element.NavigateUri);
                    HyperlinkButton hyperlink = new HyperlinkButton() { NavigateUri = uri };                    
                }
            };

            SetNativeControl(element);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if ((e.PropertyName == Label.TextProperty.PropertyName))
                Control.Content = Element.Text;
        }
    }
}
