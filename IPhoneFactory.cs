using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern_Andrew_N
{
    public interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();


    }

    public class SamsungFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Asha();

        }

        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }
    }

    public class HTCFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Genie();
        }

        public ISmart GetSmart()
        {
            return new Titan();
        }
    }

    public class NokiaFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Primo();
        }

        public ISmart GetSmart()
        {
            return new Lumia();
        }
    }


}
