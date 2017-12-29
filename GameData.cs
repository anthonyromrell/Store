using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class GameData
{
    GameData () {

    }

    public bool hasKey = false;
    public const string playerPrefsIdentifier = "GameData";
    public string playerName;
    public int totalScore;
    public int lives;
    public float health;
    public int gold;
    public Vector3 checkPoint;
    public List<string> purchases;
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
        if (string.IsNullOrEmpty(PlayerPrefs.GetString(playerPrefsIdentifier)))
        {
            _instance = new GameData();
        } else
        {
            _instance = JsonUtility.FromJson<GameData>(PlayerPrefs.GetString(playerPrefsIdentifier));
        }
    }

    public static void SetPlayerPrefs()
    {
        PlayerPrefs.SetString(playerPrefsIdentifier, JsonUtility.ToJson(_instance));
    }
    public void SaveData()
    {
        string gameDataAsJson = JsonUtility.ToJson(this);
        PlayerPrefs.SetString(playerPrefsIdentifier, gameDataAsJson);
    }
}