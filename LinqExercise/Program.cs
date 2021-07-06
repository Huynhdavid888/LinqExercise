using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            var avg = numbers.Average();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {avg}");
            //Order numbers in ascending order and decsending order. Print each to console.
            var ascending = numbers.OrderBy(number => number);
            Console.WriteLine("Ascending");
            foreach (var number in ascending)
            {
                Console.WriteLine(ascending);
            }

            var descending = numbers.OrderByDescending(x => x);
            Console.WriteLine("Descending");
            foreach (var x in descending)
            {
                Console.WriteLine(descending);
            }
            //Print to the console only the numbers greater than 6
            var higherThanSix = numbers.Where(num => num > 6);

            Console.WriteLine("higher than six:");
            foreach (var item in higherThanSix)
            {
                Console.WriteLine(item);
            }

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var Four = descending.Take(4);
            Console.WriteLine("first four descending numbers");
            foreach (var num in Four)
            {
                Console.WriteLine(num);
            }
            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 25;
            foreach (var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(item);
            }
            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var filteredNames = employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S')).OrderBy(person => person.FirstName);
            Console.WriteLine("C or S firstname Employees");
            foreach (var employee in filteredNames)
            {
                Console.WriteLine(employee.FullName);
            }
            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var overAgeTwentySix = employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age).ThenBy(employee => employee.FirstName);
            Console.WriteLine("Over age 26");
            foreach (var employee in overAgeTwentySix)
            {
                Console.WriteLine($"FullName: {employee.FullName} and Age: {employee.Age}");
            }
            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var yearsOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var sumYearsOE = yearsOE.Sum(x => x.YearsOfExperience);
            var avgYearsOE = yearsOE.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Sum: {sumYearsOE} and Avg{avgYearsOE}");
            //Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("firstName", "LastName", 45, 20)).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.FullName},{item.Age},{item.YearsOfExperience}");
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
