using Common;

namespace LtcService
{
    public class ActualSettings
    {
        private const int DefaultCountSeed = 360;
        private const string LeftCountKey = "LeftCount";
        private const string DefaultCountKey = "DefaultCount";
        private const string ActualDayKey = "ActualDey";

        private readonly SettingsRepository _settingsRepository;

        public ActualSettings()
        {
            _settingsRepository = new SettingsRepository();
        }

        public int DefaultCount
        {
            get
            {
                int value;
                var valueString = _settingsRepository.ReadKey(DefaultCountKey);
                if (int.TryParse(valueString, out value)) return value;
                value = DefaultCountSeed;
                _settingsRepository.AddUpdateKey(DefaultCountKey, value.ToString());
                return value;
            }
        }

        public int LeftCount
        {
            get
            {
                int value;
                var valueString = _settingsRepository.ReadKey(LeftCountKey);
                if (int.TryParse(valueString, out value)) return value;
                value = DefaultCount;
                _settingsRepository.AddUpdateKey(LeftCountKey, value.ToString());
                return value;
            }
            set { _settingsRepository.AddUpdateKey(LeftCountKey, value.ToString()); }
        }

        public string ActualDay
        {
            get { return _settingsRepository.ReadKey(ActualDayKey); }
            set { _settingsRepository.AddUpdateKey(ActualDayKey, value); }
        }

        public void ResetDefaultCount()
        {
            _settingsRepository.AddUpdateKey(DefaultCountKey, DefaultCountSeed.ToString());
        }
    }
}