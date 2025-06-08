//switch statement-continued + go-to statemnets
namespace selfStudy
{
    class Program12
    {
        // Main class
        static void Main1()
        {
            int TotalCoffeeCost = 0;

        Start: // 👈 Label defined with colon

            System.Console.WriteLine("1. Small, 2. Medium, 3. Large");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    TotalCoffeeCost += 100;
                    break;
                case 2:
                    TotalCoffeeCost += 200;
                    break;
                case 3:
                    TotalCoffeeCost += 300;
                    break;
                default:
                    System.Console.WriteLine("Your choice {0} is invalid", userChoice);
                    break;
            }

        Restart:
            System.Console.WriteLine("Do you want to buy another coffee - yes or no");
            string? userDecision = Console.ReadLine();
            switch (userDecision.ToLower())
            {
                case "yes":
                    goto Start; // Goes back to Start label
                case "no":
                    break;
                default:
                    System.Console.WriteLine(
                        "wrong input"
                    );
                    goto Restart;

            }

            System.Console.WriteLine("Thank you for shopping with us. Your total bill amount is {0}", TotalCoffeeCost);
        }
    }
}