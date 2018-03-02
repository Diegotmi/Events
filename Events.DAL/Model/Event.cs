using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Events.DAL.Model
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdEvent { get; set; }

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
        public bool IsOpenBar { get; set; }

        [Required]
        public int EnvironmentsAmmount { get; set; }

        [Required]
        [JsonIgnore]
        public int IdAgeRange { get; set; }

        [Required]
        [ForeignKey("IdAgeRange")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AgeRange AgeRange { get; set; }
    }
}
