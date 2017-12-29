using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseManager : MonoBehaviour {

	Text _gold;

	void Awake()
	{
		PurchaseObject.SendPurchase += MakePurchase;
	}
	void Start () {
		_gold = GetComponent<Text>();
		_gold.text = "$" + GameData.Instance.gold.ToString();
		BuyGold.AddGold += AddGoldHandler;
	}

    private void AddGoldHandler()
    {
        _gold.text = "$" + GameData.Instance.gold.ToString();
    }

    public void MakePurchase (int cost, GameObject _object) {
		if (GameData.Instance.gold > 0)
		{
			GameData.Instance.gold -= cost;
			GameData.Instance.purchases.Add(_object.name);
			print(_object.name);
			
			foreach (var item in GameData.Instance.purchases)
			{
				print(item);
			}


			_gold.text = "$" + GameData.Instance.gold.ToString();
			print(GameData.Instance.purchases.Count);
		}
	}
}