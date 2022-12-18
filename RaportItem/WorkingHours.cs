using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatesApp.RaportItem
{
    public class WorkingHours
    {
        public string? Name { get; set; }
        public TimeSpan WorkTime { get; set; }
        public TimeSpan TimeSpentSmoking { get; set; }
        public TimeSpan TimeSpentLunch { get; set; }
        public TimeSpan TimeSpentToilet { get; set; }
    }
}
