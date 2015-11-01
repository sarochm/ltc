using System;
namespace Common
{
    public interface ISettingsManager
    {
        Settings LoadSettings();
        bool SaveSettings(Settings settings);
    }
}
