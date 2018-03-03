using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Events.DAL.Model
{
    public class Participant
    {

        [Required]
        public Guid IdEvent { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdParticipant { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [ForeignKey("IdEvent")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Event Event { get; set; }

    }
}