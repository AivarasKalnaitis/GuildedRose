using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class BackstagePass : BasicItem
    {
        public override void UpdateQuality()
        {
            if (SellIn > 0)
            {
                SellIn--;

                if (Quality < 50)
                {
                    Quality += 1;

                    if (SellIn < 11)
                    {
                        Quality += 1;
                    }

                    if (SellIn < 6)
                    {
                        Quality += 1;
                    }
                }
            }
            else if (SellIn == 0)
                Quality = 0;
        }
    }
}
