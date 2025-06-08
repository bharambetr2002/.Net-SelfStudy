// understing basic syntax
namespace selfStudy;

using System;
//namespace declaration - its the collection of the classes in the program 

class Program1
{
    static void Main1()
    {
        System.Console.WriteLine("Calling from Main-1");
    }
    //main file
    static void Main2(string[] args)
    {
        //Write message on concole window - "Console Class"
        Console.WriteLine("Lets Begin my .Net Learning");
        //or
        System.Console.WriteLine("First .Net Program");

        //Calling from Main1 Function/Methods
        Main1();
    }

}