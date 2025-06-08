//reading and writing to console
namespace selfStudy;

class Program2
{
    //main file
    static void Main1()
    {
        // to print message
        System.Console.WriteLine("Please Enter your name : ");
        // to read data - return type string
        string? UserName = Console.ReadLine();
        // concating method of printing data
        System.Console.WriteLine("Hello " + UserName);
        // placeHolder syntax
        Console.WriteLine("Hello {0}", UserName);


        // Printing firstname & lastname 
        System.Console.WriteLine("Enter your first name :- ");
        string? fname = Console.ReadLine();
        System.Console.WriteLine("Enter your last name :- ");
        string? lname = Console.ReadLine();
        // here 0 is the first place holder and 1 is the second placeholder
        Console.WriteLine("User Name :- {0} {1}", fname, lname);
    }
}