using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lad3._3
{
    public class Employee
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string address { get; set; }
        long sin { get; set; }
        double salary { get; set; }
       
        public Employee() { }
        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }


        public override string ToString()
        {
            return "first name: {0}" + firstName + ",last name: {1}" + lastName + ",address: {2}" + address + ", sin: {3}" + sin + ",salary: {4}" + salary;
        }
        public void CaculateBonus(float precentage)
        {
            Console.WriteLine("the bonus:{0}", salary * precentage/100);
        }

    }
}
