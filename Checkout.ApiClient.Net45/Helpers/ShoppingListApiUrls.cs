namespace Checkout
{
    public static class ShoppingListApiUrls
    {
        private static string _shoppingListGetUrl;
        private static string _shoppingListPostUrl;

        public static void ResetApiUrls()
        {
            _shoppingListGetUrl = null;
        }

        public static string ShoppingListGet
            => _shoppingListGetUrl ?? (_shoppingListGetUrl = string.Concat(AppSettings.BaseApiUri, "/ShoppingList{0}"));

        public static string ShoppingListPost
            => _shoppingListPostUrl ?? (_shoppingListPostUrl = string.Concat(AppSettings.BaseApiUri, "/ShoppingList/{0}/{1}"));
    }
}