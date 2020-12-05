using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;

namespace Tontine.DAL
{
    public class MeetingDAO
    {
        private static List<Meeting> meetings;
        private const string File_name = @"Projet_Tontine/Data/meeting.json";
        private FileInfo file;
        public MeetingDAO()
        {
            file = new FileInfo(File_name);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    meetings = JsonConvert.DeserializeObject<List<Meeting>>(json);
                }
            }
            if (meetings == null)
            {
                meetings = new List<Meeting>();
            }
        }

        public void Set(Meeting oldMeeting, Meeting newMeeting)
        {
            var oldIndex = meetings.IndexOf(oldMeeting);
            var newIndex = meetings.IndexOf(newMeeting);
            if (oldIndex < 0)
                throw new KeyNotFoundException("This meeting doesn't exists !");
            if (newIndex > 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This meeting's identifier already exists !");
            meetings[oldIndex] = newMeeting;
            Save();
        }

        public void Add(Meeting meeting)
        {
            meetings.Add(meeting);
            Save();
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(meetings);
                sw.WriteLine(json);
            }
        }

        public void Delete(Meeting meeting)
        {
            meetings.Remove(meeting); /*base sur le aquals de son BO*/
            Save();
        }

        public IEnumerable<Meeting> Find()
        {
            return new List<Meeting>(meetings);
        }


        public IEnumerable<Meeting> Find(Func<Meeting, bool> predicate)
        {
            return new List<Meeting>(meetings.Where(predicate).ToArray());
        }
    }
}
