using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemData itemData; // ������ ������ ����
    private ItemTooltip tooltip; // ���� ����

    private void Start()
    {
        tooltip = FindObjectOfType<ItemTooltip>();
    }

    private void OnMouseEnter()
    {
        if (tooltip != null)
        {
            tooltip.ShowTooltip(itemData.itemDescription);
        }
    }

    private void OnMouseExit()
    {
        if (tooltip != null)
        {
            tooltip.HideTooltip();
        }
    }
    private void OnMouseDown()
    {
        Inventory inventory = FindObjectOfType<Inventory>(); // ������ �κ��丮 ã��
        if (inventory != null)
        {
            inventory.AddItem(itemData); // �κ��丮�� �߰�
            Debug.Log(itemData.itemName + " ȹ��!");
            Destroy(gameObject); // ������ ������Ʈ ����
        }
    }
}
