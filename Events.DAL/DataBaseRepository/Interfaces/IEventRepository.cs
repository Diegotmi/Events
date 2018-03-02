using Events.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.DAL.DataBaseRepository.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
        Event GetOneWithAgeRange(Guid id);
    }
}
