using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour {

	Text gold;

	void Awake()
	{
		PurchaseObject.SendPurchase += MakePurchase;
	}
	void Start () {
		gold = GetComponent<Text>();
		gold.text = "$" + GameData.Instance.gold.ToString();
		BuyGold.AddGold += AddGoldHandler;
	}

    private void AddGoldHandler()
    {
        gold.text = "$" + GameData.Instance.gold.ToString();
    }

    public void MakePurchase (int _cost, GameObject _object) {
		if (GameData.Instance.gold > 0)
		{
			GameData.Instance.gold -= _cost;
			GameData.Instance.purchases.Add(_object.name);
			print(_object.name);
			
			foreach (var item in GameData.Instance.purchases)
			{
				print(item);
			}


			gold.text = "$" + GameData.Instance.gold.ToString();
			print(GameData.Instance.purchases.Count);
		}
	}
}