using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tontine.BO;
using Tontine.DAL;

namespace Tontine.BLL
{
    public class EventBLO
    {
        EventDAO eventRepo;
        public EventBLO()
        {
            eventRepo = new EventDAO();
        }
        public void CreateEvent(Event eventt)
        {
            eventRepo.Add(eventt);
        }
        public void DeleteEvent(Event eventt)
        {
            eventRepo.Delete(eventt);
        }
        public IEnumerable<Event> GetAllEvents()
        {
            return eventRepo.Find();
        }
        public IEnumerable<Event> GetByIdentifier(string identifier)
        {
            return eventRepo.Find(x => x.Identifier == identifier);
        }
        public IEnumerable<Event> GetBy(Func<Event, bool> predicate)
        {
            return eventRepo.Find(predicate);
        }
        public void EditEvent(Event oldEvent, Event newEvent)
        {
            eventRepo.Set(oldEvent, newEvent);
        }
    }
}
