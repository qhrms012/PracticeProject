using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.Networking;

public class CryptoManager : MonoBehaviour
{

    private string apiUrl = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CryptoPrice());
    }

    IEnumerator CryptoPrice()
    {
        using(UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if(request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("BitCoin Price :" + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("에러 발생" + request.error);
            }
        }
    }
}
