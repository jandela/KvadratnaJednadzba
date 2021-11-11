using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    public class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException()
        {

        }
        public NotRealRootsException(string message) : base(message)
        {
        }

    }
}
