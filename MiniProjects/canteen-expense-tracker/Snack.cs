namespace CanteenTracker
{
    public class Snack : FoodItem
    {
        public Snack(string name) : base(name) { }

        public override double GetPrice()
        {
            return 20; // samosa / chai / coffee
        }
    }
}