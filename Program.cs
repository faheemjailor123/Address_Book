using System;

namespace AddressBook01
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacts myobj = new Contacts("faheem", "jailor", "shaniwar peth", "1542637894", "fah@gmail.com", "solpur", "maharashtra", "896532");
            Console.WriteLine("First Name: {0} Last Name: {1} Address: {2} Phone Number: {3} Email: {4} City: {5} State: {6} ZipCode: {7}",myobj.firstName,myobj.lastName, myobj.address, myobj.phoneNumber, myobj.email,myobj.city,myobj.state,myobj.zip);
        }
    }
}
