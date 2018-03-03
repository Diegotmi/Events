using System;
using System.ComponentModel.DataAnnotations;

namespace Events.DAL.DataObject
{
    public class ParticipantDTO
    {
        [Required]
        public Guid IdEvent { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}