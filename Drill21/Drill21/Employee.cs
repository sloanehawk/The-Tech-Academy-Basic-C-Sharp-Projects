﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill21
{
    public class Employee<T> : Person
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }

    }
}
