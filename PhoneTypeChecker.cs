using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_Andrew_N
{
    


    public class PhoneTypeChecker
    {
        //This class' purpose is to find the smart and dumb phone for each manufacturer.


        Manufacturers manu;//Enum of phone manufacturers
        IPhoneFactory factory;//Factory that creates the objects

        public PhoneTypeChecker(Manufacturers manu)
        {
            this.manu = manu;

        }

        public void CheckProducts()
        {
            //This function will go through the enum that was passed in , printing the smart and dumb phone for each manufacturer

            foreach (Manufacturers manufacturers in Enum.GetValues(typeof(Manufacturers)))
            {
                if (manufacturers.ToString() == "SAMSUNG")
                {

                    Console.WriteLine("Samsung:");

                    //Now we know what type of factory to assign
                    factory = new SamsungFactory();

                    ISmart smartPhone = factory.GetSmart();
                    Console.Write("Smart- ");
                    Console.WriteLine(smartPhone.getName());

                    IDumb dumbPhone = factory.GetDumb();
                    Console.Write("Dumb- ");
                    Console.WriteLine(dumbPhone.getName());


                    string test = Console.ReadLine();

                }

                if (manufacturers.ToString() == "HTC")
                {

                    Console.WriteLine("HTC:");

                    //Now we know what type of factory to assign
                    factory = new HTCFactory();

                    ISmart smartPhone = factory.GetSmart();
                    Console.Write("Smart- ");
                    Console.WriteLine(smartPhone.getName());

                    IDumb dumbPhone = factory.GetDumb();
                    Console.Write("Dumb- ");
                    Console.WriteLine(dumbPhone.getName());


                    string test = Console.ReadLine();

                }

                if (manufacturers.ToString() == "NOKIA")
                {

                    Console.WriteLine("Nokia:");

                    //Now we know what type of factory to assign
                    factory = new NokiaFactory();

                    ISmart smartPhone = factory.GetSmart();
                    Console.Write("Smart- ");
                    Console.WriteLine(smartPhone.getName());

                    IDumb dumbPhone = factory.GetDumb();
                    Console.Write("Dumb- ");
                    Console.WriteLine(dumbPhone.getName());


                    string test = Console.ReadLine();

                }
            }

            

           


        }


    }
}
