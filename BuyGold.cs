using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuyGold : MonoBehaviour {

	public static UnityAction AddGold;

	public void BuyGoldFunction (int _gold) {
		GameData.Instance.gold += _gold;
		AddGold();
	}
}
