using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class WebAPIManager : MonoBehaviour
{
    private string apiUrl = "https://jsonplaceholder.typicode.com/posts/1"; // 예제 API

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
                Debug.Log("데이터 받음: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("에러 발생: " + request.error);
            }
        }
    }
}
