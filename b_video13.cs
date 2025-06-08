//Loop in c# - while loop
namespace selfStudy;

class Program13
{
    //Main Class
    static void Main1()
    {
        System.Console.WriteLine("Enter the target Number :- ");
        int num = int.Parse(Console.ReadLine());

        int Start = 0;
        while (Start <= num)
        {
            System.Console.WriteLine(Start);
            Start = Start + 2;
        }
    }
}