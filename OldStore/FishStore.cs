using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FishStore : Store {

	public bool HasKey = false;
    public string PlayerName;
    public int TotalScore;
    public int Lives;
    public float Health;
	public Vector3 CheckPoint;
}
