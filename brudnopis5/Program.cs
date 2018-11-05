using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brudnopis5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataOd = new DateTime(2018, 10, 30);
            DateTime dataDo = new DateTime(2018, 11, 5);

            while (dataOd < dataDo)
            {
                Console.WriteLine(dataOd);
                dataOd = dataOd.AddDays(1);
            }
            Console.WriteLine("grats");
            Console.WriteLine("g2");
            Console.ReadKey();
        }

        
    }
}
