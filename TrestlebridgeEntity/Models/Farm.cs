﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrestlebridgeEntity.Models
{
    public class Farm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string RegisteredName { get; set; }

        public double Acres { get; set; }

        public virtual ICollection<Facility> Facilities { get; set; }

        public ApplicationUser User { get; set; }
    }
}
