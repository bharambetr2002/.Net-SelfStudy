//Different type of Method Parameters
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace selfStudy;

class Program17
{
    //main class
    static void Main1()
    {
        int i = 0;
        int j = 0;
        int c = 11;
        int d = 10;
        int product = 0;
        int sum = 0;
        PassByValues(i); //passing the variable by value - creating a copy of that in int a
        System.Console.WriteLine("Pass by value: {0}", i);
        PassByRef(ref j);
        System.Console.WriteLine("Pass by reference: {0}", j);
        OutParamter(c, d, out product, out sum);
        System.Console.WriteLine("using out keyword sum : {0}, product : {1}", sum, product);
        // using params - allows multiple values to be passed as an array
        int total = AddMultipleNumbers(1, 2, 3, 4, 5);
        System.Console.WriteLine("Using params - sum of 1,2,3,4,5 is: {0}", total);
    }
    public static void PassByValues(int a)
    {
        a = 101; //changing the value of a to 101 which was 0 ago as coming as parameter
    }
    public static void PassByRef(ref int a)
    {
        a = 101; // here a and j are referening the same object so changing anyone value will affect both of them
    }
    // out is a keyword which dumbs the old value and initialises the new value from the function,
    // used for multiple output from a single function
    public static void OutParamter(int c, int d, out int product, out int sum)
    {
        product = c * d;
        sum = c + d;
    }

    // params allows variable number of arguments to be passed into the method
    public static int AddMultipleNumbers(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

}