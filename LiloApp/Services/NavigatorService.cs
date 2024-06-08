using Microsoft.AspNetCore.Components;

namespace LiloApp.Services
{
    public class NavigatorService
    {
        private string currentPage = "";
        public string CurrentPage
        {
            get => currentPage;
            private set
            {
                if (currentPage != value)
                {
                    currentPage = value;
                    OnPageChanged?.Invoke();
                }
            }
        }

        public event Action OnPageChanged;

        public NavigationManager NavigationManager { get; set; }

        public void NavigateTo(string pageName)
        {
            CurrentPage = pageName;
        }
    }
}
