using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class ShowShortInfoCommand:ICommand
    {
        public void Execute(CollectionManager cm)
        {
            cm.GetPersonsInfo();
        }
        public string GetInfo()
        {
            return "show_short_info - команда показывает краткую информацию всех созданных учетных записей";
        }
    }
}
