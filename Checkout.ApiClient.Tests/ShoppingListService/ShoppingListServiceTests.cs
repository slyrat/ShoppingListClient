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

        [Test(Description ="Tests multiple parts of the system, aka integration checks")]
        public void ServiceShouldAddItems()
        {
            APIClient client = new APIClient();
            this.ShoppingListService.AddDrink("test", 4);
            this.ShoppingListService.AddDrink("Aspalls", 40);
            var result = this.ShoppingListService.GetShoppingList(string.Empty);
            Assert.AreEqual(2, result.Model.Count);

            // check paging / sorting
            result = this.ShoppingListService.GetEntireShoppingList(1, 1, "Name");
            Assert.AreEqual(1, result.Model.Count);
            Assert.AreEqual("Aspalls", result.Model[0].Name);

            result = this.ShoppingListService.GetShoppingList("test");
            Assert.AreEqual(1, result.Model.Count);

            this.ShoppingListService.UpdateDrink("test", 5);
            // take 5 off
            this.ShoppingListService.UpdateDrink("Aspalls", 35);

            this.ShoppingListService.DeleteDrink("test");

            result = this.ShoppingListService.GetShoppingList(string.Empty);
            Assert.AreEqual(1, result.Model.Count);
        }
    }
}
