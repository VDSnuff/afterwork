using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.model
{
    class Event
    {
        public int Id { get; set; }
        public User Creator { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EventImage EventImage { get; set; }
        public EventType EventType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Location GatheringSpot { get; set; }
        public Location EventPlace { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public bool IsPrivate { get; set; }
        public int ParticipantLimit { get; set; }
        public decimal MinimalBudget { get; set; }
        public int Complexity { get; set; }
        public string Rating { get; set; }
    }
}
