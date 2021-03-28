using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class HelpCommand:ICommand
    {
        public void Execute(CollectionManager cm)
        {
            CommandManager.GetCommands();
        }
        public string GetInfo()
        {
            return "help - вывод всех комманд и их предназначение.";
        }
    }
}
