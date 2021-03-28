using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class ShowCommand:ICommand
    {
        public void Execute(CollectionManager cm)
        {
            if (cm.ShowPersons())
            {
                Console.WriteLine("Данные кого вы бы хотели посмотреть? Введите цифры перед именем выбранного.");
            ID:
                try
                {
                    cm.ShowConcretePerson(Convert.ToInt32(Console.ReadLine()));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Вы ввели не цифры");
                    goto ID;
                }
                catch (IncorrectArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto ID;
                }
            }
        }
        public string GetInfo()
        {
            return "show - просмотр конкретной созданной учетной записи";
        }
    }
}
