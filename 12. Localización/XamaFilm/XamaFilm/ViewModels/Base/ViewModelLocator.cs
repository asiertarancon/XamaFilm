﻿using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Services;

namespace XamaFilm.ViewModels.Base
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<IDataService, MockDataService>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();

            SimpleIoc.Default.Register<AboutUsViewModel>();
            SimpleIoc.Default.Register<AcknowledgementViewModel>();
            SimpleIoc.Default.Register<DetailEpisodeViewModel>();
            SimpleIoc.Default.Register<DetailMovieViewModel>();
            SimpleIoc.Default.Register<DetailSeasonSerieViewModel>();
            SimpleIoc.Default.Register<DetailSerieViewModel>();
            SimpleIoc.Default.Register<FavoritesViewModel>();            
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<MenuViewModel>();
            SimpleIoc.Default.Register<MasterViewModel>();            
            SimpleIoc.Default.Register<MoviesListViewModel>();
            SimpleIoc.Default.Register<SeriesListViewModel>();            
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<WatchlistViewModel>();
        }
        public T Resolve<T>()
        {
            return SimpleIoc.Default.GetInstance<T>();
        }

        public object Resolve(Type type)
        {
            return SimpleIoc.Default.GetService(type);
        }

        public static ViewModelLocator Instance { get; } = new ViewModelLocator();
    }
}
