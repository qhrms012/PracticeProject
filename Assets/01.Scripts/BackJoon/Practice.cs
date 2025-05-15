using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class Practice : MonoBehaviour
{
    private void Start()
    {

    }

    public void Practice18108()
    {
        string s = Console.ReadLine();
        int year = int.Parse(s) - 543;
        Console.WriteLine(year);
    }

    public void Practice10926()
    {
        string s = Console.ReadLine();

        if (s.Length > 50)
        {
            s = s.Substring(0, 50);
        }
        Console.WriteLine(s + "??!");
    }

    public void Practice10869()
    {
        string[] s = Console.ReadLine().Split();

        Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
        Console.WriteLine(int.Parse(s[0]) - int.Parse(s[1]));
        Console.WriteLine(int.Parse(s[0]) * int.Parse(s[1]));
        Console.WriteLine(int.Parse(s[0]) / int.Parse(s[1]));
        Console.WriteLine(int.Parse(s[0]) % int.Parse(s[1]));
    }

    public void Practice10430()
    {
        string[] s = Console.ReadLine().Split();
        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int C = int.Parse(s[2]);

        // (A + B) % C
        Console.WriteLine((A + B) % C);

        // ((A % C) + (B % C)) % C
        Console.WriteLine(((A % C) + (B % C)) % C);

        // (A �� B) % C
        Console.WriteLine((A * B) % C);

        // ((A % C) �� (B % C)) % C
        Console.WriteLine(((A % C) * (B % C)) % C);
    }

    public void Practice2588()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[2]));
        Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[1]));
        Console.WriteLine(int.Parse(a) * (int)Char.GetNumericValue(b[0]));
        Console.WriteLine(int.Parse(a) * int.Parse(b));
    }

    public void Practice11382()
    {
        string[] s = Console.ReadLine().Split();

        double A = double.Parse(s[0]);
        double B = double.Parse(s[1]);
        double C = double.Parse(s[2]);
        Console.WriteLine(A + B + C);
    }

    public void Practice10171()
    {
        Console.WriteLine("\\    /\\");
        Console.WriteLine(" )  ( ')");
        Console.WriteLine("(  /  )");
        Console.WriteLine(" \\(__)|");
    }
    public void Practice10172()
    {
        Console.WriteLine("|\\_/|");
        Console.WriteLine("|q p|   /}");
        Console.WriteLine("( 0 )\"\"\"\\");
        Console.WriteLine("|\"^\"`    |");
        Console.WriteLine("||_/=\\\\__|");
    }

    public void Practice1330()
    {
        string[] s = Console.ReadLine().Split();

        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);

        if (A > B)
        {
            Console.WriteLine(">");
        }
        else if (A < B)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("==");
        }
    }

    public void Practice9498()
    {
        string s = Console.ReadLine();

        int A = int.Parse(s);

        string grade = A switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine(grade);
    }

    public void Pracktice2753()
    {
        //string s = Console.ReadLine();

        //int A = int.Parse(s);

        //if (A % 4 == 0 && A % 100 > 0 || A % 400 == 0)
        //{
        //    Console.WriteLine("1");
        //}
        //else
        //{
        //    Console.WriteLine("0");
        //}

        int A = int.Parse(Console.ReadLine());
        Console.WriteLine((A % 4 == 0 && A % 100 != 0 || A % 400 == 0) ? "1" : "0");
    }

    public void Practice14681()
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int A = int.Parse(s);
        int B = int.Parse(t);

        if (A >= 0 && B >= 0)
        {
            Console.WriteLine("1");
        }
        else if (A >= 0 && B <= 0)
        {
            Console.WriteLine("4");
        }
        else if (A <= 0 && B >= 0)
        {
            Console.WriteLine("2");
        }
        else
        {
            Console.WriteLine("3");
        }

        // ���� �����ڸ� ����Ͽ� ���ǹ� ����ȭ
        Console.WriteLine(A > 0 ? (B > 0 ? 1 : 4) : (B > 0 ? 2 : 3));
    }

    public void Practice2884()
    {
        string[] s = Console.ReadLine().Split();

        int H = int.Parse(s[0]);
        int M = int.Parse(s[1]);

        if (M < 45 && H == 0) // �ð� 0���� ���
        {
            H = 23;          // ���� 23�÷� ����
            M = M + 60 - 45; // �� ���
        }
        else if (M < 45) // �ٸ� �ð����� ���� 45���� ���� ���
        {
            H = H - 1;
            M = M + 60 - 45;
        }
        else // ���� 45 �̻��� ���
        {
            M = M - 45;
        }

        Console.WriteLine($"{H} {M}");
    }
    public void Practice2525()
    {
        string[] s = Console.ReadLine().Split();
        string t = Console.ReadLine();

        int H = int.Parse(s[0]);
        int M = int.Parse(s[1]);
        int T = int.Parse(t);

        // �߰��� �ð��� ���� �� �� ���
        int totalMinutes = M + T;

        // �ð��� �߰��� ���� ��
        H += totalMinutes / 60; // �� �ð��� ��
        M = totalMinutes % 60;  // ���� �� ���

        // 24�ð� �̻��� ��� ����
        H %= 24;

        Console.WriteLine($"{H} {M}");
    }

    public void Practice2480()
    {
        string[] s = Console.ReadLine().Split();

        int A = int.Parse(s[0]);
        int B = int.Parse(s[1]);
        int C = int.Parse(s[2]);

        int T = 0;
        int S = Math.Max(A, Math.Max(B, C)); // �ִ밪 ���ϱ�

        if (A == B && B == C)
        {
            // �� ���ڰ� ��� ���� ���
            T = 10000 + (A * 1000);
        }
        else if (A == B || A == C)
        {
            // A�� B �Ǵ� C�� ���� ���
            T = 1000 + (A * 100);
        }
        else if (B == C)
        {
            // B�� C�� ���� ���
            T = 1000 + (B * 100);
        }
        else
        {
            // ��� �ٸ� ���, ���� ū ��
            T = S * 100;
        }

        Console.WriteLine(T);
    }

    public void Practice2739()
    {
        string s = Console.ReadLine();

        int A = int.Parse(s);
        int B = 0;
        for (int i = 1; i < 10; i++)
        {
            B = A * i;


            Console.WriteLine($"{A} * {i} = " + B);
        }
    }

    public void Practice10950()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++) // T�� �ݺ�
        {
            string[] s = Console.ReadLine().Split();

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);

            // A + B ���
            Console.WriteLine(A + B);
        }
    }

    public void Practice25304()
    {
        //�� �ݾ�
        int A = int.Parse(Console.ReadLine());
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        int D = 0;
        for (int i = 0; i < T; i++)
        {

            string[] s = Console.ReadLine().Split();
            int B = int.Parse(s[0]);
            int C = int.Parse(s[1]);

            D += B * C;
        }

        if (D == A)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    public void Practice8393()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());

        int D = 0;
        int A = 0;
        for (int i = 0; i < T; i++)
        {
            D++;
            A += D;
        }

        Console.WriteLine(A);
    }

    public void Practice25314()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        int A = T / 4;

        for (int i = 0; i < A; i++)
        {
            Console.Write("long ");
        }
        Console.Write("int");

    }

    public void Practice15552()
    {
        StringBuilder sb = new StringBuilder();
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            string[] s = Console.ReadLine().Split();
            sb.Append(int.Parse(s[0]) + int.Parse(s[1]) + "\n");
        }
        Console.WriteLine(sb.ToString());
    }

    public void Practice11021()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        int D = 1;
        for (int i = 0; i < T; i++)
        {
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = A + B;

            Console.WriteLine($"Case #{D}: " + C);
            D++;
        }
    }

    public void Practice11022()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        int C = 1;
        for (int i = 0; i < T; i++)
        {
            string[] s = Console.ReadLine().Split();

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int D = A + B;
            Console.WriteLine($"Case #{C}: {A} + {B} = {D}");
            C++;
        }
    }

    public void Practice2438()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        string s = "*";
        for (int i = 0; i < T; i++)
        {
            Console.WriteLine(s);
            s += "*";
        }

        //// �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        //int T = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= T; i++)
        //{
        //    Console.WriteLine(new string('*', i)); // '*'�� i�� ����
        //}
    }

    public void Practice2439()
    {
        // �׽�Ʈ ���̽��� ���� �Է¹ޱ�
        int T = int.Parse(Console.ReadLine());
        int J = T;
        int K = 1;
        for (int i = 1; i <= T; i++)
        {
            for (J = T; J > K; J--)
            {
                Console.Write(" ");
            }
            for (K = 1; K < i + 1; K++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void Practice10952()
    {
        while (true)
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            int c = a + b;

            if (a == 0 && b == 0)
            {
                break;
            }
            Console.WriteLine(c);
        }
    }

    public void Practice10951()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == null) break; // �Է��� �� �̻� ������ �ݺ��� ����

            string[] s = input.Split();

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            Console.WriteLine(a + b);
        }
    }

    public void Practice10807()
    {
        int t = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();
        string y = Console.ReadLine();
        int a = 0;
        for (int i = 0; i < t; i++)
        {
            if (s[i] == y)
            {
                ++a;
            }
        }
        Console.WriteLine(a);
    }

    public void Practice10871()
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        List<int> d = new List<int>();

        for (int i = 0; i < a[0]; i++)
        {
            if (b[i] < a[1])
            {
                d.Add(b[i]);
            }
        }

        Console.WriteLine(string.Join(" ", d));
    }

    public void Practice10818()
    {
        int a = int.Parse(Console.ReadLine());

        int[] b = new int[a];

        string[] s = Console.ReadLine().Split();
        for (int i = 0; i < a; i++)
        {
            b[i] = int.Parse(s[i]);
        }

        Array.Sort(b);

        Console.WriteLine($"{b[0]} {b[a - 1]}");
    }

    public void Practice2562()
    {
        int size = 9; // �迭 ũ��
        int[] numbers = new int[size];

        int maxValue = int.MinValue; // ���� �ִ밪
        int maxIndex = 0;           // �ִ밪�� ��ġ

        for (int i = 0; i < size; i++)
        {
            // �Է°��� �޾Ƽ� ������ ��ȯ
            int input = int.Parse(Console.ReadLine());
            numbers[i] = input;

            // �ִ밪�� ��ġ ����
            if (input > maxValue)
            {
                maxValue = input;
                maxIndex = i + 1; // 1-based index ���
            }
        }

        // ��� ���
        Console.WriteLine(maxValue);
        Console.WriteLine(maxIndex);
    }

    public void Practice10810()
    {
        // ù ��° �Է�: �迭 ũ��� �۾� ��
        int[] parameters = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int arraySize = parameters[0];
        int operationCount = parameters[1];

        // ����� ������ �迭 (�ʱⰪ�� ��� 0)
        int[] result = new int[arraySize];

        // �۾� ����
        for (int i = 0; i < operationCount; i++)
        {
            // �Է�: ����, ��, ��
            int[] operation = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int start = operation[0];
            int end = operation[1];
            int value = operation[2];

            // ������ �� �Ҵ�
            for (int j = start; j <= end; j++)
            {
                result[j - 1] = value; // 1-based index�� 0-based�� ��ȯ
            }
        }

        // ��� ���
        Console.WriteLine(string.Join(" ", result));
    }

    public void Practice10813()
    {
        int[] size = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] last = new int[size[0]];

        for (int i = 0; i < size[0]; i++)
        {
            last[i] = i + 1;
        }
        for (int i = 0; i < size[1]; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int num1 = input[0] - 1;
            int num2 = input[1] - 1;


            int num3 = last[num1];
            last[num1] = last[num2];
            last[num2] = num3;
        }
        Console.WriteLine(string.Join(" ", last));
    }

    public void Practice5597()
    {
        List<int> size = Enumerable.Range(1, 30).ToList(); // 1~30���� ����Ʈ ����

        for (int i = 0; i < 28; i++) // ����� �Է��� �޾Ƽ� ����Ʈ���� ����
        {
            int del = int.Parse(Console.ReadLine());
            size.Remove(del); // ����Ʈ���� �ش� ���� ����
        }

        // ���� ���ڴ� �� �� -> ���� �� ���
        size.Sort();
        Console.WriteLine($"{size[0]}");
        Console.WriteLine($"{size[1]}");
    }

    public void Practice3052()
    {
        HashSet<int> remainders = new HashSet<int>(); // �ߺ��� ������� �ʴ� HashSet

        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());
            int temp = input % 42;
            remainders.Add(temp); // HashSet�� �߰� (�ߺ� �ڵ� ����)
        }

        Console.WriteLine(remainders.Count); // ���� �ٸ� ������ ���� ���
    }

    public void Practice10811()
    {
        int[] start = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] ints = new int[start[0]];

        for (int i = 0; i < start[0]; i++)
        {
            ints[i] = i + 1;
        }

        for (int i = 0; i < start[1]; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int starts = input[0] - 1;
            int ends = input[1] - starts;

            Array.Reverse(ints, starts, ends);

        }
        Console.Write(string.Join(" ", ints));
    }

    public void Practice1546()
    {
        int counts = int.Parse(Console.ReadLine());
        float max = float.MinValue;
        float[] score = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

        for (int i = 0; i < counts; i++)
        {
            if (score[i] > max)
            {
                max = score[i];
            }
        }

        float sum = 0.0f;
        float average = 0.0f;
        for (int i = 0; i < counts; i++)
        {
            score[i] = score[i] / max * 100;
            sum += score[i];
        }
        average = sum / counts;
        string sums = string.Format("{0:N2}", average);
        Console.WriteLine(sums);
    }
    public void Practice27866()
    {
        string input = Console.ReadLine();

        int count = int.Parse(Console.ReadLine());
        //string output = input.Substring(count - 1, 1);

        Console.WriteLine(input[count - 1]);
    }

    public void Practice2743()
    {
        string input = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            count++;
        }
        Console.WriteLine(count);
    }

    public void Practice9086()
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string input = Console.ReadLine();
            char first = input.FirstOrDefault();
            char last = input.LastOrDefault();
            Console.WriteLine($"{first}{last}");
        }
    }

    public void Practice11654()
    {
        string s = Console.ReadLine();

        char asc = s[0];
        int asc_i = (int)asc;
        Console.WriteLine(asc_i);
    }

    public void Practice11720()
    {
        int input = int.Parse(Console.ReadLine());
        string number = Console.ReadLine();

        int sum = 0;

        for (int i = 0; i < input; i++)
        {
            sum += int.Parse(number[i].ToString());
        }
        Console.WriteLine(sum);
    }
    public void Practice10809()
    {
        string input = Console.ReadLine();
        int[] positions = new int[26];

        // �迭�� -1�� �ʱ�ȭ
        for (int i = 0; i < 26; i++)
        {
            positions[i] = -1;
        }

        // ���ڿ� ��ȸ�ϸ鼭 ���ĺ� ��ġ ����
        for (int i = 0; i < input.Length; i++)
        {
            int index = input[i] - 'a'; // 'a'�� �������� �ε��� ���
            if (positions[index] == -1) // ó�� ������ ��쿡�� ����
            {
                positions[index] = i;
            }
        }

        // ��� ���
        Console.WriteLine(string.Join(" ", positions));
    }

    public void Practice2675()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string[] s = Console.ReadLine().Split();
            int repeatCount = int.Parse(s[0]); // �ݺ� Ƚ�� R
            string str = s[1]; // ���ڿ� S

            string result = "";

            foreach (char c in str)
            {
                result += new string(c, repeatCount); // ���ڸ� repeatCount ��ŭ �ݺ�
            }

            Console.WriteLine(result);
        }
    }

    public void Practice1152()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(input.Length);
    }

    public void Practice2908()
    {
        string[] input = Console.ReadLine().Split();

        char[] chars = input[0].ToCharArray();
        char[] chars1 = input[1].ToCharArray();

        Array.Reverse(chars);
        Array.Reverse(chars1);

        int a = 0;
        int b = 0;
        int c = 0;

        a = int.Parse(chars);
        b = int.Parse(chars1);


        if (a < b)
        {
            c = b;
        }
        else
        {
            c = a;
        }
        Console.WriteLine(c);
    }
    public void Practice5622()
    {
        string input = Console.ReadLine();
        int totalTime = 0;

        foreach (char c in input)
        {
            if ("ABC".Contains(c)) totalTime += 3;
            else if ("DEF".Contains(c)) totalTime += 4;
            else if ("GHI".Contains(c)) totalTime += 5;
            else if ("JKL".Contains(c)) totalTime += 6;
            else if ("MNO".Contains(c)) totalTime += 7;
            else if ("PQRS".Contains(c)) totalTime += 8;
            else if ("TUV".Contains(c)) totalTime += 9;
            else if ("WXYZ".Contains(c)) totalTime += 10;
        }

        Console.WriteLine(totalTime);
    }

    public void Practice11718()
    {

        string input;

        while (true)
        {

            input = Console.ReadLine();

            if (input == "")
                break;

        }

        Console.WriteLine(input);
        //�ð��ʰ�

        while (true)
        {
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) == true) break;
            Console.WriteLine(input);
        }
    }
    
        
    public void Practice3003()
    {
        string[] input = Console.ReadLine().Split();

        int[] chess = { 1, 1, 2, 2, 2, 8 };
        int[] finish = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            finish[i] = chess[i] - int.Parse(input[i]);
        }

        Console.WriteLine(string.Join(" ", finish));
    }

    public void Practice25083()
    {
        Console.WriteLine("         ,r'\"7");
        Console.WriteLine("r`-_   ,'  ,/");
        Console.WriteLine(" \\. \". L_r'");
        Console.WriteLine("   `~\\/");
        Console.WriteLine("      |");
        Console.WriteLine("      |");
    }

    public void Practice2444()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            Console.WriteLine(new string('*', 2 * i - 1));
        }
    }

    public void Practice10988()
    {
        string s = Console.ReadLine();
        bool isPalindrome = true;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? 1 : 0);
    }

    public void Practice1157()
    {
        string input = Console.ReadLine().ToUpper();
        int[] alpha = new int[26];

        foreach (char c in input)
        {
            alpha[c - 'A']++;
        }

        // �ִ� �� ã��
        int max = 0;
        int maxIndex = 0;
        bool isDuplicate = false;

        // �迭 Ž���ϸ鼭 �ִ밪�� �ߺ� üũ
        for (int i = 0; i < 26; i++)
        {
            if (alpha[i] > max)
            {
                max = alpha[i];
                maxIndex = i;
                isDuplicate = false;
            }
            else if (alpha[i] == max)
            {
                isDuplicate = true;
            }

            // ��, �ִ밪 ����, �ߺ� ���� �Ǵ�
        }

        // ��� ���
        if (isDuplicate)
            Console.WriteLine("?");
        else
            Console.WriteLine((char)(maxIndex + 'A'));
    }

    public void Practice2941()
    {
        string input = Console.ReadLine();
        string[] croatia = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

        foreach (string c in croatia)
        {
            input = input.Replace(c, "*");
        }

        Console.WriteLine(input.Length);

    }
    public void Practice1316()
    {
        static void Main(string[] args)
        {
            int inputLength = int.Parse(Console.ReadLine());
            int groupWordCount = 0;

            for (int i = 0; i < inputLength; i++)
            {
                string input = Console.ReadLine();
                if (IsGroupWord(input))
                {
                    groupWordCount++;
                }
            }

            Console.WriteLine(groupWordCount);
        }

        static bool IsGroupWord(string word)
        {
            bool[] seen = new bool[26]; // ���ĺ� ��� ����
            char prev = '\0'; // ���� ����

            foreach (char c in word)
            {
                if (c != prev)
                {
                    if (seen[c - 'a']) // �̹� ���Դ� ���ڰ� �������� �ٽ� ����
                    {
                        return false;
                    }
                    seen[c - 'a'] = true;
                }
                prev = c;
            }

            return true; // �׷� �ܾ���
        }
    }
    public void Practice25206()
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gradeDict = new Dictionary<string, double>()
            {
                {"A+", 4.5},
                {"A0", 4.0},
                {"B+", 3.5},
                {"B0", 3.0},
                {"C+", 2.5},
                {"C0", 2.0},
                {"D+", 1.5},
                {"D0", 1.0},
                {"F", 0.0}
            };

            int inputLength = 20;
            List<string[]> inputList = new List<string[]>();

            for (int i = 0; i < inputLength; i++)
            {
                string[] input = Console.ReadLine().Split(); // ����, ����, ���
                inputList.Add(input);
            }

            double totalScore = 0;
            double totalCredit = 0;

            foreach (var subject in inputList)
            {
                string subjectName = subject[0];
                double credit = double.Parse(subject[1]);
                string grade = subject[2];

                if (grade == "P") continue;

                double score = gradeDict[grade];
                totalScore += credit * score;
                totalCredit += credit;
            }

            double average = totalScore / totalCredit;
            Console.WriteLine($"{average:F6}");
        }
    }
    public void Practice25206Practice()
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> payDict = new Dictionary<string, double>()
            {
                {"A+", 30},
                {"A0", 25},
                {"B+", 20},
                {"B0", 15},
                {"C+", 10},
                {"C0", 5},
                {"D+", 0},
                {"D0", -5}, // +5%�ϱ� -5�� ó��
                {"F", -10}  // +10%�ϱ� -10
            };

            int inputLength = 3;
            List<string[]> inputList = new List<string[]>();

            for (int i = 0; i < inputLength; i++)
            {
                string[] input = Console.ReadLine().Split();
                inputList.Add(input);
            }

            double baseFee = 100000;
            double totalFee = 0;

            foreach (var subject in inputList)
            {
                string subjectName = subject[0];
                double credit = double.Parse(subject[1]);
                string grade = subject[2];

                if (grade == "P") continue;

                double discountRate = payDict[grade];
                double originalCost = credit * baseFee;
                double discountAmount = originalCost * (discountRate / 100.0);
                double finalCost = originalCost - discountAmount;

                totalFee += finalCost;
            }

            Console.WriteLine($"{totalFee:F0}");
        }
    }
    public void Practice10699()
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.ToString("yyyy-MM-dd"));
        }
    }

    public void Practice7287()
    {
        static void Main(string[] args)
        {
            Console.WriteLine("62");
            Console.WriteLine("qhrms028");
        }
    }

    public void Practice2420()
    {
        string[] input = Console.ReadLine().Split();

        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        long c = Math.Abs(a - b);
        Console.Write(c);
    }

    public void Practice2741()
    {
        int input = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= input; i++)
            sb.AppendLine(i.ToString());
        Console.WriteLine(sb.ToString());
    }
    public void Practice10872()
    {
        int input = int.Parse(Console.ReadLine());

        int output = 1;
        if (input != 0)
        {
            for (int i = input; i > 0; i--)
            {
                output *= i;
            }
        }
        else
        {
            output = 1;
        }
        Console.WriteLine(output);
    }
    public void Practice2738()
    {
        // N�� M �Է�
        var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = nm[0], M = nm[1];

        // ��� A�� B �Է�
        int[,] A = new int[N, M];
        int[,] B = new int[N, M];
        int[,] C = new int[N, M];  // ��� ���

        // ��� A �Է�
        for (int i = 0; i < N; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < M; j++)
            {
                A[i, j] = row[j];
            }
        }

        // ��� B �Է�
        for (int i = 0; i < N; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < M; j++)
            {
                B[i, j] = row[j];
            }
        }

        // ��� A�� B ���� ��� C ���
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        // ��� ���
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public void Practice2744()
    {
        var input = Console.ReadLine();
        string output = string.Empty;

        foreach (var c in input)
        {
            output += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }

        Console.WriteLine(output);
    }
    public void Practice2754()
    {
        var input = Console.ReadLine();
        Dictionary<string, double> average = new Dictionary<string, double>()
            {
                {"A+",4.3},
                {"A0",4.0},
                {"A-",3.7},
                {"B+",3.3},
                {"B0",3.0},
                {"B-",2.7},
                {"C+",2.3},
                {"C0",2.0},
                {"C-",1.7},
                {"D+",1.3},
                {"D0",1.0},
                {"D-",0.7},
                {"F", 0.0}

            };
        if (average.ContainsKey(input))
        {
            double output = average[input];
            Console.WriteLine($"{output:F1}");
        }
    }

    public void Practice15964()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Console.WriteLine((input[0] + input[1]) * (input[0] - input[1]));
    }
    public void Practice2475()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int MOD = 10;
        int sumOfSquares = 0;

        foreach (var num in input)
        {
            sumOfSquares += num * num;
        }

        Console.WriteLine(sumOfSquares % MOD);
    }

    public void Practice31403()
    {
        int[] input = new int[3];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        string[] output = new string[input.Length];
        int outs = 0;
        for (int i = 0; i < input.Length; i++)
        {
            output[i] = input[i].ToString();
        }
        outs = int.Parse((output[0] + output[1])); // ���ڳ��� ������ int�� ��ȯ�Ŀ� outs�� �ֱ�
        outs = outs - int.Parse(output[2]);

        Console.WriteLine(input[0] + input[1] - input[2]);
        Console.WriteLine(outs);
    }
}

