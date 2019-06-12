namespace afterwork.model
{
    public class MeetUpAdministrator
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int MeetUpId { get; set; }
        public MeetUp MeetUp { get; set; }
    }
}