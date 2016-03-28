using Xamarin.Forms;
using XTCSample.Views;

namespace XTCSample
{
    public class App : Application
    {
        private static readonly Locator _locator = new Locator();

        internal static Locator Locator => _locator;

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new OverviewView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
