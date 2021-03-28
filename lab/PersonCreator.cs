using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class PersonCreator
    {
        public static Person GetPerson()
        {
            long number;
            DateTime birthday;
            while (true)
            {
                Console.WriteLine("Введите фамилию ");
                Surname:
                string surname = Console.ReadLine();
                if (surname == "")
                {
                    Console.WriteLine("Поле обязательно для ввода. Повторите ввод.");
                    goto Surname;
                }
                Console.WriteLine("Введите имя ");
                Name:
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Поле обязательно для ввода. Повторите ввод.");
                    goto Name;
                }
                Console.WriteLine("Введите отчество(необязательно, если нет - оставьте пустым");
                string patronymic = Console.ReadLine();
                Console.WriteLine("Введите номер телефона(только цифры)");
            Number:
                try
                {
                    number = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Вы ввели не цифры.Повторите ввод.");
                    goto Number;
                }
                Console.WriteLine("Введите страну");
            Country:
                string country = Console.ReadLine();
                if (country == ""){
                    Console.WriteLine("Поле обязательно для ввода. Повторите ввод."); 
                    goto Country;
                }
                Console.WriteLine("Введите дату рождения(поле необязательно, можно оставить пустым)");
                Date:
                    try
                    {
                        string bir = Console.ReadLine();
                        if (bir == "")
                        {
                        birthday = DateTime.MinValue;
                        goto Next;
                        }
                        birthday = Convert.ToDateTime(bir);
                    }catch (Exception ex)
                    {
                        Console.WriteLine("Вы ввели дату в неправильном формате. Повторите ввод.");
                        goto Date;
                    }
                Next:
                Console.WriteLine("Введите организацию(необязательно)");
                string organization = Console.ReadLine();
                Console.WriteLine("Введите должность(необязательно)");
                string position = Console.ReadLine();
                Console.WriteLine("Можете оставить заметки");
                string otherNotes = Console.ReadLine();
                return new Person(surname, name, patronymic, number, country, birthday, organization, position, otherNotes);
            }
        }
    }
}
