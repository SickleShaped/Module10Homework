using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Homework
{
    public class Calculator:ISum
    {
        ILogger Logger { get; set; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public int Sum(int a, int b)
        {
            int c=0;
            try
            {
                Logger.Event("Все супер!");
                c =  a + b;
            }
            catch
            {
                Logger.Error("Произошла ошибка");
            }

            return c;
            
        }
    }
}
