﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.App.Models
{
    internal class Customer
    {
        public class Admin
        {
            [Key]
            public int id { get; set; }
            [Required]
            public string nama { get; set; }
            [Required]
            public string email { get; set; }
            [Required]
            public string password { get; set; }
        }
    }
}
