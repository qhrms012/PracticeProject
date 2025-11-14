using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        if (e > f)
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

    public void Practice12933(long n)
    {
        long answer = 0;
        char[] a = n.ToString().ToCharArray();
        Array.Sort(a);
        Array.Reverse(a);
        answer = long.Parse(a);
    }

    public void Practice12912(int a, int b)
    {
        long answer = 0;
        long min = Math.Min(a, b);
        long max = Math.Max(a, b);
        long count = max - min + 1;
        answer = (max + min) * count / 2;
    }


    public void Practice12934(long n)
    {
        long r = (long)Math.Sqrt(n);
        if (r * r == n)
        {
            //return (r + 1) * (r + 1);
        }
        //return -1;
    }

    public void Pratice12947(int x)
    {
        bool answer = true;

        int count = 0;

        foreach (char c in x.ToString())
            count += int.Parse(c.ToString());

        answer = (x % count == 0) ? answer = true : answer = false;

        //return answer;
    }

    public void Practice76501(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            if (signs[i] == true)
            {
                answer += absolutes[i];
            }
            else
            {
                answer -= absolutes[i];
            }
        }

        //return answer;
    }

    public void Practice86051(int[] numbers)
    {
        bool[] exist = new bool[10];

        foreach (int num in numbers)
        {
            exist[num] = true;
        }

        int answer = 0;

        for (int i = 0; i < 10; i++)
        {
            if (!exist[i])
            {
                answer += i;
            }
        }



        //return answer;
    }

    public void Practice12910(int[] arr, int divisor)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
                list.Add(arr[i]);
        }

        if (list.Count == 0)
            list.Add(-1);
        else
            list.Sort();

        //return list.ToArray();
    }

    public void Practice12919(string[] seoul)
    {
        string answer = "";
        int count = 0;
        foreach (string s in seoul)
        {
            if (s == "Kim")
                break;
            count++;
        }

        answer = $"김서방은 {count}에 있다";



        // return answer;
    }

    public void Practice12943(int num)
    {
        int answer = 0;
        long a = num;

        while (a > 1 && answer < 500)
        {
            if (a % 2 == 0)
                a = a / 2;
            else
                a = a * 3 + 1;
            answer++;
        }
        if (answer >= 500)
            answer = -1;

        // return answer;
    }

    public void Practice12948(string phone_number)
    {
        string answer = "";

        int a = phone_number.Length;
        string last4 = phone_number.Substring(a - 4);

        answer = new string('*', a - 4) + last4;

        //return answer;
    }

    public void Practice12903(string s)
    {
        string answer = "";
        int a = s.Length;
        if (a % 2 != 0)
        {
            answer = s.Substring(a / 2, 1);
        }
        else
        {
            answer = s.Substring((a - 2) / 2, 2);
        }
        // return answer;
    }

    public void Practice12935(int[] arr)
    {
        if (arr.Length == 1)
        {

        }
        //return new int[] { -1 };

        int min = arr.Min();
        int[] answer = new int[arr.Length - 1];

        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == min) continue;
            answer[index++] = arr[i];
        }

        //return answer;
    }

    public void Practice70128(int[] a, int[] b)
    {
        int answer = 0;

        for (int i = 0; i < a.Length; i++)
        {
            answer += a[i] * b[i];
        }


        //return answer;
    }

    public void Practice12922(int n)
    {
        string answer = "";
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                answer += "박";
            else
                answer += "수";
        }

        //return answer;
    }

    public void Practice77884(int left, int right)
    {
        int answer = 0;


        for (int i = left; i <= right; i++)
        {
            int a = (int)Math.Sqrt(i);
            if (a * a == i)
                answer -= i;
            else
                answer += i;
        }

        //return answer;
    }

    public void Practice12917(string s)
    {
        string answer = "";
        char[] chr = s.ToArray();

        Array.Sort(chr);
        Array.Reverse(chr);

        answer = new string(chr);
        //return answer;
    }

    public void Practice82612(int price, int money, int count)
    {
        long answer = 0;

        long total = (long)price * count * (count + 1) / 2;
        //return total > money ? total - money : 0;
    }

    public void Practice12918(string s)
    {
        bool answer = false;

        if (s.Length == 4 || s.Length == 6)
        {
            answer = Regex.IsMatch(s, @"^\d+$");
        }

        //return answer;
    }

    public void Practice12950(int[,] arr1, int[,] arr2)
    {
        int row = arr1.GetLength(0);
        int col = arr1.GetLength(1);

        int[,] answer = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }

        // return answer;
    }

    public void Practice12969()
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        string stars = new string('*', a);

        for (int i = 0; i < b; i++)
        {
            Console.WriteLine(stars);
        }
    }
    public int[] Practice12940(int n, int m)
    {

        int[] answer = new int[2];
        answer[0] = GetGCD(n, m);
        answer[1] = GetLCM(n, m);



        return answer;
    }

    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        return a;

    }
    static int GetLCM(int a, int b)
    {
        return a * b / GetGCD(a, b);
    }

    public void Practice147355(string s, string p)
    {
        int answer = 0;

        for (int i = 0; i + p.Length <= t.Length; i++)
        {
            string sub = t.Substring(i, p.Length);

            if (sub.Length == p.Length && long.Parse(sub) <= long.Parse(p))
                answer++;
        }


        //return answer;
    }

    public void Practice12982(int[] d, int budget)
    {
        int answer = 0;
        Array.Sort(d);
        int sum = 0;

        foreach (int cost in d)
        {
            sum += cost;
            if (sum > budget)
                break;
            answer++;
        }
        // return answer;

    }
    public void Practice68935(int n)
    {
        int answer = 0;
        string reversed = "";

        while (n > 0)
        {
            reversed += (n % 3).ToString();
            n /= 3;
        }

        int power = 1;

        for (int i = reversed.Length - 1; i >= 0; i--)
        {
            answer += (reversed[i] - '0') * power;
            power *= 3;
        }

        //return answer;
    }

    public void Practice131705(int[] number)
    {
        int answer = 0;

        for (int i = 0; i < number.Length - 2; i++)
        {
            for (int j = i + 1; j < number.Length - 1; j++)
            {
                for (int k = j + 1; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        answer++;
                    }
                }
            }
        }

        //return answer;
    }

    public void Practice12930(string s)
    {
        string answer = "";
        string[] wordArray = s.Split(' ');

        for (int i = 0; i < wordArray.Length; i++)
        {
            string word = wordArray[i];
            string newWord = "";

            for (int j = 0; j < word.Length; j++)
            {
                if (j % 2 == 0)
                    newWord += char.ToUpper(word[j]);
                else
                    newWord += char.ToLower(word[j]);
            }

            wordArray[i] = newWord;
        }

        answer = string.Join(" ", wordArray);

        //return answer;
    }

    public void Practice86491(int[,] sizes)
    {
        int maxWidth = 0;
        int maxHeight = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int w = sizes[i, 0];
            int h = sizes[i, 1];

            if (w < h)
            {
                int temp = w;
                w = h;
                h = temp;
            }

            if (w > maxWidth) maxWidth = w;
            if (h > maxHeight) maxHeight = h;
        }

        // return maxWidth * maxHeight;
    }

    public void Practice142086(string s)
    {
        int[] answer = new int[s.Length];
        Dictionary<char, int> lastIndex = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (lastIndex.ContainsKey(c))
            {
                answer[i] = i - lastIndex[c];
                lastIndex[c] = i;
            }
            else
            {
                answer[i] = -1;
                lastIndex[c] = i;
            }
        }

        //return answer;
    }

    public void Practice12926(string s, int n)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                sb.Append((char)('a' + (c - 'a' + n) % 26));
            }
            else if (char.IsUpper(c))
            {
                sb.Append((char)('A' + (c - 'A' + n) % 26));
            }
            else
            {
                sb.Append(c);
            }
        }

        //return sb.ToString();
    }

    public void Practice68644(int[] numbers)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];

                if (!list.Contains(sum))
                    list.Add(sum);
            }
        }

        list.Sort();
        //return list.ToArray();
    }

    public void Practice134240(int[] food)
    {
        string left = "";

        for (int i = 1; i < food.Length; i++)
        {
            int count = food[i] / 2;
            for (int j = 0; j < count; j++)
            {
                left += i;
            }
        }

        string right = new string(left.Reverse().ToArray());
        string answer = left + "0" + right;

        //return answer;
    }

    public void Practice81301(string s)
    {
        int answer = 0;

        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < words.Length; i++)
        {
            s = s.Replace(words[i], i.ToString());
        }
        answer = int.Parse(s);
        //return answer;
    }

    public void Practice42748(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int a = commands[i, 0];
            int b = commands[i, 1];
            int c = commands[i, 2];

            var sliced = array.Skip(a - 1).Take(b - a + 1).ToArray();

            Array.Sort(sliced);

            answer[i] = sliced[c - 1];
        }

        //return answer;
    }

    public void Practice132267(int a, int b, int n)
    {
        int answer = 0;

        while (n >= a)
        {
            int newCola = (n / a) * b;
            answer += newCola;
            n = newCola + (n % a);
        }

        //return answer;
    }

    public void Practice12915(string[] strings, int n)
    {
        Array.Sort(strings, (a, b) =>
        {
            if (a[n] == b[n])
                return a.CompareTo(b);
            else
                return a[n].CompareTo(b[n]);
        });

        //return strings;
    }

    public void Practice138477(int k, int[] score)
    {
        List<int> list = new List<int>();
        List<int> answer = new List<int>();

        foreach (int s in score)
        {
            list.Add(s);
            list.Sort();
            list.Reverse();

            if (list.Count < k)
                answer.Add(list[list.Count - 1]);
            else
                answer.Add(list[k - 1]);
        }

        //return answer.ToArray();
    }

    public void Practice120807(int num1, int num2)
    {
        //return num1 == num2 ? 1 : -1;
    }

    public void Practice120820(int age)
    {
        int answer = 2022 + 1;

        answer -= age;

        //return answer;
    }

    public void Practice120806(int num1, int num2)
    {
        int answer = 0;

        answer = (int)((double)num1 / num2 * 1000);

        //return answer;
    }

    public void Practice120829(int angle)
    {
        int answer = 0;

        if (angle < 90) answer = 1;
        else if (angle == 90) answer = 2;
        else if (angle < 180) answer = 3;
        else if (angle == 180) answer = 4;

        //return answer;
    }
}
