using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Func<int, int, int> add = (a, b) => a + b;
        //int result = add(3, 4);
        //Debug.Log(result);

        Predicate<int> isEven = (number) => number % 2 == 0;
        Debug.Log(isEven(4));
        Debug.Log(isEven(5));
        // 반환값이 항상 bool true 나 false
    }


}
