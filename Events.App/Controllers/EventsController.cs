using Events.BLL.Implementations;
using Events.BLL.Interfaces;
using Events.DAL.DataObject;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.App.Controllers
{
    [Route("/api/events")]
    public class EventsController : Controller
    {
        private IEventBLL _eventBLL;

        public EventsController()
        {
            _eventBLL = EventBLL.GetInstance();
        }

        [HttpGet]
        public IActionResult GetAllEvents()
        {
            try
            {
                return Ok(_eventBLL.GetAllEvents());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetEvent([FromRoute] Guid id)
        {
            try
            {
                var eventResult = _eventBLL.GetEventById(id);
                if (eventResult == null)
                {
                    return NotFound();
                }
                return Ok(eventResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult PostEvent([FromBody] EventDTO eventDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                return Ok(_eventBLL.AddNewEvent(eventDTO));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEvent([FromRoute] Guid id, [FromBody] EventDTO eventDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var currentEvent = _eventBLL.GetEventById(id);
                if (currentEvent == null)
                {
                    return NotFound();
                }

                _eventBLL.UpdateEvent(currentEvent, eventDTO);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent([FromRoute] Guid id)
        {
            try
            {
                var currentEvent = _eventBLL.GetEventById(id);
                if (currentEvent == null)
                {
                    return NotFound();
                }
                _eventBLL.DeleteEvent(currentEvent);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}