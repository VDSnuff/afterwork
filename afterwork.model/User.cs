using System;
using System.Collections.Generic;

namespace afterwork.model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public IList<EventAdministrator> EventAdministrator { get; set; }
        public IList<EventPartisipant> EventPartisipant { get; set; }
    }
}
