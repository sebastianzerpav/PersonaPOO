using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaPOO_SebasZerpa
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int yearBirth { get; set; }

        public Person(string FIRST_NAME, string LAST_NAME, int YEAR_BIRTH)
        {
            firstName = FIRST_NAME;
            lastName = LAST_NAME;
            yearBirth = YEAR_BIRTH;
        }

        public string showPersonInfo()
        {
            return $"El primer nombre de la persona es: {firstName} \n " +
                $"El primer apellido de la persona es: {lastName} \n" +
                $"El año de nacimiento de la persona es: {yearBirth} \n ";
        }

        public int CalculateAge()
        {
            int year = 2023;
            int age = (year - yearBirth);
            return age;
                
        }
    }
}
