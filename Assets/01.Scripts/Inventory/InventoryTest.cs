using UnityEngine;

public class InventoryTest : MonoBehaviour
{
    public Inventory inventory;
    public InventoryUI inventoryUI;
    public ItemData testItem; // 임시 아이템

    void Start()
    {
        inventory.AddItem(testItem);
        inventoryUI.UpdateInventoryUI();
    }
}
