﻿using EDA_MVVM.LIGHT.View;
using EDA_MVVM.LIGHT.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WAA_MVVM.ViewModel.ViewModelLocator;
using Xamarin.Forms;

namespace WAA_MVVM.Services.Navigation
{
    public class NavigationService : INavigationService
    {

        protected readonly Dictionary<Type, Type> _mappings;

        protected Application CurrentApplication
        {
            get { return Application.Current; }
        }

        public NavigationService()
        {

            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();
        }

        public Task InitializeAsync()
        {
            return NavigateToAsync<FeedViewModel>();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : BaseVM
        {
            return InternalNavigateToAsync(typeof(TViewModel), null);
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseVM
        {
            return InternalNavigateToAsync(typeof(TViewModel), parameter);
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            return InternalNavigateToAsync(viewModelType, null);
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            return InternalNavigateToAsync(viewModelType, parameter);
        }

        /// <summary>
        /// NavigationPage 
        /// </summary>
        /// <param name="page">Page.</param>
        public void NavPage(Page page)
        {
            Application.Current.MainPage = new NavigationPage(page);
        }


        /// <summary>
        /// Navega para próxima pagina async
        /// </summary>
        /// <param name="page">Page.</param>
        public void NavAsyncPage(Page page)
        {
            Device.BeginInvokeOnMainThread(async () => {
                await Application.Current.MainPage.Navigation.PushAsync(page);
            });

        }


        //Singleton navigation service
        private static NavigationService instance = null;
        private static readonly object padlock = new object();

        public static NavigationService Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new NavigationService();
                    }
                    return instance;
                }
            }
        }


        public virtual async Task InternalNavigateToAsync(Type viewModelType, object parameter)
        {
            Page page = CreateAndBindPage(viewModelType, parameter);

            if (page is FeedView)
            {
                //CurrentApplication.MainPage = page;
                CurrentApplication.MainPage = new NavigationPage(page);
            }
            await (page.BindingContext as BaseVM).InitializeAsync(parameter);
        }

        protected Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"não existe mapeamento para ${viewModelType} por isso a navegação não está funcionando, mapeie a view model no método CreatePageViewModelMappings");
            }
            return _mappings[viewModelType];
        }


        /// <summary>
        /// Cria o bind das paginas automaticamente
        /// </summary>
        /// <returns>The and bind page.</returns>
        /// <param name="viewModelType">View model type.</param>
        /// <param name="parameter">Parameter.</param>
        public Page CreateAndBindPage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"A view model {viewModelType} não esta mapeado para uma page");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            BaseVM viewModel = Locator.Instance.Resolve(viewModelType) as BaseVM;
            page.BindingContext = viewModel;
            return page;
        }


        public void CreatePageViewModelMappings()
        {
            _mappings.Add(typeof(FeedViewModel), typeof(FeedView));
        }
    }
}
