using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    //single mission class
    class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public String Name { get; private set; }
        public String Type { get; private set; }
        public CalcFunction sfunction;
        public SingleMission(String mission)
        {
            Name = mission;
            Type = "Single";
        }
        public SingleMission(CalcFunction function,String mission)
        {
            sfunction = function;
            Name = mission;
            Type = "Single";
        }
        public double Calculate(double value)
        {
            value = sfunction(value);
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
