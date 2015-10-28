using System.IO;
using Common;
using LtcService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SettingsManagerTests
    {
        [TestMethod]
        public void SaveAndThenLoadedSettingsAreEquals()
        {
            var settingsManager = new SettingsManager(new EventLogger("LTCtest"), "TestSettings.xml");
            var originalSettings = new Settings
            {
                ActualDay = "Today",
                DayTicksLimit = 600,
                TicksLeft = 500
            };

            settingsManager.SaveSettings(originalSettings);
            var loadedSettings = settingsManager.LoadSettings();

            Assert.AreEqual(originalSettings.ActualDay , loadedSettings.ActualDay);
            Assert.AreEqual(originalSettings.DayTicksLimit , loadedSettings.DayTicksLimit);
            Assert.AreEqual(originalSettings.TicksLeft , loadedSettings.TicksLeft);
        }

        [TestMethod]
        public void LoadSettings_ReadNotExistingFile_ReturnsSettingsWithDefaultValues()
        {
            const string fileName = "NotExistingSettings.xml";
            File.Delete(fileName);
            var settingsManager = new SettingsManager(new EventLogger("LTCtest"), fileName);

            var loadedSettings = settingsManager.LoadSettings();

            Assert.AreEqual(loadedSettings.DayTicksLimit , SettingsManager.DefaultTicks);
            Assert.AreEqual(loadedSettings.TicksLeft , SettingsManager.DefaultTicks);
            Assert.AreEqual(loadedSettings.ActualDay, SettingsManager.DefaultActualDay);
        }

    }
}