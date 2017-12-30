using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour
{

	public Store MyStore;
	
	private Text _gold;

	private void Awake()
	{
		PurchaseObject.SendPurchase += MakePurchase;
	}

	private void Start () {
		_gold = GetComponent<Text>();
		_gold.text = "$" + MyStore.Gold.ToString();
		BuyGold.AddGold += AddGoldHandler;
	}

    private void AddGoldHandler()
    {
        _gold.text = "$" + MyStore.Gold.ToString();
    }

	private void MakePurchase (PurchaseableBase purchase) {
		if (MyStore.Gold <= 0) return;
		MyStore.Gold -= purchase.Price;
		MyStore.Purchases.Add(purchase);
		print(purchase.name);
			
		foreach (var item in MyStore.Purchases)
		{
			print(item);
		}


		_gold.text = "$" + MyStore.Gold.ToString();
		print(MyStore.Purchases.Count);
	}
}