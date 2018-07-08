using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamaFilm.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XamaFilm.Behaviors
{
    public class MapBehavior : BindableBehavior<Map>
    {
        private Map _map;

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.CreateAttached("ItemsSource", typeof(IEnumerable<Movie>), typeof(MapBehavior),
                default(IEnumerable<Movie>), BindingMode.Default, null, OnItemsSourceChanged);

        public IEnumerable<Movie> ItemsSource
        {
            get { return (IEnumerable<Movie>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly BindableProperty ItemSourceProperty =
            BindableProperty.CreateAttached("ItemSource", typeof(Movie), typeof(MapBehavior),
                default(Movie), BindingMode.Default, null, OnItemSourceChanged);
        public Movie ItemSource
        {
            get { return (Movie)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        private static void OnItemsSourceChanged(BindableObject view, object oldValue, object newValue)
        {
            var mapBehavior = view as MapBehavior;

            if (mapBehavior != null)
            {
                mapBehavior.AddPins();
                mapBehavior.PositionMap();
            }
        }

        private static void OnItemSourceChanged(BindableObject view, object oldValue, object newValue)
        {
            var mapBehavior = view as MapBehavior;

            if (mapBehavior != null)
            {
                mapBehavior.AddPin(newValue as Movie);
                mapBehavior.PositionMap();
            }
        }

        protected override void OnAttachedTo(Map bindable)
        {
            base.OnAttachedTo(bindable);

            _map = bindable;
        }

        protected override void OnDetachingFrom(Map bindable)
        {
            base.OnDetachingFrom(bindable);

            _map = null;
        }

        private void AddPin(Movie movie)
        {
            for (int i = _map.Pins.Count - 1; i >= 0; i--)
            {
                _map.Pins.RemoveAt(i);
            }
            var pin = new Pin
            {
                Type = PinType.SearchResult,
                Position = new Position(movie.Latitude, movie.Longitude),
                Label = string.Format("{0} ({1})", ItemSource.Title, ItemSource.Plot)
            };
            _map.Pins.Add(pin);
            _map.MoveToRegion(MapSpan.FromCenterAndRadius(pin.Position, Distance.FromKilometers(500)));
        }

        private void AddPins()
        {
            for (int i = _map.Pins.Count - 1; i >= 0; i--)
            {
                _map.Pins.RemoveAt(i);
            }

            var pins = ItemsSource.Select(x =>
            {
                var pin = new Pin
                {
                    Type = PinType.SearchResult,
                    Position = new Position(x.Latitude, x.Longitude),
                    Label = string.Format("{0} ({1})", x.Title, x.Plot)
                };

                return pin;
            }).ToArray();

            foreach (var pin in pins)
                _map.Pins.Add(pin);
        }

        private void PositionMap()
        {
            if (ItemsSource == null || !ItemsSource.Any()) return;

            var centerPosition = new Position(ItemsSource.Average(x => x.Latitude), ItemsSource.Average(x => x.Longitude));

            var distance = 0.5;

            _map.MoveToRegion(MapSpan.FromCenterAndRadius(centerPosition, Distance.FromMiles(distance)));

            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                _map.MoveToRegion(MapSpan.FromCenterAndRadius(centerPosition, Distance.FromMiles(distance)));

                return false;
            });
        }
    }
}

