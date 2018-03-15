using System.Collections.Generic;
using UnityEngine;

public abstract class StoreBase : ScriptableObject
{

	public PlayerStoreDataBase Purchases;

	public abstract void MakePurchase();


}
