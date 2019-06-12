namespace afterwork.model
{
    public class MeetUpDateTimeVoter
    {
        public int MeetUpDateTimeVoterId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PropositionForMeetUptDateTimeId { get; set; }
        public PropositionForMeetUpDateTime PropositionForMeetUpDateTime { get; set; }
    }
}