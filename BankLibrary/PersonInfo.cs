using BankLibrary.Bankomat;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public static class PersonInfo
    {
        public static string GetPersonInfo(Person person)
        {
            return $"Имя: {person.FirstName}, Фамилия: {person.LastName}, Возраст: {person.Age}";
        }
    }
}
