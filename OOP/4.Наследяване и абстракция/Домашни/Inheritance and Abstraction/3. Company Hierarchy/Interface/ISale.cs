﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Company_Hierarchy.Interface
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
