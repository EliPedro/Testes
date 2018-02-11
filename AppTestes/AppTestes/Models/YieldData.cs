using System.Collections.Generic;

namespace AppTestes.Models
{
    public class YieldData
    {
        public YieldData() { }
    
        static public IEnumerable<YieldData> CreateSomeDatas()
        {
            yield return new YieldData();
            yield return new YieldData();
            yield return new YieldData();
        }
    }
}
