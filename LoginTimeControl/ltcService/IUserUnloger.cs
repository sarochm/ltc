using System.Collections.Generic;

namespace LtcService
{
    public interface IUserUnloger
    {
        void LogOffAll();
        List<string> GetLogedUsers();
    }
}