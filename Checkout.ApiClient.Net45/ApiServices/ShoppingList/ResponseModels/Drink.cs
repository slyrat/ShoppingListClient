namespace Checkout.ApiServices.ShoppingList.ResponseModels
{
    public class Drink
    {
        public Drink()
            : this("Random name")
        {
        }

        public Drink(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Number { get; set; }
    }
}
