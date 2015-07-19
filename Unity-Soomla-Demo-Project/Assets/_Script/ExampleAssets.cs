using UnityEngine;
using System.Collections;
namespace Soomla.Store.Example
{
    public class ExampleAssets : IStoreAssets
    {
        public int GetVersion()
        {
            return 0;
        }

        public VirtualCurrency[] GetCurrencies()
        {
            return new VirtualCurrency[] { };
        }


        public VirtualGood[] GetGoods()
        {												// Add "TURN_GREEN" IAP to GetGoods
            return new VirtualGood[] { REMOVE_ADS};
        }

        public VirtualCurrencyPack[] GetCurrencyPacks()
        {								// Get/Setup Currency Packs
            return new VirtualCurrencyPack[] { };
        }

        public VirtualCategory[] GetCategories()
        {										// Get/ Setup Categories (for In App Purchases)
            return new VirtualCategory[] { };
        }

        //****************************BOILERPLATE ABOVE(modify as you see fit/ if nessisary)***********************
        public const string REMOVE_ADS_PRODUCT_ID = "com.codebrew.removeads";

        /** Lifetime Virtual Goods (aka - lasts forever **/

        // Create the 'TURN_GREEN' LifetimeVG In-App Purchase
        public static VirtualGood REMOVE_ADS = new LifetimeVG(
        "turn_green",
        "This will turn the cube green.",
        "remove_ads_item_id",
        new PurchaseWithMarket(REMOVE_ADS_PRODUCT_ID, 0.99)
        );
    }

}
