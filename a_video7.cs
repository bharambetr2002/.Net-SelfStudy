//Datatype Conversion is C#
namespace selfStudy;

class Program7
{
    // Main Class
    static void Main1()
    {
        float f = 123780.45F;
        //convesion way 1 - dataloss possible - explisit conversion
        int i = (int)f;
        //convesion way 2 
        System.Console.WriteLine("Explisit Conversion :-");
        int j = Convert.ToInt32(f);
        System.Console.WriteLine("Way 1 :- {0}", i);
        System.Console.WriteLine("Way 2 :- {0}", j);

        //parse() & try parse()
        string strnumber = "100";
        int value = int.Parse(strnumber);
        System.Console.WriteLine("Using Parse - int.Parse() :- {0}", value);


        string strnumber1 = "100TG";
        int value2 = 0;
        bool success = int.TryParse(strnumber1, out value2);
        //System.Console.WriteLine("Using TryParse - int.Parse() :- {0} & Sucessrate:- {1}", value2, success);
        if (success)
        {
            System.Console.WriteLine("Using TryParse - int.Parse() value = {0}", value2);
        }
        else
        {
            System.Console.WriteLine("Enter The valid number");
        }
    }
}