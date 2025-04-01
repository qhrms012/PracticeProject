using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Transform itemParent; // UI에 아이템을 배치할 부모 오브젝트
    public GameObject itemSlotPrefab; // 아이템 슬롯 프리팹    
    private List<GameObject> itemSlots = new List<GameObject>();

    public void UpdateInventoryUI()
    {
        // 기존 슬롯 삭제
        foreach (GameObject slot in itemSlots)
        {
            Destroy(slot);
        }
        itemSlots.Clear();

        // 새로운 슬롯 생성
        foreach (ItemData item in inventory.items)
        {
            GameObject slot = Instantiate(itemSlotPrefab, itemParent);
            slot.GetComponentInChildren<TextMeshProUGUI>().text = item.itemName;
            slot.GetComponentInChildren<Image>().sprite = item.itemIcon;
            itemSlots.Add(slot);
        }
    }
    public void CreateInventorySlot(ItemData item)
    {
        GameObject slot = Instantiate(itemSlotPrefab, itemParent);
        slot.GetComponentInChildren<TextMeshProUGUI>().text = item.itemName;
        slot.GetComponentInChildren<Image>().sprite = item.itemIcon;

        // 버튼 추가 (버리기)
        Button dropButton = slot.GetComponentInChildren<Button>();
        dropButton.onClick.AddListener(() => FindObjectOfType<Inventory>().DropItem(item, new Vector3(0, 1, 0))); // 플레이어 앞에 버림
    }

}
