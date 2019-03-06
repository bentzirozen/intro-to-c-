﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class ComposedMission:IMission
    {
        public event EventHandler<double> OnCalculate;
        public String Name { get; }
        public String Type { get; }
        private List<CalcFunction>composedFunctions = new List<CalcFunction>();
        public ComposedMission(String mission)
        {
            Name = mission;
            Type = "Composed";
        }
        public ComposedMission(CalcFunction function, String mission)
        {
            Name = mission;
            Type = "Composed";
            composedFunctions.Add(function);
        }
        public ComposedMission Add(CalcFunction function)
        {
            composedFunctions.Add(function);
            return this;
        }
        public double Calculate(double value)
        {
            foreach (var func in composedFunctions) value = func(value);
            {
                OnCalculate?.Invoke(this, value);
            }
            return value;
        }
       
    }
}