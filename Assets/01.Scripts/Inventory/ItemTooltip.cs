using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour
{
    public GameObject tooltipPanel; // ���� �г�
    public TextMeshProUGUI tooltipText; // ���� �ؽ�Ʈ

    private void Start()
    {
        tooltipPanel.SetActive(false); // ���� �� ��Ȱ��ȭ
    }

    private void Update()
    {
        if (tooltipPanel.activeSelf)
        {
            tooltipPanel.transform.position = Input.mousePosition + new Vector3(10, -10, 0);
        }
    }

    public void ShowTooltip(string description)
    {
        tooltipText.text = description;
        tooltipPanel.SetActive(true);
    }

    public void HideTooltip()
    {
        tooltipPanel.SetActive(false);
    }
}
