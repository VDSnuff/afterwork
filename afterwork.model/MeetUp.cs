using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.model
{
    public class MeetUp
    {
        public int MeetUpId { get; set; }
        public User Creator { get; set; }
        public IList<MeetUpAdministrator> MeetUpAdministrator { get; set; }
        public IList<MeetUpPartisipant> MeetUpPartisipant { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MeetUpImage MeetUpImage { get; set; }
        public MeetUpType MeetUpType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IList<PropositionForMeetUpDateTime> PropositionForMeetUpDateTime { get; set; }
        public Location GatheringSpot { get; set; }
        public Location MeetUpPlace { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsConfirmed { get; set; }
        public int ParticipantLimit { get; set; }
        public double MinimalBudget { get; set; }
        public int Complexity { get; set; }
        public string Rating { get; set; }
    }
}