using System;
using System.Collections.Generic;
using System.Text;

namespace CreateStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager p = new Manager("Tony", "Allen", 32, Person.Genders.Male, "8999948343", "Kuznetcova 3A");
            Console.WriteLine(p.ToString());
      Console.ReadLine();
    }

        class Person
        {
            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;

            public Person(string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }

            public override string ToString()
            {
                return firstName + " " + lastName + " (" + gender + "), age " + age;
            }

            public enum Genders : int { Male, Female };
        }
    class Manager : Person
    {
      public 
       string phoneNumber;
       string officeLocation;
      public Manager(string _firstName, string _lastName, int _age, Genders _gender, string _phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)
      {
        phoneNumber = _phoneNumber; officeLocation =_officeLocation;
      }
      public override string ToString()
      {
        return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
      }
    }
  }
}
