using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LtcService
{
    [Serializable]
    public class Settings
    {
        public string ActualDay { get; set; }
        public int DayTicksLimit { get; set; }
        public int TicksLeft { get; set; }

    }
}
