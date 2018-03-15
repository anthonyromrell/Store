using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

public class PurchaseObject : MonoBehaviour {

	public static UnityAction<PurchaseableBase> SendPurchase;
	
	public Store MyStore;
	public PurchaseableBase MyPurchase;

	public void MakePurchase () {
		MyStore.Purchases = null;
		SendPurchase(MyPurchase);
	}
}
