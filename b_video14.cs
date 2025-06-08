//do-while Loop
namespace selfStudy;

class Program14
{
    //main class
    static void Main1()
    {
        string? choice = "";
        do
        {
            System.Console.WriteLine("Enter the target Number :- ");
            int num = int.Parse(Console.ReadLine());

            int Start = 0;
            while (Start <= num)
            {
                System.Console.Write(Start + " ");
                Start = Start + 2;
            }
            do
            {
                System.Console.WriteLine("\nDo you want to continue - yes or no");
                choice = Console.ReadLine();
                if (choice != "yes" && choice != "no")
                {
                    System.Console.WriteLine("please reply in yes or no");
                }
            } while (choice != "yes" && choice != "no");
        } while (choice == "yes");
    }
}