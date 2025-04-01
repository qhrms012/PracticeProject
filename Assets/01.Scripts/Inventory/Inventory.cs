using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemData> items = new List<ItemData>();

    public void AddItem(ItemData item)
    {
        items.Add(item);
        Debug.Log(item.itemName + " 추가됨!");
        // UI 업데이트
        FindObjectOfType<InventoryUI>().UpdateInventoryUI();
    }

    public void RemoveItem(ItemData item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item.itemName + " 제거됨!");
        }
    }
    public void DropItem(ItemData item, Vector3 dropPosition)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item.itemName + " 버림!");

            // 아이템 오브젝트 생성
            GameObject droppedItem = Instantiate(Resources.Load<GameObject>("DroppedItemPrefab"), dropPosition, Quaternion.identity);
            droppedItem.GetComponent<ItemPickup>().itemData = item;

            // UI 업데이트
            FindObjectOfType<InventoryUI>().UpdateInventoryUI();
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
