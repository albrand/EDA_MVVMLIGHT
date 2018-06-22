using DLToolkit.Forms.Controls;
using System;
using System.Threading.Tasks;
using WAA_MVVM.Services.Navigation;
using WAA_MVVM.ViewModel.ViewModelLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EDA_MVVM.LIGHT
{
	public partial class App : Application
	{
		public App ()
		{
            DependencyService.Register<INavigationService, NavigationService>();
            InitializeComponent();
            InitPlugins();
            InitNavigation();
        }

        public Task InitNavigation()
        {
            var navigationService = Locator.Instance.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        public void InitPlugins()
        {
            FlowListView.Init();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
