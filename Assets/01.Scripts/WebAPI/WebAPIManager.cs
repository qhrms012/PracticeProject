using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class WebAPIManager : MonoBehaviour
{
    private string apiUrl = "https://jsonplaceholder.typicode.com/posts/1"; // ���� API

    void Start()
    {
        StartCoroutine(GetDataFromAPI());
    }

    IEnumerator GetDataFromAPI()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("������ ����: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("���� �߻�: " + request.error);
            }
        }
    }
}
