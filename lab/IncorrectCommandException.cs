using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class IncorrectCommandException:Exception
    {
        public IncorrectCommandException(string message) : base(message)
        {

        }
    }
}
