using Checkout;
using NUnit.Framework;
using cout = Checkout.ApiServices.ShoppingList;

namespace Tests.ShoppingListService
{
    [TestFixture]
    public class ShoppingListServiceTests
    {
        public cout.ShoppingListService ShoppingListService { get; private set; }

        [SetUp]
        public void Setup()
        {
            this.ShoppingListService = new cout.ShoppingListService();
        }

        [Test]
        public void ServiceShouldAddItems()
        {
            APIClient client = new APIClient();
            this.ShoppingListService.AddDrink("test", 4);
            this.ShoppingListService.AddDrink("Aspalls", 40);
            var result = this.ShoppingListService.GetShoppingList(string.Empty);
            var testResult = this.ShoppingListService.GetShoppingList("test");

            this.ShoppingListService.UpdateDrink("test", 5);
            // take 5 off
            this.ShoppingListService.UpdateDrink("Aspalls", 35);

            this.ShoppingListService.DeleteDrink("test");
        }
    }
}
