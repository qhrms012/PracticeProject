using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemTooltip : MonoBehaviour
{
    public GameObject tooltipPanel; // 툴팁 패널
    public TextMeshProUGUI tooltipText; // 툴팁 텍스트

    private void Start()
    {
        tooltipPanel.SetActive(false); // 시작 시 비활성화
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
