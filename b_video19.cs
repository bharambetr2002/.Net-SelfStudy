//introduction to class
using System.Diagnostics.Contracts;

namespace selfStudy;

class Program19
{
    //main file
    public static void Main1()
    {
        //created the instance/object of the customer with name c1 and passed on paramters to customer
        System.Console.WriteLine("With Parameters - constructors");
        Customer c1 = new Customer("Tanmay", "Bharambe");
        c1.PrintFullName();
        System.Console.WriteLine("Without Parameters - constructors");
        Customer c2 = new Customer();
        c2.PrintFullName();

    }
}
//creating a class Customer
class Customer
{
    string? _firstName;
    string? _lastName;
    // custructor with noo parameters
    public Customer() : this("no_fname", "no_lname") { }
    // custructor with 2 parameters
    public Customer(string FirstName, string LastName)
    {
        //this keyword refers to the object of the current class
        this._firstName = FirstName;
        this._lastName = LastName;
    }
    public void PrintFullName()
    {
        System.Console.WriteLine("The Full name is {0} {1}", _firstName, _lastName);
    }
    //destructor - we dont need this in c# its already there in c# - used to reomve anything class holded for the code in the runtime
    ~Customer() { }
}