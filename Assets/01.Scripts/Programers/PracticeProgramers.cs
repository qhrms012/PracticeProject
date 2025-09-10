using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

    public void Practice181943(string my_string, string overwrite_string, int s)
    {
        string answer = "";

        string front = my_string.Substring(0, s);
        string back = my_string.Substring(s + overwrite_string.Length);

        answer = front + overwrite_string + back;
        
    }

    public void Practice181941(string[] arr)
    {
        string answer = "";

        for (int i = 0; i < arr.Length; i++)
            answer += arr[i];

        
    }

    public void Practice181940(string my_string, int k)
    {
        string answer = "";

        for (int i = 0; i < k; i++)
            answer += my_string;        
    }

    public void Practice181939(int a, int b)
    {
        int answer = 0;

        string c = a.ToString() + b.ToString();
        string d = b.ToString() + a.ToString();

        int e = int.Parse(c);
        int f = int.Parse(d);

        if(e > f)
        {
            answer = e;
        }
        else
        {
            answer = f;
        }

    }

    public void Practice12931(int n)
    {
        int answer = 0;

        foreach (char c in n.ToString())
            answer += c - '0';

    }

    public void Practice12932(long n)
    {
        int len = n.ToString().Length;

        int[] answer = new int[len];
        int index = 0;

        foreach (char c in n.ToString())
        {
            answer[index] = c - '0';
            index++;
        }

        Array.Reverse(answer);


    }


    public void Practice12937(int num)
    {
       //return (num % 2 == 0) ? "Even" : "Odd";
    }

    public void Practice12944(int[] arr)
    {
        int count = arr.Length;
        int sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += arr[i];
        }
        

        double output = (double)sum / count;
        //Math.Round(output,2);

    }

    public void Practice12954(int x, int n)
    {
        long[] answer = new long[n];
        for (int i = 0; i < n; i++)
        {
            answer[i] = (long)x * (i + 1);
        }
    }

    public void Practice87389(int n)
    {
        int answer = 1;

        while (answer < n)
        {
            if (n % answer == 1)
                break;
            answer++;
        }

    }

    public void Practice12925(string s)
    {
        int answer = 0;

        answer = int.Parse(s);
    }

    public void Practice12928(int n)
    {
        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                answer += i;
        }
    }
}
