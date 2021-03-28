using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class AddCommand:ICommand
    {
        public  void Execute(CollectionManager cm)
        { 
            cm.AddPerson(PersonCreator.GetPerson());
            
        }
        public string GetInfo()
        {
            return "add - добавление нового элемента в телефонную книжку";
        }
    }
}
