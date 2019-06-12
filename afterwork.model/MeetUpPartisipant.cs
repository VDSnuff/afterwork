namespace afterwork.model
{
    public class MeetUpPartisipant
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int MeetUpId { get; set; }
        public MeetUp MeetUp { get; set; }
    }
}