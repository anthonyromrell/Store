using UnityEngine;
using UnityEngine.UI;

//Made By Anthony Romrell
public class StorePurchaseButton : MonoBehaviour, IPurchase
{
    public Purchaseable Item;
    public Store ItemStore;

    public Button PurchaceButton;
    public StoreGameAction StoreAction;

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