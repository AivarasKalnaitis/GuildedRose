using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    class ConjuredItem : BasicItem
    {
        public override void UpdateQuality()
        {
            if (SellIn > 0)
            {
                SellIn--;

                if (Quality >= DecrementValue * 2)
                    Quality -= DecrementValue * 2;
            }
            else if (SellIn == 0)
            {
                if (Quality >= DecrementValue * 4)
                    Quality -= DecrementValue * 4;
            }
        }
    }
}
