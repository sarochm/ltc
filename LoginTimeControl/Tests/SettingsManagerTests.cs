using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                TodayRemainsMinutes = 500,
                DayOfWeekLimits = new int[] { 10,11,12,13,14,15,16},
                AllowIntervals = new List<Interval>() { new Interval() { Days = new HashSet<DayOfWeek>() { DayOfWeek.Friday, DayOfWeek.Monday},TimeFrom = new TimeSpan(1,0,0),TimeTo = new TimeSpan(3,55,0)} }
            };

            settingsManager.SaveSettings(originalSettings);
            var loadedSettings = settingsManager.LoadSettings();

            Assert.AreEqual(originalSettings.ActualDay , loadedSettings.ActualDay);
            Assert.AreEqual(originalSettings.TodayRemainsMinutes , loadedSettings.TodayRemainsMinutes);
            Assert.IsTrue(originalSettings.DayOfWeekLimits.SequenceEqual(loadedSettings.DayOfWeekLimits));
            Assert.IsTrue(loadedSettings.AllowIntervals.Count == 1);
        }

        [TestMethod]
        public void LoadSettings_ReadNotExistingFile_ReturnsSettingsWithDefaultValues()
        {
            const string fileName = "NotExistingSettings.xml";
            File.Delete(fileName);
            var settingsManager = new SettingsManager(new EventLogger("LTCtest"), fileName);

            var loadedSettings = settingsManager.LoadSettings();

            Assert.AreEqual(loadedSettings.DayOfWeekLimits[0] , SettingsManager.DefaultTicks);
            Assert.AreEqual(loadedSettings.TodayRemainsMinutes , SettingsManager.DefaultTicks);
            Assert.AreEqual(loadedSettings.ActualDay, SettingsManager.DefaultActualDay);
            Assert.AreEqual(loadedSettings.AllowIntervals.Count,1);
            Assert.AreEqual(loadedSettings.AllowIntervals.First().Days.Count, 7);
        }
    }
}