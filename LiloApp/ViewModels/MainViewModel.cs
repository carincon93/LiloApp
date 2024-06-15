using LiloApp.Models;
using LiloApp.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LiloApp.ViewModels
{
    public class MainViewModel
    {
        private readonly ApiService _apiService;
        private List<Dream> _dreams;

        public List<Dream> Dreams
        {
            get => _dreams;
            set
            {
                _dreams = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(ApiService apiService)
        {
            _apiService = apiService;
            LoadDreamsAsync().ConfigureAwait(false);
        }

        public async Task LoadDreamsAsync()
        {
            Dreams = await _apiService.GetDreamsAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
