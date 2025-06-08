// nullable types in c#

namespace selfStudy;

class Program6
{
    // main file
    static void Main1()
    {
        // reference types can be null and value types cant.
        //string Name = null;
        // to make value type nullable we use ?
        // int? i = null;

        // using nullabe in bools
        bool? AreYouMajor = null;
        if (AreYouMajor == true)
        {
            System.Console.WriteLine("You are Major");
        }
        else if (AreYouMajor == false)
        {
            System.Console.WriteLine("User is Not Major");
        }
        else
        {
            System.Console.WriteLine("User did not answer the question");
        }

        // Null Coalesing Operator  - ??
        int? TicketsOnSale = null;
        int AvaliableTicekts = TicketsOnSale ?? 0;

        // if (TicketsOnSale == null)
        // {
        //     AvaliableTicekts = 0;
        // }
        // else
        // {
        //     AvaliableTicekts = (int)TicketsOnSale;
        // }
        System.Console.WriteLine("Avaliable Tickets are {0}", AvaliableTicekts);
    }
}
