using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuyGold : MonoBehaviour {

	public static UnityAction AddGold;
	
	public Store MyStore;

	public void BuyGoldFunction (int gold) {
		MyStore.Gold += gold;
		AddGold();
	}
}
