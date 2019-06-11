namespace afterwork.model
{
    public class EventDateTimeVoter
    {
        public int EventDateTimeVoterId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PropositionForEventDateTimeId { get; set; }
        public PropositionForEventDateTime PropositionForEventDateTime { get; set; }
    }
}