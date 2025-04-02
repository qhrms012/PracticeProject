using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

public class WebAPIManagers : MonoBehaviour
{
    private string apiUrl = "https://jsonplaceholder.typicode.com/posts"; // ���� API

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
                Debug.Log("���� ����: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("���� �߻�: " + request.error);
            }
        }
    }
}
