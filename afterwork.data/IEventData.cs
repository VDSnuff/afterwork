using System;
using System.Collections.Generic;
using System.Text;
using afterwork.model;
using System.Linq;

namespace afterwork.data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Update(TEntity uodatedEvent);
        TEntity Add(TEntity newEvent);
        TEntity Delete(int id);
        bool Commit();
    }

    //Extract into the new file

    public class Repositor<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public Repositor(AfterWorkDbContext _ctx)
        {
            this._ctx = _ctx;
        }

        private readonly AfterWorkDbContext _ctx;

        public TEntity Add(TEntity newEvent)
        {
            _ctx.Add(newEvent);
            return newEvent;
        }

        public bool Commit()
        {
            return _ctx.SaveChanges() > 0;
        }

        public TEntity GetById(int id)
        {
            return _ctx.Set<TEntity>().Find(id);
        }
        public TEntity Delete(int id)
        {
            var deletedEvent = GetById(id);
            if (deletedEvent != null)
            {
                _ctx.Set<TEntity>().Remove(deletedEvent);
            }
            return deletedEvent;
        }

        public IEnumerable<TEntity> GetAll()
        {
            var eventList = _ctx.Set<TEntity>().ToList<TEntity>(); // Or use Where...
            return eventList;
        }

        public TEntity Update(TEntity updatedEvent)
        {
            var entyti = _ctx.Set<TEntity>().Attach(updatedEvent);
            entyti.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedEvent;
        }
    }




    // public class EventRepository : IRepository //Chenge SqlEventData EventDataRepository
    // {
    //     public EventRepository(AfterWorkDbContext _ctx)
    //     {
    //         this._ctx = _ctx;
    //     }

    //     private readonly AfterWorkDbContext _ctx;

    //     public Event Add(Event newEvent)
    //     {
    //         _ctx.Add(newEvent);
    //         return newEvent;
    //     }

    //     public int Commit()
    //     {
    //         return _ctx.SaveChanges();
    //     }

    //     public Event GetById(int id)
    //     {
    //         return _ctx.Events.Find(id);
    //     }
    //     public Event Delete(int id)
    //     {
    //         var deletedEvent = GetById(id);
    //         if(deletedEvent != null)
    //         {
    //             _ctx.Events.Remove(deletedEvent);
    //         }
    //         return deletedEvent;
    //     }

    //     public IEnumerable<Event> GetAll()
    //     {
    //         var eventList = _ctx.Events.ToList(); // Or use Where...
    //         return  eventList;
    //     }

    //     public Event Update(Event updatedEvent)
    //     {
    //         var entyti = _ctx.Events.Attach(updatedEvent);
    //         entyti.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //         return updatedEvent;
    //     }
    // }
}