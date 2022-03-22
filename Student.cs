using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5CS
{
    public class Student
    {
        private string studentName;
        private int studentAge;
        private string studentAddress;

        public Student() //default constructor
        {
            this.studentName = null;
            this.studentAge = 0;
            this.studentAddress = null;
        }
        public Student(string name, int age, string address)
        {
            studentName = name;
            studentAge = age;
            studentAddress = address;
        }
        public string DisplayStudentInformation()
        {
            return "Name: " + studentName + " \nAge: " + studentAge + "\nAddress: " + studentAddress;
        }

        public string GetStudentName()
        {
            return this.studentName;
        }
        public int GetStudentAge()
        {
            return this.studentAge;
        }
        public string GetStudentAddress()
        {
            return this.studentAddress;
        }     
        
        public void EditStudentInformation(string name, int age, string address)
        {
            if (String.IsNullOrEmpty(name) || name == this.studentName)
            {
                Console.WriteLine("Name information will not be changed.");
            }
            else
            {
                this.studentName = name;
            }
            if (age == 0) //if entered age is 0 or if no input (also sends 0 to method) then no change
            {
                Console.WriteLine("Age information will not be changed.");
            }
            else
            {
                this.studentAge = age;
            }
            if (String.IsNullOrEmpty(address) || address == this.studentAddress)
            {
                Console.WriteLine("Address information will not be changed");
            }
            else
            {
                this.studentAddress = address;
            }
        }
    }
}
