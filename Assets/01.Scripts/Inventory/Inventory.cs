using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>();

    public void AddItem(ItemData item)
    {
        items.Add(item);
        Debug.Log(item.itemName + " �߰���!");
        // UI ������Ʈ
        FindObjectOfType<InventoryUI>().UpdateInventoryUI();
    }

    public void RemoveItem(ItemData item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item.itemName + " ���ŵ�!");
        }
    }

    public void ShowInventory()
    {
        foreach (ItemData item in items)
        {
            Debug.Log(item.itemName + " - " + item.itemDescription);
        }
    }
}
