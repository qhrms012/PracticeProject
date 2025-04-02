using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

public class WebAPIManagers : MonoBehaviour
{
    private string apiUrl = "https://jsonplaceholder.typicode.com/posts"; // 예제 API

    void Start()
    {
        StartCoroutine(SendDataToAPI());
    }

    IEnumerator SendDataToAPI()
    {
        string jsonData = "{\"title\":\"foo\",\"body\":\"bar\",\"userId\":1}";
        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonData);

        using (UnityWebRequest request = new UnityWebRequest(apiUrl, "POST"))
        {
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("서버 응답: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("에러 발생: " + request.error);
            }
        }
    }
}
