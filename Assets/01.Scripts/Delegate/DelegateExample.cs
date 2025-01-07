using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // 델리게이트 정의
    public delegate void OnPlayerDamage(int damage);
    public static event OnPlayerDamage PlayerDamagedEvent;

    private void Start()
    {
        // 델리게이트 메서드 등록
        PlayerDamagedEvent += ShowDamageText;
        PlayerDamagedEvent += PlayDamageSound;
    }

    public void InDamage()
    {
        PlayerDamagedEvent?.Invoke(20);
    }
    void ShowDamageText(int damage)
    {
        Debug.Log($"플레이어가 {damage}의 피해를 입었습니다.");
    }

    void PlayDamageSound(int damage)
    {
        Debug.Log("데미지 사운드");
    }
}
