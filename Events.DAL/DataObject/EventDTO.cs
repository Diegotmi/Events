using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Events.DAL.DataObject
{
    public class EventDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public bool IsOpenBar { get; set; } = false;

        [Required]
        public int EnvironmentsAmmount { get; set; } = 1;
    }
}
