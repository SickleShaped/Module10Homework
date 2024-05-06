using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Homework
{
    public interface ILogger
    {
        void Event(string str);

        void Error(string str);
    }
}
