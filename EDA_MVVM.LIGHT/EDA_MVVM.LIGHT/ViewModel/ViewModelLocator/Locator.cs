using EDA_MVVM.LIGHT.ViewModel;
using System;
using Unity;
using WAA_MVVM.Services.Navigation;

namespace WAA_MVVM.ViewModel.ViewModelLocator
{
    public class Locator
    {
        private readonly IUnityContainer _container;
        private static readonly Locator _instance = new Locator();

        public static Locator Instance
        {
            get { return _instance; }
        }


        public Locator()
        {
            _container = new UnityContainer();

            //Registro de Interfaces
            _container.RegisterType<INavigationService, NavigationService>();
            // _container.RegisterType<IServiceMessages, ServiceMessages>();
            //registro de ViewModel
            _container.RegisterType<FeedViewModel>();

        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}
