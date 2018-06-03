using System.Collections.Generic;
using UnityEngine;

//Made By Anthony Romrell
public class StoreObjects : MonoBehaviour
{
    public StoreGameAction AddButtons;
    public Store ItemStore;

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