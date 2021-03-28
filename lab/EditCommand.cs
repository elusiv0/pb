using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class EditCommand:ICommand
    {
        public void Execute(CollectionManager cm)
        {
            if (cm.ShowPersons())
            {
                int key;
                Console.WriteLine("Кого из них вы бы хотели изменить? Введите цифру перед именем.");
            Key:
                try
                {
                    key = Convert.ToInt32(Console.ReadLine());
                    cm.ShowConcretePerson(key);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Вы ввели не цифры. Повторите ввод");
                    goto Key;
                }
                catch (IncorrectArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Key;
                }
                while (true)
                {
                    Console.WriteLine("Что бы вы хотели изменить? Введите название поля.");
                    string editingProperty = Console.ReadLine();
                Value:
                    Console.WriteLine("На что бы вы хотели изменить это поле? Введите значение.");
                   
                    try
                    {
                        string finalValue = Console.ReadLine();
                        cm.EditPerson(key, editingProperty, finalValue);
                        Continue:
                        Console.WriteLine("Хотите продолжать изменять? Да/Нет");
                        switch (Console.ReadLine())
                        {
                            case "Да":
                                continue;
                            case "Нет":
                                return;
                            default:
                                Console.WriteLine("Вы ответили некорректно. Повторите.");
                                goto Continue;
                        }
                    }
                    catch (IncorrectArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Value;
                    }catch (FormatException ex)
                    {
                        Console.WriteLine("Вы ввели некорректно. Повторите попытку.");
                        goto Value;
                    }
                    
                }
            }
            
        }
        public string GetInfo()
        {
            return "edit - редактирование элементов телефонной книжки";
        }
    }
}
