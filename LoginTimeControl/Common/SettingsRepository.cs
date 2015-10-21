using System.Configuration;

namespace Common
{
    public class SettingsRepository
    {
        public string ReadKey(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings[key];
        }

        public void AddUpdateKey(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}