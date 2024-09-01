using Business.Concrete;
using Entities.Concrete;

class Program
{
     static void Main(string[] args)
    {

        SelamVer();
        SelamVer();

        Person person1 = new Person();
        person1.FirstName = "Test";
        person1.LastName = "Test";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;


        PttManager pttManager = new PttManager(new PersonManager);
        pttManager.GiveMask(person1);

    }

    static void SelamVer()
    {
        Console.WriteLine("Merhaba");
    }


}