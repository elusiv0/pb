using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class ExitCommand:ICommand
    {
        public void Execute(CollectionManager cm)
        {
            Console.WriteLine("Завершение работы программы...");
            System.Environment.Exit(0);
        }
        public string GetInfo()
        {
            return "exit - выход из консольного приложения.";
        }
    }
}
