using Events.DAL.DataObject;
using Events.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.BLL.Interfaces
{
    public interface IEventBLL
    {
        Event AddNewEvent(EventDTO eventDTO);
        Event GetEventById(Guid id);
        void UpdateEvent(Event currentEvent, EventDTO eventDTO);
        void DeleteEvent(Event currentEvent);
        List<Event> GetAllEvents();
        Event NewEvent(EventDTO eventDTO);
    }
}
