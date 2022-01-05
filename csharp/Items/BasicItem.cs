using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class BasicItem : Item
    {
        public int DecrementValue { get; set; } = 1;

        public virtual void UpdateQuality()
        {
            if (SellIn > 0)
            {
                SellIn--;

                if (Quality >= DecrementValue)
                    Quality -= DecrementValue;
            }
            else if (SellIn == 0)
            {
                if (Quality >= 2 * DecrementValue)
                    Quality -= 2 * DecrementValue;
            }
        }
    }
}
