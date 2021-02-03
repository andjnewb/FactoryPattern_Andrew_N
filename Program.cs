using System;

namespace FactoryPattern_Andrew_N
{
    public enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }

    class Program
    {


        static void Main(string[] args)
        {
            Manufacturers manufacturers = new Manufacturers();
            PhoneTypeChecker phoneTypeChecker = new PhoneTypeChecker(manufacturers);
            phoneTypeChecker.CheckProducts();

            Console.WriteLine("Hello World!");
        }
    }
}
