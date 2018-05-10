using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Purchaseble", menuName = "Store/Item")]
public class Purchaseable : ScriptableObject {

	public int Price;
	public GameObject PurchacedObject;
	public bool Purchased;
}

public interface IPurchase
{
	
}