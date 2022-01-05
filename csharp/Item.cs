namespace csharp
{
    // Would prefer using abstract class with abstract method UpdateQuality, instead using virtual method or repeating same code/method
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }  
    }
}
