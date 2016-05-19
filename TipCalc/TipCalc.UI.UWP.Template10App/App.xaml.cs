using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace TipCalc.UI.UWP.Template10App
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App()
        {
            //            Microsoft.ApplicationInsights.WindowsAppInitializer.InitializeAsync(
            //Microsoft.ApplicationInsights.WindowsCollectors.Metadata |
            //Microsoft.ApplicationInsights.WindowsCollectors.Session);
            InitializeComponent();
        }

        protected override Frame CreateRootFrame(IActivatedEventArgs e)
        {
            var frame = base.CreateRootFrame(e);
            var setup = new Setup(frame);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();
            return frame;
        }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            await Task.CompletedTask;
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            //NavigationService.Navigate(typeof(Views.TipView));
            await Task.CompletedTask;
        }
    }
}

