using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum Grade
{
    Normal,
    Rare,
    Epic,
    LegenDary
}


[CreateAssetMenu(fileName = "BulletData", menuName = "Bullet/BulletData")]

public class BulletData : ScriptableObject
{
    public Grade Grade;
    public string name;
    public float curDamage;
    public float increseDamage;
    public float speed;


    
}
