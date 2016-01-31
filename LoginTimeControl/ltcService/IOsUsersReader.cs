using System.Collections.Generic;

namespace LtcService
{
    public interface IOsUsersReader
    {
        List<string> GetAdmins();
    }
}