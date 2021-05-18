using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    public class Metodi
    {
        public static void Inserimento(ref int _n)
        {
            Console.Write("Numero: ");
            _n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
