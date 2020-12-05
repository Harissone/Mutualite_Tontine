using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tontine.BO
{
    [Serializable]
    public class Event
    {
        public string Identifier { get; set; }
        public string EventName { get; set; }
        public int Contribution { get; set; }
        public string Location { get; set; }
        public int TotalContributions { get; set; }

        public Event()
        {

        }

        public Event(string identifier, string eventName, int contribution, string location, int totalContributions)
        {
            Identifier = identifier;
            EventName = eventName;
            Contribution = contribution;
            Location = location;
            TotalContributions = totalContributions;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Identifier == @event.Identifier;
        }

        public override int GetHashCode()
        {
            return 1186239758 + EqualityComparer<string>.Default.GetHashCode(Identifier);
        }
    }
}
