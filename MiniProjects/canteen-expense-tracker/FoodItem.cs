namespace CanteenTracker
{
    public abstract class FoodItem : IExpense
    {
        public string Name { get; protected set; }

        public FoodItem(string name)
        {
            Name = name;
        }

        public abstract double GetPrice();
    }
}