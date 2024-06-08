using LiloApp.Services;

namespace LiloApp
{
    public partial class App : Application
    {
        public App(NavigatorService navigatorService)
        {
            InitializeComponent();
            NavigatorService = navigatorService;
            MainPage = new MainPage();
        }

        public NavigatorService NavigatorService { get; }

    }
}
