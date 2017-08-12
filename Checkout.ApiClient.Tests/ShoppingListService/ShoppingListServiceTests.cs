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
            var result = this.ShoppingListService.GetShoppingList(string.Empty);
        }
    }
}
