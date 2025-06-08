//switch statement
namespace selfStudy;

class Program11
{
    //Main class
    static void Main1()
    {
        System.Console.WriteLine("Enter the number :- ");
        int num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 10:
                System.Console.WriteLine("Number is 10");
                break;
            case 20:
                System.Console.WriteLine("Number is 20");
                break;
            case 30:
                System.Console.WriteLine("Number is 30");
                break;
            default:
                System.Console.WriteLine("Enter number 10 or 20 or 30");
                break;

        }
    }
}