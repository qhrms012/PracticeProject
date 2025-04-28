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
        login.text = "Google�� �α��� ��...";
        PlayGamesPlatform.Instance.Authenticate(SignInInteractivity.CanPromptOnce, ProcessAuthentication);
    }

    private void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            string serverAuthCode = PlayGamesPlatform.Instance.GetServerAuthCode();
            Debug.Log("Google �α��� ����. ServerAuthCode: " + serverAuthCode);

            if (string.IsNullOrEmpty(serverAuthCode))
            {
                Debug.LogError("ServerAuthCode�� null�̰ų� ����ֽ��ϴ�.");
                return;
            }
        }
        else
        {
            Debug.LogError("Google �α��� ����: " + status);
        }
    }

}
