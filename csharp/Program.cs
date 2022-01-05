using csharp.Items;
using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Item> Items = new List<Item>
            {
                new BasicItem 
                {
                    Name = "+5 Dexterity Vest", 
                    SellIn = 10, 
                    Quality = 20
                },
                new Item 
                {
                    Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                },
                new BasicItem 
                {
                    Name = "Elixir of the Mongoose", 
                    SellIn = 5, 
                    Quality = 7
                },
                new Item 
                {
                    Name = "Sulfuras, Hand of Ragnaros", 
                    SellIn = 0, 
                    Quality = 80
                },
                new Item 
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = -1, 
                    Quality = 80
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new ConjuredItem {
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                }
            };

            var app = new GildedRose(Items);


            string line = new string('-', 80);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("Day " + i);
                Console.WriteLine(line);
                Console.WriteLine("| {0,-50} | {1,-10} | {2,-10} |", "Name", "Sell In", "Quality");
                Console.WriteLine(line);

                for (var j = 0; j < Items.Count; j++)
                {
                    Console.WriteLine("| {0,-50} | {1,-10} | {2,-10} |", Items[j].Name, Items[j].SellIn, Items[j].Quality);
                    Console.WriteLine(line);

                }

                app.UpdateQuality();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
