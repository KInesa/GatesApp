namespace GatesApp.Models
{
    public class Event
    {
        public string NameOfEvent { get; set; }
        public TimeSpan Span { get; set; }
        public int EmployeeId { get; set; }
        public int EventId { get; set; }

        public Event(string nameOfEvent, TimeSpan span, int employeeId, int eventId)
        {
            NameOfEvent = nameOfEvent;
            Span = span;
            EmployeeId = employeeId;
            EventId = eventId;
        }
    }
}
