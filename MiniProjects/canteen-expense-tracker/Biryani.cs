namespace CanteenTracker
{
    public class Biryani : FoodItem
    {
        public Biryani() : base("Chicken Biryani") { }

        public override double GetPrice()
        {
            return 120;
        }
    }
}