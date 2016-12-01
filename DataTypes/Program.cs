using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tipos de datos*/
            bool sentencia = true;
            int entero = 0;
            decimal dec = 12.1222m;
            float numFloat = 12.2323f;

            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
            Console.ReadKey();
        }
    }
}
