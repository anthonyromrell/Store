using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Made By Anthony Romrell
public class StoreObjects : MonoBehaviour
{
	public Store ItemStore;
	public StoreGameAction AddButtons;

	public List<StorePurchaseButton> PurchaseButtons;

	private void Awake()
	{
		AddButtons.Call += Call;
	}

	private void Call(object obj)
	{
		PurchaseButtons.Add(obj as StorePurchaseButton);
	}


	private void Start()
	{
		CheckStore();	
	}

	public void CheckStore()
	{
		ItemStore.CanPurchaseCheck(PurchaseButtons);
	}
}