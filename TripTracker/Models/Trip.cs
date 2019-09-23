﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.Model
{
    public class Trip
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
         
        [Required]
        public string Name { get; set; }

        [Required]

        public DateTime StartDate { get; set; }


        [Required]
        public DateTime EndDate { get; set; }
    }
}
