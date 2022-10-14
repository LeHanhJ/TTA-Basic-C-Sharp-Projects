using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listOfEmployees = new List<Employee>()
            { 
            new Employee() { FirstName = "Joe", LastName = "Johnston", Id= 1},
            new Employee() { FirstName = "Mina", LastName = "Arakaki", Id= 2},
            new Employee() { FirstName = "Eristeo", LastName = "Mohk", Id= 3},
            new Employee() { FirstName = "Pluto", LastName = "Sighn", Id= 4},
            new Employee() { FirstName = "Mastodon", LastName = "Black", Id= 5},
            new Employee() { FirstName = "Logan", LastName = "Garfield", Id= 6},
            new Employee() { FirstName = "Janae", LastName = "Misteria", Id= 7},
            new Employee() { FirstName = "Joe", LastName = "Mahma", Id= 8},
            new Employee() { FirstName = "Nemo", LastName = "Ho", Id= 9},
            new Employee() { FirstName = "Stephanie", LastName = "Locale", Id= 10},
            };

            //creates new list of Joes
            //List<Employee> JoeList = new List<Employee>();


            //try
            //{
            //    //uses a foreach loop to go through list of employees
            //    foreach (Employee employee in listOfEmployees)
            //    {
            //        //and IF the first name is Joe ; using the WHILE loop will loop through UNTIL the name is different from Joe
            //        // ex: WHILE Joe's name is Joe, loop through the list
            //        // in comparison: IF the employee's first name is joe in this list, please add to the JoeList
            //        // IF will run through the loop until the end while WHILE will keep running until the argument is met
            //        if (employee.FirstName == "Joe")
            //        {
            //            //Add the employee from employee to JoeList
            //            JoeList.Add(employee);
            //            //and print out the names
            //            Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //        }
            //    }
            //}

            //Perform as above but with a lambda expression
            List<Employee> JoeList = listOfEmployees.Where(x => x.FirstName == "Joe").ToList();


            //Using a lambda expression, make a list of employees with an ID greater than 5
            List<Employee> IDGreaterThan5 = listOfEmployees.Where(x => x.Id > 5).ToList();
            Console.WriteLine(IDGreaterThan5.Count);
            

            //catch
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            Console.ReadLine();
            
          


        }
    }
}
