using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    //delegate thats gets double and returns double
    delegate double CalcFunction(double val);
    class FunctionsContainer
    {
        //dictionary of functions
        private Dictionary<string, CalcFunction> functions { get; set; }
        //indexer
        public CalcFunction this[string func]
        {
            //if function dont exist create it
            get {
                if (!functions.ContainsKey(func))
                {
                    //if function dont exist create it
                    functions[func] = value => value;
                }
                return functions[func];
            }
            //change exist function
            set { functions[func] = value; }
        }
        //constructor
       public FunctionsContainer()
        {
            functions = new Dictionary<string, CalcFunction>();
        } 
        //return list of all missions names
        public List<string> getAllMissions()
        {
            List<string> missions = new List<string>();
            foreach(var func in functions)
            {
                //add the key of every function (the name)
                missions.Add(func.Key);
            }
            return missions;
        }
    }
}
