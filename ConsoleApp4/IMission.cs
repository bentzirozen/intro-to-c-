﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    interface IMission
    {
        event EventHandler<double> OnCalculate;
        String Name { get; }
        String Type { get; }
        double Calculate(double value);
    }
}
