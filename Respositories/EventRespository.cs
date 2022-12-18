using GatesApp.Models;

namespace GatesApp.Respositories
{
    public class EventRespository
    {
        private List<Event> events = new List<Event>();

        public void EventRepository()
        {
            events.Add(new Event("Lunch Break", new TimeSpan(01, 00, 00), 1, 1));
            events.Add(new Event("Smoke Break", new TimeSpan(00, 15, 00), 1, 2));
            events.Add(new Event("Toilet Break", new TimeSpan(00, 10, 00), 1, 3));
        }

        public List<Event> GetEvent() => events;

        public Event GetEvent(string oneEvent)
        {
            var currentEvent = events.FirstOrDefault(x => x.NameOfEvent == oneEvent);

            return currentEvent;
        }
        public int LunchAmmount()
        {
            var random = new Random();
            int lunchBreakAmmount = random.Next(1, 2);

            return lunchBreakAmmount;
        }
        public int SmokeAmmount()
        {
            var random = new Random();
            int smokeBreakAmmount = random.Next(0, 6);

            return smokeBreakAmmount;
        }
        public int ToiletAmmount()
        {
            var random = new Random();
            int toiletBreakAmmount = random.Next(1, 4);

            return toiletBreakAmmount;
        }

        public IEnumerable<Event> GetEvents()
        {
            return events;
        }

        public TimeSpan GetEventTime(int eventId, IEnumerable<Event> events)
        {
            TimeSpan timeSpanFromEvent = events.FirstOrDefault(x => x.EventId == eventId).Span;

            return timeSpanFromEvent;
        }
    }
}
