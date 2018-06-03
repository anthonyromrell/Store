using UnityEngine;

[CreateAssetMenu(fileName = "Purchaseble", menuName = "Store/Item")]
public class Purchaseable : ScriptableObject
{
    public int Price;
    public GameObject PurchacedObject;
    public bool Purchased;
}

public interface IPurchase
{
}