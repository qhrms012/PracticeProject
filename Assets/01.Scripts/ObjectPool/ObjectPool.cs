using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public GameObject[] prefabs;
    public int poolSize = 10;

    private Queue<GameObject> pool = new Queue<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // �� �����տ� ���� poolSize��ŭ ����
        foreach (GameObject prefab in prefabs)
        {
            for (int i = 0; i < poolSize; i++)
            {
                GameObject obj = Instantiate(prefab);
                obj.SetActive(false);
                pool.Enqueue(obj);
            }
        }
        //for (int i = 0; i < poolSize; i++)
        //{
        //    // `prefabs` �迭���� �������� ������ ����
        //    GameObject prefabToUse = prefabs[i % prefabs.Length];           
        //    GameObject obj = Instantiate(prefabToUse);

        //    obj.SetActive(false);
        //    pool.Enqueue(obj);
        //}

        GetFromPool();
    }

    public GameObject GetFromPool()
    {
        if (pool.Count > 0)
        {
            GameObject obj = pool.Dequeue();
            obj.SetActive(true);
            return obj;
        }
        return null;
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }
}
