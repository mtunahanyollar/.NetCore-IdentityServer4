﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityBased.Client1.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public int Email{ get; set; }
        public string Password{ get; set; }
    }
}