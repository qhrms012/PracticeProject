using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemData itemData; // 아이템 데이터 연결

    private void OnMouseDown()
    {
        Inventory inventory = FindObjectOfType<Inventory>(); // 씬에서 인벤토리 찾기
        if (inventory != null)
        {
            inventory.AddItem(itemData); // 인벤토리에 추가
            Debug.Log(itemData.itemName + " 획득!");
            Destroy(gameObject); // 아이템 오브젝트 삭제
        }
    }
}
