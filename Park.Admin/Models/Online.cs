using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Park.Admin.Models
{
    public class Online : IKeyID
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "IP地址")]
        [StringLength(50)]
        public string IPAdddress { get; set; }

        [Display(Name = "登录时间")]
        public DateTime LoginTime { get; set; }

        [Display(Name = "最后操作时间")]
        public DateTime? UpdateTime { get; set; }

        [Required]
        [Display(Name = "用户")]
        public int UserID { get; set; }

        public User User { get; set; }
    }
}