using System;

namespace AppTestes.Models
{
    public class Methods
    {

        public static int _variavel = 0;

        public static void Executar(string parametro)
        {
            Console.WriteLine("Executar:Parâmetro = {0}", parametro);
        }
        

        public void Mensagem()
        {
            Console.WriteLine("!!!");
        }
        
        public static int ObterValor()
        {
            return _variavel;
        }
    }
}
