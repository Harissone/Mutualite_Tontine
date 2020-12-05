using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;
using Tontine.DAL;

namespace Tontine.BLL
{
    public class MeetingBLO
    {
        MeetingDAO meetingRepo;
        public MeetingBLO()
        {
            meetingRepo = new MeetingDAO();
        }
        public void CreateMeeting(Meeting meeting)
        {
            meetingRepo.Add(meeting);
        }
        public void DeleteMeeting(Meeting meeting)
        {
            meetingRepo.Delete(meeting);
        }
        public IEnumerable<Meeting> GetAllMeetings()
        {
            return meetingRepo.Find();
        }
        public IEnumerable<Meeting> GetByIdentifier(string identifier)
        {
            return meetingRepo.Find(x => x.Identifier == identifier);
        }
        public IEnumerable<Meeting> GetBy(Func<Meeting, bool> predicate)
        {
            return meetingRepo.Find(predicate);
        }
        public void EditMeeting(Meeting oldMeeting, Meeting newMeeting)
        {
            meetingRepo.Set(oldMeeting, newMeeting);
        }
    }
}
