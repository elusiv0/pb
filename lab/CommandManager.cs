using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace lab
{
    
    class CommandManager
    {
        private static Dictionary<string, ICommand> commands;
        public CollectionManager CM;
            
        public CommandManager()
        {
            CM = new CollectionManager();
            commands = new Dictionary<string, ICommand>
            {
                { "add", new AddCommand() },
                { "edit", new EditCommand() },
                { "show", new ShowCommand() },
                { "show_short_info", new ShowShortInfoCommand() },
                { "exit", new ExitCommand() },
                { "help", new HelpCommand() }
            };
        }
        public static void GetCommands()
        {
            foreach(ICommand command in commands.Values)
            {
                Console.WriteLine(command.GetInfo());
            }
        }
        public void ExecuteCommand(string command)
        {
            if (commands.ContainsKey(command))
            {
                commands[command].Execute(CM);
            }
            else throw new IncorrectCommandException("Такой команды не существует");
        }
    }
}
