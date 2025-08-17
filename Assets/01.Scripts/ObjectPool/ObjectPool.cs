using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PoolKey
{
    Bullet,
    Enemy

}


public class ObjectPool : MonoBehaviour
{

    [System.Serializable]
    public class Pool
    {
        public PoolKey key;
        public GameObject preFabs;
    }

    public Pool[] poolsConfig;

    private Dictionary<PoolKey, List<GameObject>> poolDict;

    private void Awake()
    {
        poolDict = new Dictionary<PoolKey, List<GameObject>>();

        foreach (var pool in poolsConfig)
        {
            poolDict[pool.key] = new List<GameObject>();
        }
    }

    public GameObject Get(PoolKey key)
    {
        var list = poolDict[key];
        GameObject select = null;

        foreach (GameObject item in list)
        {
            if (!item.activeSelf)
            {
                select = item;
                select.SetActive(true);
                return select;
            }
        }

        var prefab = System.Array.Find(poolsConfig, p => p.key == key).preFabs;
        select = Instantiate(prefab, transform);
        list.Add(select);


        return select;
    }


}
