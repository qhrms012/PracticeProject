using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{
    private string filePath;

    private void Awake()
    {
        filePath = Path.Combine(Application.persistentDataPath, "playerData.json");
    }

    public void SaveData()
    {
        PlayerData data = new PlayerData
        {
            playerName = "Player1",
            level = 5,
            health = 98.5f
        };

        string json = JsonUtility.ToJson(data, true); // true: 보기 좋게 포맷팅
        File.WriteAllText(filePath, json);

        Debug.Log("저장 완료: " + filePath);
    }

    public void LoadData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log($"불러오기 완료 - 이름: {data.playerName}, 레벨: {data.level}, 체력: {data.health}");
        }
        else
        {
            Debug.LogWarning("저장된 파일이 없습니다!");
        }
    }
}



[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int level;
    public float health;
}
