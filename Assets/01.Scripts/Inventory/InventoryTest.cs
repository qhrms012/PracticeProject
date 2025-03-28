using UnityEngine;

public class InventoryTest : MonoBehaviour
{
    public Inventory inventory;
    public InventoryUI inventoryUI;
    public ItemData testItem; // �ӽ� ������

    void Start()
    {
        inventory.AddItem(testItem);
        inventoryUI.UpdateInventoryUI();
    }
}
