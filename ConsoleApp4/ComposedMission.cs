using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    //composed mission function class that implements iMission interface
    class ComposedMission:IMission
    {
        public event EventHandler<double> OnCalculate;
        public String Name { get; private set; }
        public String Type { get; private set; }
        private List<CalcFunction>composedFunctions = new List<CalcFunction>();
        //constructor
        public ComposedMission(String mission)
        {
            Name = mission;
            Type = "Composed";
        }
        //constructor
        public ComposedMission(CalcFunction function, String mission)
        {
            Name = mission;
            Type = "Composed";
            composedFunctions.Add(function);
        }
        //add function to function list
        public ComposedMission Add(CalcFunction function)
        {
            composedFunctions.Add(function);
            return this;
        }
        //calculates the value with given value and by all the functions
        public double Calculate(double value)
        {
            foreach (var func in composedFunctions) 
            {
                value = func(value);
                //raise the event
                OnCalculate?.Invoke(this, value);
            }
            return value;
        }
       
    }
}
