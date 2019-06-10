using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.model
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Participants { get; set; }
    }
}
