using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        //interface'leri birbirinin alternatifi olan ama kod içeriği farklı olan durumlarda kullanırız.
        // örnek olarak tüm kredilerde ortak hesaplama vardır fakat faiz oranı vs. gibi özellikleri farklı olduğu için kodları farklıdır. Bu yüzden interface kullandık.
        void Calculate();
        void Anything();


    }
}
