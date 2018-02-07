using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTestes.SKIP_TAKE
{
    public class Skip_Take
    {
       public static async Task<List<int>> GetSkip()
       {
            await Task.Delay(0);

            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };
            var filtro = grades.Skip(3).ToList();
         
            return filtro;
       }

        public static async Task<List<int>> GetTake()
        {
            await Task.Delay(0);

            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };
            var filtro = grades.Take(3).ToList();

            return filtro;
        }
    }
}
