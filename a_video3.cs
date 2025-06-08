// built-in datatypes in dotnet
using System.Runtime.InteropServices;

namespace selfStudy;

class Program3
{
    //main file
    static void Main1()
    {
        // boolean - only true false values allowed, here it cant be 0 or 1 stricly true false
        bool b = true;
        System.Console.WriteLine("Bool value {0}", b);
        System.Console.WriteLine("Min and max int value : {0} , {1}", int.MinValue, int.MaxValue);
    }
}