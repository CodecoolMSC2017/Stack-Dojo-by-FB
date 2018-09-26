using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Dojo
{
    public class StackUnderflowException : Exception
    {
        public StackUnderflowException()
        {
        }

        public StackUnderflowException(string message)
            : base(message)
        {
        }
    }
}
