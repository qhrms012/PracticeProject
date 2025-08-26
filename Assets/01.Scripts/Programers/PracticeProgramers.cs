using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeProgramers : MonoBehaviour
{
    

    public void PracticeSTR()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        for (int i = 0; i < a; i++)
        {
            Console.Write(s1);
        }
    }
}
