using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Store", menuName = "Store/New Store")]
public class Store : ScriptableObject {
     public int Coins;
    
     public List<Purchaseable> Purchases;
   
     public void GetCoins(int coin)
     {
         Coins += coin;
     }

     public void MakePurchase(Purchaseable purchase)
     {
      
            if (purchase.Price <= Coins)
             {
                 Coins -= purchase.Price;
                 Purchases.Add(purchase);
                 purchase.Purchased = true;
             }
        
     }

     public void CanPurchaseCheck(List<StorePurchaseButton> storeButtons)
     {
         foreach (var storeButton in storeButtons)
         {
             if (storeButton.Item.Price <= Coins && !storeButton.Item.Purchased)
             {
                 storeButton.PurchaceButton.interactable = true;
             }
      
         }
     }

//    private void OnDisable()
//    {
//        PlayerPrefs.SetString("Data", JsonUtility.ToJson(this));
//        
//        Debug.Log(PlayerPrefs.GetString("Data"));
//    }
//
//
//    private void OnEnable()
//    {
//       // ScriptableObject.CreateInstance<Store>();
//       // JsonUtility.FromJson<Store>(PlayerPrefs.GetString("Data"));
//        Debug.Log(PlayerPrefs.GetString("Data"));
//
//        
//    }
}

public interface IStore
{
    
}