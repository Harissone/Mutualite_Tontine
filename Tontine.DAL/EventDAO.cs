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
    public class EventDAO
    {
        private static List<Event> events;
        private const string File_name = @"Projet_Tontine/Data/eventt.json";
        private FileInfo file;
        public EventDAO()
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
                    events = JsonConvert.DeserializeObject<List<Event>>(json);
                }
            }
            if (events == null)
            {
                events = new List<Event>();
            }
        }

        public void Set(Event oldEvent, Event newEvent)
        {
            var oldIndex = events.IndexOf(oldEvent);
            var newIndex = events.IndexOf(newEvent);
            if (oldIndex < 0)
                throw new KeyNotFoundException("This event doesn't exists !");
            if (newIndex > 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This event's identifier already exists !");
            events[oldIndex] = newEvent;
            Save();
        }

        public void Add(Event eventt)
        {
            events.Add(eventt);
        }
        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(events);
                sw.WriteLine(json);
            }
        }

        public void Delete(Event eventt)
        {
            events.Remove(eventt); /*base sur le aquals de son BO*/
            Save();
        }

        public IEnumerable<Event> Find()
        {
            return new List<Event>(events);
        }


        public IEnumerable<Event> Find(Func<Event, bool>predicate)
        {
            return new List<Event>(events.Where(predicate).ToArray());
        }
    }
}
