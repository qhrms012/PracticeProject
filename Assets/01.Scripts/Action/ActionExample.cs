using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionExample : MonoBehaviour
{
    public void Start()
    {
        Action sayHello = () => Debug.Log("Hello, Action!");
        sayHello(); // "Hello, Action!" ���

        Action<int> printNumber = (number) => Debug.Log($"Number: {number}");
        printNumber(5); // "Number: 5" ���

    }
}
