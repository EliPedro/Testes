using AppTestes.SKIP_TAKE;
using System;

namespace AppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadLine();
        }

        private static async void Execute()
        {
            var resultado = await Skip_Take.GetSkip();

            var resultado2 = await Skip_Take.GetTake();

            resultado.ForEach(c => Console.WriteLine(c));

            resultado2.ForEach(c => Console.WriteLine(c));

        }
    }
}
