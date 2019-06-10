using System;
using System.Collections.Generic;
using System.Text;

namespace afterwork.model
{
   public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
