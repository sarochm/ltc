using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SettingsRepositoryTests
    {
        private readonly SettingsRepository _settingsRepository = new SettingsRepository();

        [TestMethod]
        public void AddUpdate_AndThenRead_AreTheSame()
        {
            var randomKey = new Random().Next(1000000).ToString();
            var randomValue = new Random().Next(1000000).ToString();

            _settingsRepository.AddUpdateKey(randomKey, randomValue);
            var readValue = _settingsRepository.ReadKey(randomKey);

            Assert.AreEqual(randomValue, readValue);
        }
    }
}