using UnityEngine;

public class PerformanceTest : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < 10000; i++)
        {
            Mathf.Sqrt(i); // 연산 부담을 주기 위한 코드
        }
    }
}
