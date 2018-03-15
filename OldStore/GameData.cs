using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class GameData : SaveData
{
    public const string PlayerPrefsIdentifier = "GameData";

    public Store MyStore;

    private static GameData _instance;
    public static GameData Instance
    {
        get
        {
            if (_instance == null)
            {
                GameData.GetPlayerPrefs();
            }
            return _instance;
        }
    }

    public static void GetPlayerPrefs()
    {
        if (string.IsNullOrEmpty(PlayerPrefs.GetString(PlayerPrefsIdentifier)))
        {
            _instance = ScriptableObject.CreateInstance<GameData>();
        } else
        {
            _instance = JsonUtility.FromJson<GameData>(PlayerPrefs.GetString(PlayerPrefsIdentifier));
        }
    }

    public static void SetPlayerPrefs()
    {
        PlayerPrefs.SetString(PlayerPrefsIdentifier, JsonUtility.ToJson(_instance));
    }
    public void SaveData()
    {
        string gameDataAsJson = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(PlayerPrefsIdentifier, gameDataAsJson);
    }
}

public abstract class SaveData: ScriptableObject
{
    
}