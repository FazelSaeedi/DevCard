﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public long id  { get; set; }

        public string Name  { get; set; }

        public string description  { get; set; }

        public string client  { get; set; }
    }
}
