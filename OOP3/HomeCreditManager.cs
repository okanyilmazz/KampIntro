using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class HomeCreditManager : ICreditManager
    {
        public void Anything()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Koonut kredisi ödeme planı hesaplandı.");
        }
    }
}
