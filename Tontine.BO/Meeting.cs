using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tontine.BO
{
    [Serializable]
    public class Meeting
    {
        public string Identifier { get; set; }
        public string MeetingName { get; set; }
        public string MinimumContribution { get; set; }
        public string NumberOfMembers { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Meeting()
        {

        }

        public Meeting(string identifier, string meetingName, string minimumContribution, string numberOfMembers, DateTime date, string description)
        {
            Identifier = identifier;
            MeetingName = meetingName;
            MinimumContribution = minimumContribution;
            NumberOfMembers = numberOfMembers;
            Date = date;
            Description = description;
        }

        public override bool Equals(object obj)
        {
            return obj is Meeting meeting &&
                   Identifier == meeting.Identifier;
        }

        public override int GetHashCode()
        {
            return 1186239758 + EqualityComparer<string>.Default.GetHashCode(Identifier);
        }
    }
}
