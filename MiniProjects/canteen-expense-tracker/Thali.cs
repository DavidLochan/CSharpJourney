namespace CanteenTracker
{
    public class Thali : FoodItem
    {
        public Thali() : base("Full Thali") { }

        public override double GetPrice()
        {
            return 70;
        }
    }
}