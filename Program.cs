using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter your full name");
            string fullname = Console.ReadLine();
            Console.WriteLine("Pleas enter your age");
            string age = Console.ReadLine();
            age = age.Replace(".", ",");
            double x = double.Parse(age);
            Console.WriteLine("Pleas enter your adress: 1.Street 2.Num home 3.Num Apartment ");
            string street = Console.ReadLine();
            string home = Console.ReadLine();
            home = home.Replace(".", ",");
            double u = double.Parse(home);
            string app = Console.ReadLine();
            app = app.Replace(".", ",");
            double t = double.Parse(app);
            Console.WriteLine("Please enter your mobile number");
            string number = Console.ReadLine();
            number = number.Replace(".", ",");
            double r = double.Parse(number);
            Console.WriteLine("Full name - " + fullname + ", Age - " + age);
            Console.WriteLine("Adress: " + "Street - " + street + ", Home - " + home + ", Apartment - " + app);
        }
    }
}
