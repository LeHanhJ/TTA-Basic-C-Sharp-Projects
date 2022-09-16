using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        //Introduces the Tech Academy and does not continue until user presses enter
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report (Please answer and press enter after every question");
        

        //Asks first daily question and uses variable attached to name to output name entered by user
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
        Console.ReadLine();


        //Asks second question and outputs a congratulatory message
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("Good job on getting to the " + course + " course!");
        Console.ReadLine();


        //Asks what page number user is on, will convert string to int
        Console.WriteLine("What page number?");
        string page = Console.ReadLine();
        int pageNum = Convert.ToInt32(page);
        Console.WriteLine("Wow! Good job on getting to page " + pageNum + "!");
        Console.ReadLine();


        //Converts string entered by user to a boolean. Will bring up error if T/F is not inputted
        Console.WriteLine("Do you need help with anything? Please answer True or False.");
        string needHelp = Console.ReadLine();
        bool help = Convert.ToBoolean(needHelp);
        Console.WriteLine("Please reach out to us if you need any help.");
        Console.ReadLine();


        //Asks if user has had any positive experiences
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();
        Console.ReadLine();


        //Asks if there is any other feedback user would like to give
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.ReadLine();


        //Converts hours input by the user from a string to an integer
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        int hours = Convert.ToInt32(hoursStudied);
        Console.WriteLine("Congrats on studying that long today! (Please press enter)");
        Console.ReadLine();

        //Thanks the user for sending in answers
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();

        //

    }
}

