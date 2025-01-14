using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponData weaponData;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Weapon: {weaponData.weaponName}, Damage: {weaponData.damage}");
    }
}
