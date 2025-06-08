//methods
using System.Runtime.InteropServices;

namespace selfStudy;

class Program16
{
    // main file no access modifier
    static void Main1()
    {
        //non static - needs obj to be called
        System.Console.WriteLine("Created obj to access EvenNumbers");
        Program16 p = new Program16();
        p.EvenNumbers();
        System.Console.WriteLine("Created obj to access EvenNumber");
        EvenNumber();
        System.Console.WriteLine("Add 2 numbers using parameters - 10  20");
        int AddNumber = p.AddNumber(10, 20);
        System.Console.WriteLine("Addition = {0}", AddNumber);


    }
    // no static keyword - so its instance method (Even Number)
    public void EvenNumbers()
    {
        int Start = 0;
        while (Start <= 20)
        {
            System.Console.WriteLine(Start);
            Start += 2;
        }
    }
    //same static method
    public static void EvenNumber()
    {
        int Start = 0;
        while (Start <= 20)
        {
            System.Console.WriteLine(Start);
            Start += 2;
        }
    }
    //creating a non static method to add two numbers as it is non static we will create a object of program class and call this instance in the object
    public int AddNumber(int a, int b)
    {
        int c = a + b;
        return c;
    }

}