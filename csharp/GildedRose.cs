using csharp.Items;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        readonly IList<BasicItem> Items;

        public GildedRose(IList<BasicItem> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }
        }
    }
}
