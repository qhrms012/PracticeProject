using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemData itemData; // ������ ������ ����

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
