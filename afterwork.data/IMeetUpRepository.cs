using System;
using System.Collections.Generic;
using System.Text;
using afterwork.model;

namespace afterwork.data
{
    public interface IMeetUpRepository
    {
        IEnumerable<MeetUp> GetAll();
        MeetUp GetById(int id);
        MeetUp Update(MeetUp uodatedEvent);
        MeetUp Add(MeetUp newEvent);
        MeetUp Delete(int id);
        bool Commit();
    }
}