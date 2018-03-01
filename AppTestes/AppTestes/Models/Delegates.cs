using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestes.Models
{
    public class Delegates
    {
        public delegate void SimplesDelegate();

        public static void MinhaFuncao()
        {
            Console.WriteLine("Eu fui chamada por um delegate ...");
        }
    
        public static void Testar()
        {
            //var simplesDelegate = new SimplesDelegate(MinhaFuncao);
            //simplesDelegate();
            OutroMetodo();


        }
        private static void OutroMetodo()
        {
            MetodoQueRecebeUmDelegate(MetodoASerExecutado, "Hello world");
        }
        private static void MetodoQueRecebeUmDelegate(Action<string> meuDelegate, string paremetro)
        {
            meuDelegate(paremetro);
        }

        private static void MetodoASerExecutado(string parametro)
        {
            Console.WriteLine(parametro);
        }

      
    }
}
