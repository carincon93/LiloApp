using LiloApp.Data;
using LiloApp.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LiloApp.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
	{
		private readonly DreamService _dreamService;
		private readonly DreamCalendarService _dreamCalendarService;
		private readonly GrupoMuscularService _grupoMuscularService;

		private List<DreamData> _dreams;
		private List<DreamCalendarData> _dreamCalendar;
		private List<GrupoMuscularData> _gruposMusculares;

		public List<DreamData> Dreams
		{
			get => _dreams;
			set
			{
				_dreams = value;
				OnPropertyChanged();
			}
		}

		public List<DreamCalendarData> DreamCalendar
		{
			get => _dreamCalendar;
			set
			{
				_dreamCalendar = value;
				OnPropertyChanged();
			}
		}

		public List<GrupoMuscularData> GruposMusculares
		{
			get => _gruposMusculares;
			set
			{
				_gruposMusculares = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel(DreamService dreamService, DreamCalendarService dreamCalendarService, GrupoMuscularService grupoMuscularService)
		{
			_dreamService = dreamService;
			_dreamCalendarService = dreamCalendarService;
			_grupoMuscularService = grupoMuscularService;

			LoadDataAsync().ConfigureAwait(false);
		}

		public async Task LoadDataAsync()
		{
			Dreams = await _dreamService.GetDreamsAsync();
			DreamCalendar = await _dreamCalendarService.GetDreamCalendarAsync();
			GruposMusculares = await _grupoMuscularService.GetGrupoMuscularAsync();
		}

		public async Task<bool> AddDreamAsync(DreamData newDream)
		{
			var success = await _dreamService.SaveDreamAsync(newDream) > 0;
			if (success)
			{
				Dreams = await _dreamService.GetDreamsAsync();
			}
			return success;
		}

		public async Task<bool> AddDreamCalendarAsync(DreamCalendarData newDreamCalendar)
		{
			var success = await _dreamCalendarService.SaveDreamCalendarAsync(newDreamCalendar) > 0;
			if (success)
			{
				DreamCalendar = await _dreamCalendarService.GetDreamCalendarAsync();
			}
			return success;
		}

		public async Task<bool> AddGrupoMuscularAsync(GrupoMuscularData newGrupoMuscular)
		{
			var success = await _grupoMuscularService.SaveGrupoMuscularAsync(newGrupoMuscular) > 0;
			if (success)
			{
				GruposMusculares = await _grupoMuscularService.GetGrupoMuscularAsync();
			}
			return success;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
