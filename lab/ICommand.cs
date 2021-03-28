using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    interface ICommand
    {
        public void Execute(CollectionManager cm);
        public string GetInfo();
    }
}
