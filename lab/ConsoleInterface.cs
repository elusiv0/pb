using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class ConsoleInterface
    {
        CommandManager CM;
        public ConsoleInterface()
        {
            CM = new CommandManager();
            Console.WriteLine("Здравствуйте! Введите команду из предложенных для работы с телефонной книжкой: ");
            CommandManager.GetCommands();
        }
        public void Start()
        {
            while (true)
            {
                try
                {
                    CM.ExecuteCommand(Console.ReadLine());
                }catch (IncorrectCommandException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Введите одну из предложенных: " );
                    CommandManager.GetCommands();
                }
            }
        }
    }
}
