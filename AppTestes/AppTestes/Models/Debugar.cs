using System;
using System.Diagnostics;

namespace AppTestes.Models
{
    public class Debugar
    {

        public Debugar()
        {
            this.Teste();
            this.Teste2();

            #if DEBUG
                 Teste3();
            #endif

        }

        [Conditional("DEBUG")]
        private void Teste()
        {
            Console.WriteLine("Teste 1");
        }

        private void Teste2()
        {
            Console.WriteLine("Teste 2");
        }
        
        private void Teste3()
        {
            Console.WriteLine("DEBUG");
        }
    }
}
