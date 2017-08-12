using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.ShoppingList.ResponseModels;
using System.Collections.Generic;

namespace Checkout.ApiServices.ShoppingList
{
    public class ShoppingListService
    {
        public HttpResponse<List<Drink>> GetShoppingList(string name)
        {
            var getShoppingListUri = string.Format(ShoppingListApiUrls.ShoppingListGetDelete, !string.IsNullOrEmpty(name) ? "/" + name : "");
            return new ApiHttpClient().GetRequest<List<Drink>>(getShoppingListUri, null);
        }

        public HttpResponse<OkResponse> AddDrink(string name, int number)
        {
            var postShoppingListUri = string.Format(ShoppingListApiUrls.ShoppingListPostPut, name, number);
            return new ApiHttpClient().PostRequest<OkResponse>(postShoppingListUri, null);
        }

        public HttpResponse<OkResponse> UpdateDrink(string name, int number)
        {
            var putShoppingListUri = string.Format(ShoppingListApiUrls.ShoppingListPostPut, name, number);
            return new ApiHttpClient().PutRequest<OkResponse>(putShoppingListUri, null);
        }

        public HttpResponse<OkResponse> DeleteDrink(string name)
        {
            var deleteShoppingListUri = string.Format(ShoppingListApiUrls.ShoppingListGetDelete, "/" + name);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteShoppingListUri, null);
        }
    }
}