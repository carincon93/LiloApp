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
		private readonly MuscleGroupService _muscleGroupService;
		private readonly PetService _petService;
		private readonly OwnerService _ownerService;
		private readonly ExerciseService _exerciseService;
		private readonly TrainingSessionService _trainingSessionService;
		private readonly PetLifeService _petLifeService;

        private List<DreamData> _dreams;
		private List<DreamCalendarData> _dreamCalendar;
		private List<MuscleGroupData> _muscleGroups;
		private List<PetData> _pets;
		private List<OwnerData> _owners;
		private List<ExerciseData> _exercises;
		private List<TrainingSessionData> _trainingSessions;
		private List<PetLifeData> _petLife;

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

		public List<MuscleGroupData> MuscleGroups
		{
			get => _muscleGroups;
			set
			{
                _muscleGroups = value;
				OnPropertyChanged();
			}
		}
        public List<PetData> Pets
        {
            get => _pets;
            set
            {
                _pets = value;
                OnPropertyChanged();
            }
        }
        public List<OwnerData> Owners
        {
            get => _owners;
            set
            {
                _owners = value;
                OnPropertyChanged();
            }
        }

		public List<ExerciseData> Exercises
		{
			get => _exercises;
			set
			{
				_exercises = value;
				OnPropertyChanged();
			}
		}

		public List<TrainingSessionData> TrainingSessions
		{
			get => _trainingSessions;
			set
			{
				_trainingSessions = value;
				OnPropertyChanged();
			}
		}

        public List<PetLifeData> PetLife
        {
            get => _petLife;
            set
            {
                _petLife = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(DreamService dreamService, DreamCalendarService dreamCalendarService, MuscleGroupService grupoMuscularService, PetService petService, OwnerService ownerService, ExerciseService exerciseService, TrainingSessionService trainingSessionService, PetLifeService petLifeService)
		{
			_dreamService = dreamService;
			_dreamCalendarService = dreamCalendarService;
			_muscleGroupService = grupoMuscularService;
			_petService = petService;
			_ownerService = ownerService;
			_exerciseService = exerciseService;
			_trainingSessionService = trainingSessionService;
			_petLifeService = petLifeService;

            LoadDataAsync().ConfigureAwait(false);
		}

		public async Task LoadDataAsync()
		{
			Dreams = await _dreamService.GetDreamsAsync();
			DreamCalendar = await _dreamCalendarService.GetDreamCalendarAsync();
			MuscleGroups = await _muscleGroupService.GetMuscleGroupAsync();
			Pets = await _petService.GetPetAsync();
			Owners = await _ownerService.GetOwnerAsync();
			Exercises = await _exerciseService.GetExerciseAsync();
			TrainingSessions = await _trainingSessionService.GetTrainingSessionAsync();
			PetLife = await _petLifeService.GetPetLifeAsync();
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

        public async Task<bool> DeleteDreamAsync(DreamData dreamData)
        {
            var success = await _dreamService.DeleteDreamAsync(dreamData) > 0;
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

		public async Task<bool> AddMuscleGroupAsync(MuscleGroupData newMuscleGroup)
		{
			var success = await _muscleGroupService.SaveMuscleGroupAsync(newMuscleGroup) > 0;
			if (success)
			{
				MuscleGroups = await _muscleGroupService.GetMuscleGroupAsync();
			}
			return success;
		}

		public async Task<bool> AddExerciseAsync(ExerciseData newExercise)
		{
			var success = await _exerciseService.SaveExerciseAsync(newExercise) > 0;
			if (success)
			{
				Exercises = await _exerciseService.GetExerciseAsync();
			}
			return success;
		}

		public async Task<bool> DeleteExerciseAsync(ExerciseData exerciseData)
		{
			var success = await _exerciseService.DeleteExerciseAsync(exerciseData) > 0;
			if (success)
			{
				Exercises = await _exerciseService.GetExerciseAsync();
			}
			return success;
		}

		public async Task<bool> AddTrainingSessionAsync(TrainingSessionData newTrainingSession)
		{
			var success = await _trainingSessionService.SaveTrainingSessionAsync(newTrainingSession) > 0;
			if (success)
			{
				TrainingSessions = await _trainingSessionService.GetTrainingSessionAsync();
			}
			return success;
		}

		public async Task<bool> AddPetAsync(PetData newPet)
        {
			var success = await _petService.SavePetAsync(newPet) > 0;
            if (success)
            {
                Pets = await _petService.GetPetAsync();
            }
            return success;
        }

        public async Task<bool> AddOwnerAsync(OwnerData newOwner)
        {
            var success = await _ownerService.SaveOwnerAsync(newOwner) > 0;
            if (success)
            {
                Owners = await _ownerService.GetOwnerAsync();
            }
            return success;
        }

        public async Task<bool> AddPetLifeAsync(PetLifeData newPetLife)
        {
            var success = await _petLifeService.SavePetLifeAsync(newPetLife) > 0;
            if (success)
            {
                PetLife = await _petLifeService.GetPetLifeAsync();
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
