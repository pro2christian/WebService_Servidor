using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0._0._0_Para_Estudar
{
    internal class Program
    {
        static void Main(string[] args)
        {
          MeuServidorWebService meuServidorLocal = new MeuServidorWebService("http://localhost:8080/MeuServidorLocal");
          Console.ReadKey();
        }
    }
}
