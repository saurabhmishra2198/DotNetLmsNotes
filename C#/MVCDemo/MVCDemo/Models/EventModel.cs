namespace MVCDemo.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string? EventType { get; set; }
        public string? EventDescription { get; set; }
        public decimal EventPrice { get; set; }
    }
}
