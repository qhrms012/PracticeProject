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

        string json = JsonUtility.ToJson(data, true); // true: ���� ���� ������
        File.WriteAllText(filePath, json);

        Debug.Log("���� �Ϸ�: " + filePath);
    }

    public void LoadData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            Debug.Log($"�ҷ����� �Ϸ� - �̸�: {data.playerName}, ����: {data.level}, ü��: {data.health}");
        }
        else
        {
            Debug.LogWarning("����� ������ �����ϴ�!");
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
