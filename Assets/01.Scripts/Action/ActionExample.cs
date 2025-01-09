using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionExample
{
    public void Start()
    {
        Action sayHello = () => Console.WriteLine("Hello, Action!");
        sayHello(); // "Hello, Action!" ���

        Action<int> printNumber = (number) => Console.WriteLine($"Number: {number}");
        printNumber(5); // "Number: 5" ���
    }
}
