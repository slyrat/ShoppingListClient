using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.ShoppingList.ResponseModels;
using System.Collections.Generic;

namespace Checkout.ApiServices.ShoppingList
{
    public class ShoppingListService
    {
        public HttpResponse<List<Drink>> GetShoppingList(string name)
        {
            var getShoppingListUri = string.Format(ShoppingListApiUrls.ShoppingListGet, name == null ? "/" + name : "");
            return new ApiHttpClient().GetRequest<List<Drink>>(getShoppingListUri, null);
        }

        public HttpResponse<OkResponse> AddDrink(string name, int number)
        {
            var postShoppingListUri = string.Format(ShoppingListApiUrls.ShoppingListPost, name, number);
            return new ApiHttpClient().PostRequest<OkResponse>(postShoppingListUri, null);
        }
    }
}