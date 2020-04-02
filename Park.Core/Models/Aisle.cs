﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Park.Core.Models
{
    public class Aisle : IParkObject
    {
        public double X1 { get; set; }
        public double Y1 { get; set; } 
        public double X2 { get; set; }
        public double Y2 { get; set; }
        [Key]
        public int ID { get; set; }
        [Display(Name = "分类")]
        [StringLength(50)]
        [Required]
        public string Class { get; set; } = "";
    }
}
