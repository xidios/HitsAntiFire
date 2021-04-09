using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurRate
{
    public class Fire
    {
        public int TotalArea { get; set; }
        public Fire(Random random)
        {
            TotalArea = random.Next(minValue: 1, maxValue: 10);
        }
        //public bool Exist { get; set; } = true;
        //private void CheckFireExist()
        //{

        //    if (TotalArea == 0)
        //    {
        //        Exist = false;
        //    }
        //}

    }
}
