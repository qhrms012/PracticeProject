using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Transform itemParent; // UI�� �������� ��ġ�� �θ� ������Ʈ
    public GameObject itemSlotPrefab; // ������ ���� ������    
    private List<GameObject> itemSlots = new List<GameObject>();

    public void UpdateInventoryUI()
    {
        // ���� ���� ����
        foreach (GameObject slot in itemSlots)
        {
            Destroy(slot);
        }
        itemSlots.Clear();

        // ���ο� ���� ����
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

        // ��ư �߰� (������)
        Button dropButton = slot.GetComponentInChildren<Button>();
        dropButton.onClick.AddListener(() => FindObjectOfType<Inventory>().DropItem(item, new Vector3(0, 1, 0))); // �÷��̾� �տ� ����
    }

}
