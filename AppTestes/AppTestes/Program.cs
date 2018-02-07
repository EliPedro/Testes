using AppTestes.Models;
using System;
using System.Threading.Tasks;

namespace AppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task.Run(async () =>
            //{
            //   await Execute();
            //});
            var deb = new Debugar();
            
            Console.ReadLine();
        }

        private static async Task Execute()
        {
            var resultado = await Skip_Take.GetSkip();

            var resultado2 = await Skip_Take.GetTake();

            resultado.ForEach(c => Console.WriteLine(c));

            resultado2.ForEach(c => Console.WriteLine(c));

        }
    }
}
