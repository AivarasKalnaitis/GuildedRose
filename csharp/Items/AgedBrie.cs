using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class AgedBrie : BasicItem
    {
        public override void UpdateQuality()
        {
            if (SellIn > 0)
            {
                SellIn--;

                if (Quality <= 50 - DecrementValue)
                    Quality += DecrementValue;
            }
            else if (SellIn == 0)
            {
                if (Quality <= 50 - 2 * DecrementValue)
                    Quality += 2 * DecrementValue;
            }
        }
    }
}
