using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Made By Anthony Romrell
public class StorePurchaseButton : MonoBehaviour, IPurchase
{
	public StoreGameAction StoreAction;
	
	public Button PurchaceButton;
	public Purchaseable Item;
	public Store ItemStore;

	private void Start()
	{
		PurchaceButton = GetComponent<Button>();
		StoreAction.Call(this);
	}

	
	
	public void Purchase()
	{
		PurchaceButton.interactable = false;
		ItemStore.MakePurchase(Item);
	}
}