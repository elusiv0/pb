using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class IncorrectArgumentException:Exception
    {
        public IncorrectArgumentException(string message) : base(message)
        {

        }
    }
}
