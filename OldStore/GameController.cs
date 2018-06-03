using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        //	print(GameData.Instance.purchases.Count);
        //StaticVars.gameData.GetPlayerPrefs();
    }

    private void OnDestroy()
    {
        //GameData.Instance.purchases = null;
        //GameData.SetPlayerPrefs();
        //StaticVars.gameData.purchases = null;
        //StaticVars.gameData.SetPlayerPrefs();
    }
}