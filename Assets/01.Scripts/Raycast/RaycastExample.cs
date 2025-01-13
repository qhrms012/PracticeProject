using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    void Update()
    {
        // ���콺 ���� ��ư Ŭ�� �� ����
        if (Input.GetMouseButtonDown(0))
        {
            // ī�޶󿡼� ���콺 ��ġ�� Ray ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray�� ��� �浹 üũ
            if (Physics.Raycast(ray, out hit, 100f))
            {
                // �浹�� ��ü�� �̸� ���
                Debug.Log("Hit: " + hit.collider.gameObject.name);

                // �浹�� ��ü�� ������ ǥ��
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}

