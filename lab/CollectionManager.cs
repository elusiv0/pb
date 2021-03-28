using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab
{
    class CollectionManager
    {
        private Dictionary<int, Person> phoneBook;

        public CollectionManager()
        {
            phoneBook = new Dictionary<int, Person>();
        }
        public List<Person> GetPhoneBook()
        {
            return phoneBook.Values.ToList();
        }

        public void AddPerson(Person p)
        {
            Random rnd = new Random();
            phoneBook.Add(rnd.Next(0, 2281488), p);
            Console.WriteLine("Персона " + p.Surname + " " + p.Name[0] + " " + p.Patronymic[0] + " была добавлена в телефонную книжку");
        }
        public void DeleteFromPhoneBook(int key) {
            if (phoneBook.ContainsKey(key))
            {
                String name = phoneBook[key].Surname + " " + phoneBook[key].Name;
                phoneBook.Remove(key);
                Console.WriteLine("Пользователь " + name + " был удален.");
            }
            else Console.WriteLine("Пользователя с ключом " + key + " не существует.");
       }
       public void EditPerson(int key, string editingProperty, string finalValue)
        {
            switch (editingProperty)
            {
                case "Фамилия":
                    phoneBook[key].Surname = finalValue;
                    Console.WriteLine("Фамилия была изменена на " + finalValue);
                    break;
                case "Имя":
                    phoneBook[key].Name = finalValue;
                    Console.WriteLine("Имя было изменено на " + finalValue);
                    break;
                case "Отчество":
                    phoneBook[key].Patronymic = finalValue;
                    Console.WriteLine("Отчество было изменено на " + finalValue);
                    break;
                case "Номер телефона":
                    try
                    {
                        phoneBook[key].PhoneNumb = Convert.ToInt64(finalValue);
                        Console.WriteLine("Телефон был изменен на " + finalValue);
                    }
                    catch (FormatException ex) { throw new IncorrectArgumentException("Поле телефон должно состоять из цифр.Повторите ввод."); }
                    break;
                case "Страна":
                    phoneBook[key].Country = finalValue;
                    Console.WriteLine("Страна была изменена на " + finalValue);
                    break;
                case "ДР":
                    phoneBook[key].Birthday = Convert.ToDateTime(finalValue);
                    Console.WriteLine("ДР было изменено на " + finalValue);
                    break;
                case "Организация":
                    phoneBook[key].Organization = finalValue;
                    Console.WriteLine("Организация была изменена на " + finalValue);
                    break;
                case "Должность":
                    phoneBook[key].Position = finalValue;
                    Console.WriteLine("Должность была изменена на " + finalValue);
                    break;
                case "Заметки":
                    phoneBook[key].OtherNotes = finalValue;
                    Console.WriteLine("Заметки были изменены на " + finalValue);
                    break;
                default:
                    Console.WriteLine("Поля " + editingProperty + " не существует, введите поле из предложенных без ошибок");
                    break;
            }
        }
        public bool ShowPersons()
        {
            if (phoneBook.Count != 0)
            {
                foreach (int key in phoneBook.Keys)
                {
                    Console.WriteLine(key + ". " + phoneBook[key].Surname + " " + phoneBook[key].Name[0] + " " + phoneBook[key].Patronymic[0]);
               
                }
                return true;
            }
            else
            {
                Console.WriteLine("Телефонная книжка пуста.");
                return false;
            }
        
        }
        public void ShowConcretePerson(int key)
        {
            if (phoneBook.ContainsKey(key))
            {
                Console.WriteLine("Данные по пользователю с ID " + key + ":" + "\n" + phoneBook[key].ToString());
            }
            else throw new IncorrectArgumentException("Пользователя с ID " + key + " не существует. Повторите ввод.");
        }
        public void GetPersonsInfo()
        {
            if (phoneBook.Count != 0)
            {
                string res = "";
                foreach (Person p in phoneBook.Values)
                {
                    res += p.GetInfo();
                }
                Console.WriteLine(res);
            }
            else Console.WriteLine("Телефонная книжка пуста.");
        }
    }
}
