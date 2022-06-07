using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BusinessCreditManager : ICreditManager
    {
        public void Anything()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
