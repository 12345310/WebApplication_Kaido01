﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Kaido01.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Memo { get; set; }

    }
}