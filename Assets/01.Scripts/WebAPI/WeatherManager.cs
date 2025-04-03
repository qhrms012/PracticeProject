using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherManager : MonoBehaviour
{
    private string apiKey = "a75716b1632c5d39960e4e5f8ca0500a";
    private string city = "Seoul";
    private string apiUrl = "https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";

    void Start()
    {
        StartCoroutine(GetWeatherData());
    }

    IEnumerator GetWeatherData()
    {
        string url = string.Format(apiUrl, city, apiKey);
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("날씨 데이터: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("에러 발생: " + request.error);
            }
        }
    }
}
