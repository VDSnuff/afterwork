using afterwork.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace afterwork.data
{
    //Extract into the new file

    public class MeetUpRepository : IMeetUpRepository
    {
        public MeetUpRepository(AfterWorkDbContext ctx, ILogger<MeetUpRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }

        protected internal readonly AfterWorkDbContext ctx;
        protected internal readonly ILogger<MeetUpRepository> logger;

        public MeetUp Add(MeetUp newEvent)
        {
            ctx.Add(newEvent);
            return newEvent;
        }

        public bool Commit()
        {
            return ctx.SaveChanges() > 0;
        }

        public MeetUp GetById(int id)
        {
            return ctx.MeetUps.Find(id);
        }
        public MeetUp Delete(int id)
        {
            var deletedMeetUps = GetById(id);
            if (deletedMeetUps != null)
            {
                ctx.MeetUps.Remove(deletedMeetUps);
            }
            return deletedMeetUps;
        }

        public IEnumerable<MeetUp> GetAll()
        {
            return ctx.MeetUps.Include(u => u.Creator).Include(a => a.MeetUpAdministrator)
                              .Include(p => p.MeetUpPartisipant).Include(i => i.MeetUpImage)
                              .Include(p => p.PropositionForMeetUpDateTime).Include(g => g.GatheringSpot)
                              .Include(l => l.MeetUpPlace).ToList();
        }

        public MeetUp Update(MeetUp updatedMeetUp)
        {
            var entyti = ctx.MeetUps.Attach(updatedMeetUp);
            entyti.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedMeetUp;
        }
    }
}