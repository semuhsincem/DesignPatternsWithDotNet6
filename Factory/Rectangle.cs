﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Rectangle : IShape
    {
        public string Draw()
        {
           return "Inside Rectangle :: Draw();";
        }
    }
}
