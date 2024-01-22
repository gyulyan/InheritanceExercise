using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (value != null && value.Length >= 3)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot fewer than 3 symbols!");
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (value != null && value.Length >= 3)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value != null && value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {

                this.salary = value;

            }
        }

        public void IncreaseSalary(decimal percentige)
        {
            if (this.Age >= 30)
            {
                this.Salary += Salary * percentige / 100;
            }
            else
            {
                this.Salary += Salary * percentige / 200;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
