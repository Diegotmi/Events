using Events.DAL.DataBase;
using Events.DAL.DataBaseRepository.Interfaces;
using Events.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events.DAL.DataBaseRepository.Implementations
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public Event GetOneWithAgeRange(Guid id)
        {
            using (var db = new DataContext())
            {
                return db.Set<Event>()
                    .Include(x => x.AgeRange)
                    .FirstOrDefault(x => x.IdEvent == id);
            }
        }
    }
}
