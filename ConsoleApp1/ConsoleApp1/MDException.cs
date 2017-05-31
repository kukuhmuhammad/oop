using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MDException : Exception //class dr default vs 
    {
        public MDException()
        {

        }
        public MDException(string message) : base(message)
        {

        }

    }
    class OutOfBoundsException : MDException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
