using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.model
{
    public class PropositionForEventDateTime
    {
        public int PropositionForEventDateTimeId { get; set; }
        public User PropositionCreator { get; set; }
        public IList<EventDateTimeVoter> EventDateTimeVoter { get; set; }
        public DateTime ProposedDateTime { get; set; }
        public int VoicesCount { get; set; }
        public Event Event { get; set; }
    }
}
