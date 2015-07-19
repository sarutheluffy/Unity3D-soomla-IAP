using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


namespace Soomla.Store.Example
{ 																		//Allows for access to Soomla API										
    public class ExampleWindow : MonoBehaviour
    {
        void Start()
        {
            StoreEvents.OnSoomlaStoreInitialized += onSoomlaStoreIntitialized;
            StoreEvents.OnRestoreTransactionsFinished += onRestoreTransactionsFinished;
            StoreEvents.OnMarketPurchase += onMarketPurchase;
            StoreEvents.OnMarketPurchaseCancelled += onMarketPurchaseCancelled;
            StoreEvents.OnUnexpectedErrorInStore += onUnexpectedErrorInStore;
            StoreEvents.OnMarketPurchaseStarted += onMarketPurchaseStarted;
            SoomlaStore.Initialize(new ExampleAssets());
        }


        /// <summary>
        /// Anything you would like tot initialize when the store is initializing like for android IAP you would like to call 
        /// Store.IAPBg() etc.
        /// </summary>
        public void onSoomlaStoreIntitialized() { }

        /// <summary>
        /// what would you like to do when the restore purchase started
        /// </summary>
        void OnRestoreTransactionsStarted()
        {
        
        }
        /// <summary>
        /// what would you like to do when the restore transaction is finished like you want to disable the loader if any you are showing 
        /// </summary>
        /// <param name="hello"></param>
        void onRestoreTransactionsFinished(bool hello)
        {
        }


        /// <summary>
        /// what would you like to do when the marketpurchase started
        /// for example showing the loader or etc
        /// </summary>
        /// <param name="pvi"></param>
        void onMarketPurchaseStarted(PurchasableVirtualItem pvi)
        {
        }
        /// <summary>
        /// you would like to implement and set the value of playerprefs when the purchase is successfull
        /// here pvi.getItemId=" the id you have assign in soomla plugin for different IAP"
        /// </summary>
        /// <param name="pvi"></param>
        /// <param name="payload"></param>
        /// <param name="extra"></param>
        void onMarketPurchase(PurchasableVirtualItem pvi, string payload, Dictionary<string, string> extra)
        {
        }
        /// <summary>
        /// when and unexpected arror occure like the user is not connected to the internet etc
        /// </summary>
        /// <param name="msg"></param>
        void onUnexpectedErrorInStore(string msg)
        {
        }
        /// <summary>
        /// when the transaction if cancelled e.g dur to invalid username and passwoord or the internet connection lost
        /// </summary>
        /// <param name="pvi"></param>
        void onMarketPurchaseCancelled(PurchasableVirtualItem pvi)
        {
        }


        /// <summary>
        /// you can make purchase by passing the soomla product id that you have been specified 
        /// Or you can write the different function for you each in-app-purchase 
        /// </summary>
        /// <param name="skipLevel"></param>

        public void UnLockLevel(string skipLevel)
        {
            try
            {
                Debug.Log("attempt to purchase");

                if (skipLevel != null)
                {
                    StoreInventory.BuyItem(skipLevel);

                }
            }
            catch (Exception e)
            {																						
                Debug.Log("SOOMLA/UNITY" + e.Message);
            }
        }

        public void RemoveAdsPermanently()
        {
            try
            {
                Debug.Log("attempt to purchase");
                StoreInventory.BuyItem("remove_ads_item_id");
            }
            catch (Exception e)
            {																					
                Debug.Log("SOOMLA/UNITY" + e.Message);
            }

        }

        /// <summary>
        ///  Restoring the IAP 
        /// </summary>
        public void RestoreInAppPurchase()
        {
            try
            {
                SoomlaStore.RestoreTransactions();													// restore purchases if possible
            }
            catch (Exception e)
            {
                Debug.Log("SOOMLA/UNITY" + e.Message);												// if restoring purchases fails (connectivity issue, IAP doesnt exist on ItunesConnect, etc...)
            }
        }

       
    }
}