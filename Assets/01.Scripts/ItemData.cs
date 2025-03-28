using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/ItemData")]

public class ItemData : ScriptableObject 
{
    public enum ItemType
    {
        Melee,
        Range,
        Heal
    }
    [Header("Main Info")]
    public ItemType Type;
    public int itemId;
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;

    [Header("Level Data")]
    public float baseDamage;
    public float[] damages;

    [Header("Weapon")]
    public GameObject projectile;
}
