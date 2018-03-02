using Events.BLL.Helpers;
using Events.BLL.Interfaces;
using Events.DAL.DataBaseRepository.Implementations;
using Events.DAL.DataBaseRepository.Interfaces;
using Events.DAL.DataObject;
using Events.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.BLL.Implementations
{
    public class EventBLL : IEventBLL
    {
        private IEventRepository _eventRepository;
        private static IEventBLL Instance;

        private EventBLL()
        {
            _eventRepository = new EventRepository();
        }

        public static IEventBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EventBLL();
            }
            return Instance;
        }

        public Event AddNewEvent(EventDTO eventDTO)
        {
            var newEvent = NewEvent(eventDTO);
            return _eventRepository.Insert(newEvent);
        }

        public void DeleteEvent(Event currentEvent)
        {
            _eventRepository.Delete(currentEvent);
        }

        public List<Event> GetAllEvents()
        {
            return _eventRepository.GetAll();
        }

        public Event GetEventById(Guid id)
        {
            return _eventRepository.GetOneWithAgeRange(id);
        }

        public void UpdateEvent(Event currentEvent, EventDTO eventDTO)
        {
            var newEvent = NewEvent(eventDTO);
            newEvent.IdEvent = currentEvent.IdEvent;
            _eventRepository.Update(newEvent);
        }

        public Event NewEvent(EventDTO eventDTO)
        {
            var newEvent = new Event();
            newEvent.Name = eventDTO.Name;
            newEvent.Date = eventDTO.Date;
            newEvent.Venue = eventDTO.Venue;
            newEvent.StartTime = eventDTO.StartTime;
            newEvent.EndTime = eventDTO.EndTime;
            newEvent.IsOpenBar = eventDTO.IsOpenBar;
            newEvent.EnvironmentsAmmount = eventDTO.EnvironmentsAmmount;

            if (eventDTO.StartTime.Hour > 10 && eventDTO.EndTime.Hour < 20 && eventDTO.EnvironmentsAmmount > 2)
            {
                newEvent.IdAgeRange = (int)AgeRangeEnum.LT16;
            }
            else if (eventDTO.StartTime.Hour > 20 && eventDTO.EndTime.Hour < 2 && !eventDTO.IsOpenBar)
            {
                newEvent.IdAgeRange = (int)AgeRangeEnum.BT16;
            }
            else
            {
                newEvent.IdAgeRange = (int)AgeRangeEnum.BT18;
            }

            return newEvent;
        }
    }
}
