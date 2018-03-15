using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Store : ScriptableObject {
    public int Gold;
    public List<PurchaseableBase> Purchases;
}
