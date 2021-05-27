using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartEventTracker
{
    class ModConfig
    {
        public bool ShowUnavailableEvents { get; set; }
        public bool ShowAvailableEvents { get; set; }
        public bool ShowSeenEvents { get; set; }
        public bool ShowTriggerConditions { get; set; }
        public bool ShowEventDescription { get; set; }



        public ModConfig()
        {
            this.ShowUnavailableEvents = false;
            this.ShowAvailableEvents = true;
            this.ShowSeenEvents = true;
            this.ShowTriggerConditions = true;
            this.ShowEventDescription = false;
        }
    }
}
