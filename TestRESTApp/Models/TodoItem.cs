﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestRESTApp.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string name { get; set; }
        public bool isComplete { get; set; }
    }
}
