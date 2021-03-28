using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public long PhoneNumb { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string OtherNotes { get; set; }

        public Person(string surname, string name, string patronymic, long phoneNumb, string country, DateTime birthday, string organization, string position, string otherNotes)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = (patronymic == "") ? "Не указано." : patronymic;
            this.PhoneNumb = phoneNumb;
            this.Country = country;
            this.Birthday = birthday;
            this.Organization = (organization == "") ? "Не указано" : organization;
            this.Position = (position == "") ? "Не указано" : position;
            this.OtherNotes = (otherNotes == "") ? "Не указано" : otherNotes;

        }
     
        public string GetPerson()
        {
            return Surname + " " + Name[0] + " " + Patronymic[0];
        }
        public override string ToString()
        {
            return "Фамилия: " + Surname + "\n" + "Имя: " + Name + "\n" + "Отчество: " + Patronymic + "\n" + "Страна: " + Country + "\n" 
                + "ДР: " + (Birthday == DateTime.MinValue?"Не указано":Birthday.ToShortDateString()) + "\n" + "Организация: "
                + Organization + "\n" + "Должность: " + Position + "\n" + "Заметки: " + OtherNotes + "\n" + "Номер телефона: " + PhoneNumb; 
        }
        public string GetInfo()
        {
            return "Фамилия: " + Surname + "\n" + "Имя: " + Name + "\n" + "Номер телефона: " + PhoneNumb + "\n" + "\n";
        }
    }
}
