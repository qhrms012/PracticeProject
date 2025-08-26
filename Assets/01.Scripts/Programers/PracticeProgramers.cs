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

    public void Practice181949()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                Console.Write(char.ToLower(c));
            }
            else
            {
                Console.Write(char.ToUpper(c));
            }
        }
    }

    public void Practice181948()
    {
        Console.Write("!@#$%^&*(\\'\"<>?:;");
    }

    public void Practice181947()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
        int c = a + b;
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public void Practice181946()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];

        Console.Write($"{s1}{s2}");
    }

    public void Practice181945()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach (char c in s)
        {
            Console.WriteLine(c);
        }
    }

    public void Practice181944()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);

        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even");
        }
        else
        {
            Console.WriteLine($"{a} is odd");
        }
    }
}
