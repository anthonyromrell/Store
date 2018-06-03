using UnityEngine;

[CreateAssetMenu(fileName = "StoreGameAction", menuName = "Store/Action")]
public class StoreGameAction : GameAction
{
    public void ActionCall(Purchaseable obj)
    {
        Call(obj);
    }
}