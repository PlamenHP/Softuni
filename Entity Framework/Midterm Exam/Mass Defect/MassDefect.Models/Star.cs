﻿
namespace MassDefect.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Star
    {
        public Star()
        {
            Planets = new HashSet<Planet>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int SolarSystemId { get; set; }
        public virtual SolarSystem SolarSystem { get; set; }

        public virtual ICollection<Planet> Planets { get; set; }
    }
}
