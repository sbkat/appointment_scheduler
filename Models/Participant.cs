using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace event_scheduler.Models
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public User Attending { get; set; }
    }
}