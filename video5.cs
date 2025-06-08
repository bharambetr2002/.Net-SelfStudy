// Commom Operators in C#
namespace selfStudy;

class Program5
{
    // Main file
    static void Main1()
    {
        // Assignment operation =
        int a = 10;
        int b = 20;

        // Arithmetic operators +, -, *, /
        System.Console.WriteLine("Arithmetic Operators:");
        System.Console.WriteLine("a + b = " + (a + b));
        System.Console.WriteLine("a - b = " + (a - b));
        System.Console.WriteLine("a * b = " + (a * b));
        System.Console.WriteLine("b / a = " + (b / a));
        System.Console.WriteLine("b % a = " + (b % a)); // Modulus

        // Comparison operators ==, !=, >, >=, <, <=
        System.Console.WriteLine("\nComparison Operators:");
        System.Console.WriteLine("a == b : " + (a == b));
        System.Console.WriteLine("a != b : " + (a != b));
        System.Console.WriteLine("a > b  : " + (a > b));
        System.Console.WriteLine("a >= b : " + (a >= b));
        System.Console.WriteLine("a < b  : " + (a < b));
        System.Console.WriteLine("a <= b : " + (a <= b));

        // Conditional (Logical) operators &&, ||
        System.Console.WriteLine("\nConditional Operators:");
        bool x = true;
        bool y = false;
        System.Console.WriteLine("x && y : " + (x && y));
        System.Console.WriteLine("x || y : " + (x || y));

        // Ternary operator ?:
        System.Console.WriteLine("\nTernary Operator:");
        int max = (a > b) ? a : b;
        System.Console.WriteLine("Max of a and b is: " + max);

        // Null coalescing operator ??
        System.Console.WriteLine("\nNull Coalescing Operator:");
        string? name = null;
        string displayName = name ?? "Default Name";
        System.Console.WriteLine("Name is: " + displayName);
    }
}