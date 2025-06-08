//namespaces in c#
using ABC = ProjectA.ClassA; // using alias
namespace selfStudy
{

    class Program18
    {
        static void Main1()
        {
            ABC.Print();
            ProjectA.ClassB.Print();
        }
    }
}
namespace ProjectA
{
    class ClassA
    {
        public static void Print()
        {
            System.Console.WriteLine("Heyy, i am from namespace projectA class A");
        }
    }
}
namespace ProjectA
{
    class ClassB
    {
        public static void Print()
        {
            System.Console.WriteLine("Heyy, i am from namespace projectA class B");
        }
    }
}