using System;
using System.Collections.Generic;
using System.Text;
using afterwork.model;

namespace afterwork.data
{
    public interface IEventData
    {
        IEnumerable<Event> GetALL();
    }
}
