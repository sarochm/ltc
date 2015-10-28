using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LtcService
{
    public class Evaluator
    {
        const int TicksAfterRise = 3;
        private ActualSettings _actualSettings;

        public Evaluator()
        {
            _actualSettings = new ActualSettings();
        }

        public bool Tick()
        {
            var today = GetTodayDatum();
            if (_actualSettings.ActualDay != today)
            {
                _actualSettings.ActualDay = today;
                _actualSettings.LeftCount = _actualSettings.DefaultCount;
            };

            var left = _actualSettings.LeftCount;
            left--;
            if (left <= 0)
            {
                _actualSettings.LeftCount = TicksAfterRise;
                return true;
            }
            _actualSettings.LeftCount = left;
            return false;
        }

        private static string GetTodayDatum()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
