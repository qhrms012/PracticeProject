using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 시 실행
        if (Input.GetMouseButtonDown(0))
        {
            // 카메라에서 마우스 위치로 Ray 생성
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray를 쏘고 충돌 체크
            if (Physics.Raycast(ray, out hit, 100f))
            {
                // 충돌한 객체의 이름 출력
                Debug.Log("Hit: " + hit.collider.gameObject.name);

                // 충돌한 객체에 빨간색 표시
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}

