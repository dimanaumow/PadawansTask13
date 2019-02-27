using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string surname;

        private int age;

        public Employee()
        {
                    
        }

        public Employee(string surname, int age)
        { 
            this.age = age;

            this.SetSurname(surname); 
        }

        public void SetSurname(string surname)
        {
            if(surname == null)
            {
                throw new ArgumentNullException(); 
            }

            this.surname = surname; 
        }

        private string GetAge() => this.age.ToString(); 

        public string Info()
        {
            return "Surname: " + this.surname + ", Age: " + this.age; 
        }
    }
}
