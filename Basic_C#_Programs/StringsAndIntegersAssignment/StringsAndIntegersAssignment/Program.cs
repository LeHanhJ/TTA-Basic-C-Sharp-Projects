using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //try part of try/catch
            try
            {
                // 1. Created a list of integers and created a loop to iterate through each index in the list
                List<int> integers = new List<int>() { 39, 82, 43, 54, 90, 23, 14 };
                
                    foreach (int num in integers)
                    {
                        Console.WriteLine("Please pick a number and I will divide the number on my list by yours:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Checking if we can divide this...");
                        // it will divide by the user inputted number...
                        int quotient = num / number;
                        int modulus = num % number;
                        Console.WriteLine(num + " divided by " + number + " equals " + quotient + " with a remainder of " + modulus);
                    }
                // since this is in the "for" loop, it will iterate until it reaches however many indecies the list has
                }

            // catch part of try/catch

            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please do not divide by zero...");
                return;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
