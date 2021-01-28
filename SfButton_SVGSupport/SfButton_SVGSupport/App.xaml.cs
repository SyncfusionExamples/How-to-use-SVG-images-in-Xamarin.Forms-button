using System;
using Xamarin.Forms;
using Xamarin.Forms.Svg;
using Xamarin.Forms.Xaml;

namespace SfButton_SVGSupport
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SvgImageSource.RegisterAssembly();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
