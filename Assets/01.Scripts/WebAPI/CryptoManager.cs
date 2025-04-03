using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System;

[Serializable]
public class CryptoData
{
    public float usd;
}

[Serializable]
public class CryptoResponse
{
    public CryptoData bitcoin;
}

public class CryptoManager : MonoBehaviour
{
    private string apiUrl = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd";

    void Start()
    {
        StartCoroutine(CryptoPrice());
    }

    IEnumerator CryptoPrice()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;
                CryptoResponse response = JsonUtility.FromJson<CryptoResponse>(json);
                Debug.Log("BitCoin Price: " + response.bitcoin.usd + " USD");
            }
            else
            {
                Debug.LogError("에러 발생: " + request.error);
            }
        }
    }
}

