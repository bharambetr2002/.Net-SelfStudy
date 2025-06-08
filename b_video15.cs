// for and for-each loop
namespace selfStudy
{
    class Program15
    {
        static void Main1()
        {
            // for loop
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 12;
            arr[2] = 123;
            arr[3] = 1234;
            arr[4] = 12345;

            System.Console.WriteLine("Printing elements using for");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine("Array element index = {0} value = {1}", i, arr[i]);
            }

            //foreach loop
            System.Console.WriteLine("Printing elements using foreach");
            int index = 0;
            foreach (int k in arr)
            {
                System.Console.WriteLine("Array element index = {0} value = {1}", index, k);
                index++;
            }
        }
    }
}
