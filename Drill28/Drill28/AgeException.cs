﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill28
{
    public class AgeException : Exception
    {
        public AgeException()
            :base() { }
        public AgeException(string Message)
            : base(Message) { }
    }
}
