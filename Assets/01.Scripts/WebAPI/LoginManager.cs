using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public TextMeshProUGUI login;


    private void Awake()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
            //.RequestIdToken()
            //.RequestServerAuthCode(false) 
            .Build();

        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();
    }
    public void OnGoogleLoginButtonClicked()
    {
        login.text = "Google로 로그인 중...";
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, ProcessAuthentication);
    }

    private void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            string serverAuthCode = PlayGamesPlatform.Instance.GetServerAuthCode();
            Debug.Log("Google 로그인 성공. ServerAuthCode: " + serverAuthCode);

            if (string.IsNullOrEmpty(serverAuthCode))
            {
                Debug.LogError("ServerAuthCode가 null이거나 비어있습니다.");
                return;
            }
        }
        else
        {
            Debug.LogError("Google 로그인 실패: " + status);
        }
    }

}
