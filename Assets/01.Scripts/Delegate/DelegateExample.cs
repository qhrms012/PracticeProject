using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // ��������Ʈ ����
    public delegate void OnPlayerDamage(int damage);
    public static event OnPlayerDamage PlayerDamagedEvent;

    private void Start()
    {
        // ��������Ʈ �޼��� ���
        PlayerDamagedEvent += ShowDamageText;
        PlayerDamagedEvent += PlayDamageSound;
    }

    public void InDamage()
    {
        PlayerDamagedEvent?.Invoke(20);
    }
    void ShowDamageText(int damage)
    {
        Debug.Log($"�÷��̾ {damage}�� ���ظ� �Ծ����ϴ�.");
    }

    void PlayDamageSound(int damage)
    {
        Debug.Log("������ ����");
    }
}
