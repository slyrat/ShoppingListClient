namespace Checkout
{
    public static class ShoppingListApiUrls
    {
        private static string _shoppingListGetUrl;
        private static string _shoppingListPostUrl;
        private static string _shoppingListGetAllUrl;

        public static void ResetApiUrls()
        {
            _shoppingListGetUrl = null;
        }

        public static string ShoppingListGetAll
            => _shoppingListGetAllUrl ?? (_shoppingListGetAllUrl = 
                string.Concat(AppSettings.BaseApiUri,
                    "/ShoppingList?pageSize={0}&page={1}&sortAscending={3}&sortBy={2}"));

        public static string ShoppingListGetDelete
            => _shoppingListGetUrl ?? (_shoppingListGetUrl = string.Concat(AppSettings.BaseApiUri, "/ShoppingList/{0}"));

        public static string ShoppingListPostPut
            => _shoppingListPostUrl ?? (_shoppingListPostUrl = string.Concat(AppSettings.BaseApiUri, "/ShoppingList/{0}/{1}"));
    }
}