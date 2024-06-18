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
		private readonly MascotaService _mascotaService;
		private readonly AmoService _amoService;

        private List<DreamData> _dreams;
		private List<DreamCalendarData> _dreamCalendar;
		private List<GrupoMuscularData> _gruposMusculares;
		private List<MascotaData> _mascotas;
		private List<AmoData> _amos;

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
        public List<MascotaData> Mascotas
        {
            get => _mascotas;
            set
            {
                _mascotas = value;
                OnPropertyChanged();
            }
        }
        public List<AmoData> Amos
        {
            get => _amos;
            set
            {
                _amos = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(DreamService dreamService, DreamCalendarService dreamCalendarService, GrupoMuscularService grupoMuscularService, MascotaService mascotaService, AmoService amoService)
		{
			_dreamService = dreamService;
			_dreamCalendarService = dreamCalendarService;
			_grupoMuscularService = grupoMuscularService;
			_mascotaService = mascotaService;
			_amoService = amoService;

            LoadDataAsync().ConfigureAwait(false);
		}

		public async Task LoadDataAsync()
		{
			Dreams = await _dreamService.GetDreamsAsync();
			DreamCalendar = await _dreamCalendarService.GetDreamCalendarAsync();
			GruposMusculares = await _grupoMuscularService.GetGrupoMuscularAsync();
			Mascotas = await _mascotaService.GetMascotaAsync();
			Amos = await _amoService.GetAmoAsync();
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

        public async Task<bool> AddMascotaAsync(MascotaData newMascota)
        {
			var success = await _mascotaService.SaveMascotaAsync(newMascota) > 0;
            if (success)
            {
                Mascotas = await _mascotaService.GetMascotaAsync();
            }
            return success;
        }

        public async Task<bool> AddAmoAsync(AmoData newAmo)
        {
            var success = await _amoService.SaveAmoAsync(newAmo) > 0;
            if (success)
            {
                Amos = await _amoService.GetAmoAsync();
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
