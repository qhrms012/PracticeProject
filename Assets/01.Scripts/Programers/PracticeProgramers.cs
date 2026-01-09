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

    public void Practice120830(int n, int k)
    {
        int answer = 0;



        //return answer = (n * 12000) + (k * 2000) - ((n / 10) * 2000);
    }

    public void Practice120831(int n)
    {
        int answer = 0;
        int count = n / 2;
        int a = 0;

        for (int i = 0; i < count; i++)
        {
            a += 2;
            answer += a;
        }



        //return answer;
    }

    public void Practice120817(int[] numbers)
    {
        double answer = 0;

        answer = numbers.Average();


        //return answer;
    }

    public void Practice120821(int[] num_list)
    {

        Array.Reverse(num_list);

        //return num_list;
    }

    public void Practice120822(string my_string)
    {
        string answer = new string(my_string.Reverse().ToArray());

        //return answer;
    }

    public void Practice120898(string message)
    {
        int answer = message.Length * 2;



        //return answer;
    }

    public void Practice120814(int n)
    {
        //if (n % 7 == 0) //return n / 7;
        //return n / 7 + 1;
    }
    public int Practice120910(int n, int t)
    {
        return n * (int)Math.Pow(2, t);
    }

    public int Practice120847(int[] numbers)
    {
        Array.Sort(numbers);
        int answer = numbers[numbers.Length - 2] * numbers[numbers.Length - 1];

        return answer;
    }

    public int Practice120585(int[] array, int height)
    {
        int answer = 0;
        foreach (int number in array)
        {
            if (number > height)
            {
                answer++;
            }
        }
        return answer;
    }

    public int Practice120889(int[] sides)
    {
        int max = sides.Max();
        int sum = sides.Sum() - max;

        return sum > max ? 1 : 2;
    }

    public int[] Practice120833(int[] numbers, int num1, int num2)
    {
        int length = num2 - num1 + 1;
        int[] answer = new int[length];
        Array.Copy(numbers, num1, answer, 0, length);

        return answer;
    }

    public int Practice120816(int slice, int n)
    {
        if (n % slice == 0)
            return n / slice;

        return n / slice + 1;
    }

    public int Practice120841(int[] dot)
    {
        int answer = 0;
        int x = dot[0];
        int y = dot[1];

        answer =
            (x > 0 && y > 0) ? 1 :
            (x < 0 && y > 0) ? 2 :
            (x < 0 && y < 0) ? 3 : 4;

        return answer;
    }

    public int Practice120903(string[] s1, string[] s2)
    {
        int answer = 0;

        foreach (string s in s2)
        {
            if (s1.Contains(s))
                answer++;
        }

        return answer;
    }

    public int Practice120836(int n)
    {
        return Enumerable.Range(1, n).Count(i => n % i == 0);
    }

    public int[] Practice120905(int n, int[] numlist)
    {
        List<int> answer = new List<int>();

        foreach (int num in numlist)
        {
            if (num % n == 0)
                answer.Add(num);
        }

        return answer.ToArray();
    }

    public int[] Practice120854(string[] strlist)
    {
        List<int> answer = new List<int>();

        for (int i = 0; i < strlist.Length; i++)
        {
            answer.Add(strlist[i].Length);
        }


        return answer.ToArray();
    }

    public int[] Practice120819(int money)
    {
        List<int> answer = new List<int>();
        int pay = 5500;
        answer.Add(money / pay);
        answer.Add(money % pay);


        return answer.ToArray();
    }

    public int Practice120908(string str1, string str2)
    {
        return str1.Contains(str2) ? 1 : 2;
    }

    public string Practice120825(string my_string, int n)
    {
        string answer = "";

        for (int i = 0; i < my_string.Length; i++)
        {
            for (int j = 0; j < n; j++)
                answer += my_string[i];
        }


        return answer;
    }

    public int Practice120909(int n)
    {
        int answer = 0;
        answer = Math.Sqrt(n) % 1 == 0 ? 1 : 2;

        return answer;
    }

    public string Practice120826(string my_string, string letter)
    {
        string answer = "";
        foreach (char c in my_string)
        {
            if (c.ToString() != letter)
            {
                answer += c;
            }
        }
        return answer;
    }

    public string Practice120849(string my_string)
    {
        string answer = "";
        string cut = "aeiou";

        foreach (char c in my_string)
        {
            if (!cut.Contains(c))
                answer += c;
        }
        return answer;
    }

    public int[] Practice120824(int[] num_list)
    {
        int[] answer = new int[2];
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0) answer[0]++;
            else answer[1]++;
        }
        return answer;
    }

    public int Practice120906(int n)
    {
        int answer = 0;
        string a = n.ToString();

        foreach (var v in a)
        {
            answer += int.Parse(v.ToString());
        }

        return answer;
    }

    public int Practice181933(int a, int b, bool flag)
    {
        int answer = 0;
        if (flag)
            answer = a + b;
        else
            answer = a + -b;

        return answer;
    }

    public string Practice181907(string my_string, int n)
    {
        return my_string.Substring(0, n);
    }

    public string Practice181910(string my_string, int n)
    {
        int count = my_string.Length - n;
        return my_string.Substring(count);
    }

    public int Practice181896(int[] num_list)
    {
        int answer = -1;
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] < 0)
            {
                answer = i;
                break;
            }
        }

        return answer;
    }

    public string Practice181877(string myString)
    {
        string answer = "";
        return answer = myString.ToUpper();
    }

    public int Practice181937(int num, int n)
    {
        int answer = 0;
        return answer = num % n == 0 ? 1 : 0;
    }

    public int Practice181936(int number, int n, int m)
    {
        int answer = 0;
        if (number % n == 0 && number % m == 0)
            answer = 1;
        else
            answer = 0;
        return answer;
    }

    public int Practice181928(int[] num_list)
    {
        string even = "";
        string odd = "";

        foreach (int n in num_list)
        {
            if (n % 2 == 0)
                even += n.ToString();
            else
                odd += n.ToString();
        }

        return int.Parse(even) + int.Parse(odd);
    }

    public int[] Practice181889(int[] num_list, int n)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < n; i++)
            answer.Add(num_list[i]);


        return answer.ToArray(); ;
    }

    public int Practice120851(string my_string)
    {
        int answer = 0;
        foreach (var s in my_string)
        {
            if (char.IsDigit(s))
                answer += int.Parse(s.ToString());
        }
        return answer;
    }

    public int Practice120583(int[] array, int n)
    {
        int answer = 0;
        foreach (int i in array)
            if (i == n)
                answer++;
        return answer;
    }

    public int Practice120811(int[] array)
    {
        int answer = 0;
        Array.Sort(array);
        answer = array[array.Length / 2];
        return answer;
    }

    public int[] Practice120813(int n)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i <= n; i++)
            if (i % 2 != 0)
                answer.Add(i);
        return answer.ToArray();
    }

    public int Practice120818(int price)
    {
        int answer = price;
        if (price >= 500000)
        {
            answer = (int)(price * 0.8);
        }
        else if (price >= 300000)
        {
            answer = (int)(price * 0.9);
        }
        else if (price >= 100000)
        {
            answer = (int)(price * 0.95);
        }
        return answer;
    }

    public void Practice120823()
    {
        int s = int.Parse(Console.ReadLine());
        string star = "*";
        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write(star);
            Console.WriteLine();
        }
    }

    public int Practice120837(int hp)
    {
        int answer = 0;
        answer += hp / 5;
        hp %= 5;

        answer += hp / 3;
        hp %= 3;

        answer += hp;

        return answer;
    }

    public string Practice120839(string rsp)
    {
        string answer = "";
        foreach (var c in rsp)
        {
            if (c == '2')
            {
                answer += "0";
            }
            else if (c == '0')
            {
                answer += "5";
            }
            else
            {
                answer += "2";
            }
        }
        return answer;
    }

    public int Practice120845(int[] box, int n)
    {
        return (box[0] / n) * (box[1] / n) * (box[2] / n);
    }

    public int[] Practice120850(string my_string)
    {
        List<int> answer = new List<int>();

        foreach (var i in my_string)
        {
            if (int.TryParse(i.ToString(), out int num))
                answer.Add(num);
        }
        answer.Sort();
        return answer.ToArray();
    }

    public int Practice120862(int[] numbers)
    {
        Array.Sort(numbers);

        int n = numbers.Length;

        int case1 = numbers[n - 1] * numbers[n - 2];
        int case2 = numbers[0] * numbers[1];

        return Math.Max(case1, case2);
    }

    public string Practice120892(string cipher, int code)
    {
        string answer = "";
        int count = 1;
        foreach (char c in cipher)
        {
            if (count % code == 0)
            {
                answer += c;
            }
            count++;
        }
        return answer;
    }

    public string Practice120895(string my_string, int num1, int num2)
    {
        string answer = "";
        char[] chr = my_string.ToCharArray();
        char temp;
        temp = chr[num1];
        chr[num1] = chr[num2];
        chr[num2] = temp;

        return new string(chr);
    }

    public int[] Practice120897(int n)
    {
        List<int> answer = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                answer.Add(i);
        }

        return answer.ToArray();
    }

    public int[] Practice120899(int[] array)
    {
        List<int> answer = new List<int>();

        answer.Add(array.Max());

        for (int i = 0; i < array.Length; i++)
            if (array.Max() == array[i])
                answer.Add(i);

        return answer.ToArray();
    }
}
