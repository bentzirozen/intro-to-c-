using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    //single mission class that implements iMission interface
    class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public String Name { get; private set; }
        public String Type { get; private set; }
        public CalcFunction sfunction;
        //constructor
        public SingleMission(String mission)
        {
            Name = mission;
            Type = "Single";
        }
        //constructor
        public SingleMission(CalcFunction function,String mission)
        {
            sfunction = function;
            Name = mission;
            Type = "Single";
        }
        //calculates the value with given value and by the function
        public double Calculate(double value)
        {
            value = sfunction(value);
            //raise the event
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
