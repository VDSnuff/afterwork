using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.model
{
    public class PropositionForMeetUpDateTime
    {
        public int PropositionForMeetUpDateTimeId { get; set; }
        public User PropositionCreator { get; set; }
        public IList<MeetUpDateTimeVoter> MeetUpDateTimeVoter { get; set; }
        public DateTime ProposedDateTime { get; set; }
        public int VoicesCount { get; set; }
        public MeetUp MeetUp { get; set; }
    }
}
