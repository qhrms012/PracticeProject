using UnityEngine;

public class PerformanceTest : MonoBehaviour
{
    void Update()
    {
        for (int i = 0; i < 10000; i++)
        {
            Mathf.Sqrt(i); // ���� �δ��� �ֱ� ���� �ڵ�
        }
    }
}
