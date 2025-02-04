﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Park.Admin.Models
{
    public class Log : IKeyID
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20)]
        public string Level { get; set; }

        [StringLength(200)]
        public string Logger { get; set; }

        [StringLength(4000)]
        public string Message { get; set; }

        [StringLength(4000)]
        public string Exception { get; set; }

        public DateTime LogTime { get; set; }

    }
}