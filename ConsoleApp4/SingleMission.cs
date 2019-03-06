using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        public String Name { get; }
        public String Type { get; }
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
