using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        // (A × B) % C
        Console.WriteLine((A * B) % C);

        // ((A % C) × (B % C)) % C
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

        // 삼항 연산자를 사용하여 조건문 간략화
        Console.WriteLine(A > 0 ? (B > 0 ? 1 : 4) : (B > 0 ? 2 : 3));
    }

    public void Practice2884()
    {
        string[] s = Console.ReadLine().Split();

        int H = int.Parse(s[0]);
        int M = int.Parse(s[1]);

        if (M < 45 && H == 0) // 시간 0시의 경우
        {
            H = 23;          // 전날 23시로 설정
            M = M + 60 - 45; // 분 계산
        }
        else if (M < 45) // 다른 시간에서 분이 45보다 작은 경우
        {
            H = H - 1;
            M = M + 60 - 45;
        }
        else // 분이 45 이상인 경우
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

        // 추가된 시간을 더한 총 분 계산
        int totalMinutes = M + T;

        // 시간을 추가한 후의 값
        H += totalMinutes / 60; // 총 시간의 몫
        M = totalMinutes % 60;  // 남은 분 계산

        // 24시간 이상일 경우 조정
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
        int S = Math.Max(A, Math.Max(B, C)); // 최대값 구하기

        if (A == B && B == C)
        {
            // 세 숫자가 모두 같은 경우
            T = 10000 + (A * 1000);
        }
        else if (A == B || A == C)
        {
            // A가 B 또는 C와 같은 경우
            T = 1000 + (A * 100);
        }
        else if (B == C)
        {
            // B와 C가 같은 경우
            T = 1000 + (B * 100);
        }
        else
        {
            // 모두 다른 경우, 가장 큰 값
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
        // 테스트 케이스의 개수 입력받기
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++) // T번 반복
        {
            string[] s = Console.ReadLine().Split();

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);

            // A + B 출력
            Console.WriteLine(A + B);
        }
    }

    public void Practice25304()
    {
        //총 금액
        int A = int.Parse(Console.ReadLine());
        // 테스트 케이스의 개수 입력받기
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
        // 테스트 케이스의 개수 입력받기
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
        // 테스트 케이스의 개수 입력받기
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
        // 테스트 케이스의 개수 입력받기
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
        // 테스트 케이스의 개수 입력받기
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
        // 테스트 케이스의 개수 입력받기
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
        // 테스트 케이스의 개수 입력받기
        int T = int.Parse(Console.ReadLine());
        string s = "*";
        for (int i = 0; i < T; i++)
        {
            Console.WriteLine(s);
            s += "*";
        }

        //// 테스트 케이스의 개수 입력받기
        //int T = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= T; i++)
        //{
        //    Console.WriteLine(new string('*', i)); // '*'를 i개 생성
        //}
    }

    public void Practice2439()
    {
        // 테스트 케이스의 개수 입력받기
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
            if (input == null) break; // 입력이 더 이상 없으면 반복문 종료

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
        int size = 9; // 배열 크기
        int[] numbers = new int[size];

        int maxValue = int.MinValue; // 현재 최대값
        int maxIndex = 0;           // 최대값의 위치

        for (int i = 0; i < size; i++)
        {
            // 입력값을 받아서 정수로 변환
            int input = int.Parse(Console.ReadLine());
            numbers[i] = input;

            // 최대값과 위치 갱신
            if (input > maxValue)
            {
                maxValue = input;
                maxIndex = i + 1; // 1-based index 출력
            }
        }

        // 결과 출력
        Console.WriteLine(maxValue);
        Console.WriteLine(maxIndex);
    }

    public void Practice10810()
    {
        // 첫 번째 입력: 배열 크기와 작업 수
        int[] parameters = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int arraySize = parameters[0];
        int operationCount = parameters[1];

        // 결과를 저장할 배열 (초기값은 모두 0)
        int[] result = new int[arraySize];

        // 작업 수행
        for (int i = 0; i < operationCount; i++)
        {
            // 입력: 시작, 끝, 값
            int[] operation = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int start = operation[0];
            int end = operation[1];
            int value = operation[2];

            // 범위에 값 할당
            for (int j = start; j <= end; j++)
            {
                result[j - 1] = value; // 1-based index를 0-based로 변환
            }
        }

        // 결과 출력
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
        List<int> size = Enumerable.Range(1, 30).ToList(); // 1~30까지 리스트 생성

        for (int i = 0; i < 28; i++) // 사용자 입력을 받아서 리스트에서 제거
        {
            int del = int.Parse(Console.ReadLine());
            size.Remove(del); // 리스트에서 해당 숫자 제거
        }

        // 남은 숫자는 두 개 -> 정렬 후 출력
        size.Sort();
        Console.WriteLine($"{size[0]}");
        Console.WriteLine($"{size[1]}");
    }

    public void Practice3052()
    {
        HashSet<int> remainders = new HashSet<int>(); // 중복을 허용하지 않는 HashSet

        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());
            int temp = input % 42;
            remainders.Add(temp); // HashSet에 추가 (중복 자동 제거)
        }

        Console.WriteLine(remainders.Count); // 서로 다른 나머지 개수 출력
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

        // 배열을 -1로 초기화
        for (int i = 0; i < 26; i++)
        {
            positions[i] = -1;
        }

        // 문자열 순회하면서 알파벳 위치 저장
        for (int i = 0; i < input.Length; i++)
        {
            int index = input[i] - 'a'; // 'a'를 기준으로 인덱스 계산
            if (positions[index] == -1) // 처음 등장한 경우에만 저장
            {
                positions[index] = i;
            }
        }

        // 결과 출력
        Console.WriteLine(string.Join(" ", positions));
    }

    public void Practice2675()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string[] s = Console.ReadLine().Split();
            int repeatCount = int.Parse(s[0]); // 반복 횟수 R
            string str = s[1]; // 문자열 S

            string result = "";

            foreach (char c in str)
            {
                result += new string(c, repeatCount); // 문자를 repeatCount 만큼 반복
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
        //시간초과

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

        // 최대 빈도 찾기
        int max = 0;
        int maxIndex = 0;
        bool isDuplicate = false;

        // 배열 탐색하면서 최대값과 중복 체크
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

            // 비교, 최대값 갱신, 중복 여부 판단
        }

        // 결과 출력
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
            bool[] seen = new bool[26]; // 알파벳 사용 여부
            char prev = '\0'; // 이전 문자

            foreach (char c in word)
            {
                if (c != prev)
                {
                    if (seen[c - 'a']) // 이미 나왔던 문자가 떨어져서 다시 나옴
                    {
                        return false;
                    }
                    seen[c - 'a'] = true;
                }
                prev = c;
            }

            return true; // 그룹 단어임
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
                string[] input = Console.ReadLine().Split(); // 과목, 학점, 등급
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
                {"D0", -5}, // +5%니까 -5로 처리
                {"F", -10}  // +10%니까 -10
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
        // N과 M 입력
        var nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = nm[0], M = nm[1];

        // 행렬 A와 B 입력
        int[,] A = new int[N, M];
        int[,] B = new int[N, M];
        int[,] C = new int[N, M];  // 결과 행렬

        // 행렬 A 입력
        for (int i = 0; i < N; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < M; j++)
            {
                A[i, j] = row[j];
            }
        }

        // 행렬 B 입력
        for (int i = 0; i < N; i++)
        {
            var row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < M; j++)
            {
                B[i, j] = row[j];
            }
        }

        // 행렬 A와 B 덧셈 결과 C 계산
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        // 결과 출력
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
        outs = int.Parse((output[0] + output[1])); // 문자끼리 더한후 int로 변환후에 outs에 넣기
        outs = outs - int.Parse(output[2]);

        Console.WriteLine(input[0] + input[1] - input[2]);
        Console.WriteLine(outs);
    }

    public void Practice8958()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string line = Console.ReadLine();
            int score = 0;
            int combo = 0;

            foreach (char c in line)
            {
                if (c == 'O')
                {
                    combo++;
                    score += combo;
                }
                else
                {
                    combo = 0;
                }
            }

            Console.WriteLine(score);
        }
    }

    public void Practice10250()
    {
        int input = int.Parse(Console.ReadLine());
        string[] results = new string[input];

        for (int i = 0; i < input; i++)
        {
            int[] hwn = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = hwn[0]; // 층수
            int W = hwn[1];
            int N = hwn[2]; // 몇 번째 손님

            int floor = N % H;
            int room = N / H + 1;

            if (floor == 0)
            {
                floor = H;
                room = N / H;
            }

            // 층과 호수를 조합하여 방 번호 생성
            results[i] = $"{floor}{room.ToString("D2")}";
        }

        // 한 번에 출력
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }

    public void Practice2577()
    {
        int result = 1;
        for (int i = 0; i < 3; i++)
        {
            int num = int.Parse(Console.ReadLine());
            result *= num;
        }

        int[] counts = new int[10];
        foreach (char c in result.ToString())
        {
            int digit = c - '0';
            counts[digit]++;
        }

        foreach (int count in counts)
        {
            Console.WriteLine(count);
        }
    }

    public void Practice2920()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        bool isAscending = true;
        bool isDescending = true;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] < input[i + 1])
            {
                isDescending = false;
            }
            else if (input[i] > input[i + 1])
            {
                isAscending = false;
            }
        }

        if (isAscending)
            Console.WriteLine("ascending");
        else if (isDescending)
            Console.WriteLine("descending");
        else
            Console.WriteLine("mixed");
    }
    public void Practice4153()
    {
        while (true)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (input[0] == 0 && input[1] == 0 && input[2] == 0)
                break;

            Array.Sort(input);

            int a = input[0] * input[0];
            int b = input[1] * input[1];
            int c = input[2] * input[2];


            if (a + b == c)
            {
                Console.WriteLine("right");
            }
            else if (a + b != c)
            {
                Console.WriteLine("wrong");
            }
        }
    }

    public void Practice1978()
    {
        int a = int.Parse(Console.ReadLine());

        int[] input = new int[a];

        input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int output = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (IsPrime(input[i]))
                output++;
        }


        bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        Console.WriteLine(output);
    }

    public void Practice30802()
    {
        int a = int.Parse(Console.ReadLine());
        int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int tshirtBundles = 0;

        for (int i = 0; i < t.Length; i++)
        {
            tshirtBundles += (t[i] + p[0] - 1) / p[0];
        }

        int penBundles = a / p[1];
        int penLeftover = a % p[1];

        Console.WriteLine(tshirtBundles);
        Console.WriteLine($"{penBundles} {penLeftover}");
    }

    public void Practice2231()
    {
        int input = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 1; i < input; i++)
        {
            int sum = i;
            int temp = i;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (sum == input)
            {
                result = i;
                break;
            }
        }

        Console.WriteLine(result);
    }

    public void Practice2292()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 1;
        int range = 1;

        while (range < n)
        {
            range += 6 * count;
            count++;
        }

        Console.WriteLine(count);
    }

    public void Practice2292Practice()
    {
        int input = int.Parse(Console.ReadLine());

        int level = 1;

        while (true)
        {
            int max = (2 * level - 1) * (2 * level - 1);
            if (input <= max)
            {
                Console.WriteLine(level);
                break;
            }
            level++;
        }


    }

    public void Practice2798()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        string[] cardsInput = Console.ReadLine().Split();
        int[] cards = new int[n];
        for (int i = 0; i < n; i++)
        {
            cards[i] = int.Parse(cardsInput[i]);
        }

        int max = 0;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    int sum = cards[i] + cards[j] + cards[k];
                    if (sum <= m && sum > max)
                    {
                        max = sum;
                    }
                }
            }
        }

        Console.WriteLine(max);
    }

    public void Practice2798Practice()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        int[] cards = new int[n];

        cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int max = 0;

        for (int i = 0; i < n - 3; i++)
        {
            for (int j = i + 1; j < n - 2; j++)
            {
                for (int k = j + 1; k < n - 1; k++)
                {
                    for (int l = k + 1; l < n; l++)
                    {
                        int sum = cards[i] + cards[j] + cards[k] + cards[l];
                        if (sum <= m && sum > max)
                        {
                            max = sum;
                        }
                    }
                }
            }
        }

        Console.WriteLine(max);
    }

    public void Practice1259()
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "0") break;
            string r = new string(s.Reverse().ToArray());
            Console.WriteLine(r == s ? "yes" : "no");
        }
    }

    public void Practice15829()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        long result = 0;
        long r = 31;
        long mod = 1234567891;
        long pow = 1;

        for (int i = 0; i < s.Length; i++)
        {
            int value = s[i] - 'a' + 1;
            result = (result + value * pow) % mod;
            pow = (pow * r) % mod;
        }

        Console.WriteLine(result);
    }

    public void Practice2609()
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[0];
            int b = input[1];

            int gcd = GCD(a, b);
            int lcm = a * b / gcd;

            Console.WriteLine(gcd);
            Console.WriteLine(lcm);
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

    public void Practice2609Practice()
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = input[0];
            int b = input[1];
            int c = input[2];

            int gcd = GCD(GCD(a, b), c);

            int lcm = LCM(LCM(a, b), c);

            Console.WriteLine(gcd);
            Console.WriteLine(lcm);
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
    }

    public void Practice2775()
    {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] apt = new int[k + 1, n + 1];


            for (int i = 1; i <= n; i++)
            {
                apt[0, i] = i;
            }


            for (int i = 1; i <= k; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    apt[i, j] = apt[i, j - 1] + apt[i - 1, j];
                }
            }

            Console.WriteLine(apt[k, n]);


        }
    }

    public void Practice2775Practice()
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int k = input[0];
            int n = input[1];
            int[,] supply = new int[k + 1, n + 1];

            for (int j = 1; j <= n; j++)
            {
                supply[0, j] = j;
            }

            for (int j = 1; j <= k; j++)
            {
                for (int p = 1; p <= n; p++)
                {
                    supply[j, p] = supply[j, p - 1] + supply[j - 1, p];
                }
            }

            Console.WriteLine(supply[k, n]);
        }
    }

    public void Practice2869()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int a = input[0];
        int b = input[1];
        int c = input[2];

        int days = (c - b) / (a - b);
        if ((c - b) % (a - b) != 0)
        {
            days++;
        }

        Console.WriteLine(days);
    }

    public void Practice10989()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        int n = int.Parse(sr.ReadLine());

        int[] count = new int[10001];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(sr.ReadLine());
            count[num]++;
        }

        for (int i = 1; i < count.Length; i++)
        {
            while (count[i]-- > 0)
            {
                sw.WriteLine(i);
            }
        }

        sw.Flush();
        sw.Close();
        sr.Close();
    }

    public void Practice11050()
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            Console.WriteLine(BinomialCoefficient(n, k));
        }

        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        static int BinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
    }

    public void Practice11050Practice()
    {
        const int MOD = 1000000007;

        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);

            Console.WriteLine(BinomialCoefficient(n, k));
        }

        static long BinomialCoefficient(long n, long k)
        {
            long numerator = Factorial(n);
            long denominator = (Factorial(k) * Factorial(n - k)) % MOD;
            long inverse = Pow(denominator, MOD - 2);
            return (numerator * inverse) % MOD;
        }

        static long Factorial(long num)
        {
            long result = 1;
            for (int i = 2; i <= num; i++)
            {
                result = (result * i) % MOD;
            }
            return result;
        }

        static long Pow(long a, long b)
        {
            long result = 1;
            a %= MOD;
            while (b > 0)
            {
                if ((b & 1) == 1)
                    result = (result * a) % MOD;
                a = (a * a) % MOD;
                b >>= 1;
            }
            return result;
        }
    }

    public void Practice28702()
    {
        string[] input = new string[3];
        for (int i = 0; i < 3; i++)
            input[i] = Console.ReadLine();

        int start = -1;


        for (int i = 0; i < 3; i++)
        {
            if (int.TryParse(input[i], out int num))
            {
                start = num - i;
                break;
            }
        }


        int next = start + 3;


        Console.WriteLine(GetFizzBuzzValue(next));


        string GetFizzBuzzValue(int num)
        {
            if (num % 15 == 0) return "FizzBuzz";
            if (num % 3 == 0) return "Fizz";
            if (num % 5 == 0) return "Buzz";
            return num.ToString();
        }
    }
    public void Practice28702Practice()
    {
        string[] input = new string[4];
        for (int i = 0; i < 4; i++)
            input[i] = Console.ReadLine();

        int start = 0;
        int next = 0;
        for (int i = 0; i < 4; i++)
        {
            if (int.TryParse(input[i], out start))
            {
                next = start - i;
                break;
            }
        }

        next += 4;

        Console.WriteLine(GetFizzBuzzValue(next));
    }

    static string GetFizzBuzzValue(int num)
    {
        if (num % 15 == 0) return "FizzBuzz";
        if (num % 3 == 0) return "Fizz";
        if (num % 5 == 0) return "Buzz";
        return num.ToString();
    }

    public void Practice1181()
    {
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }


        var result = words
            .Distinct()
            .OrderBy(word => word.Length)
            .ThenBy(word => word);

        foreach (var word in result)
        {
            Console.WriteLine(word);
        }
    }

    public void Practice1436()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int number = 666;

        while (true)
        {
            if (number.ToString().Contains("666"))
            {
                count++;
                if (count == n)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
            number++;
        }
    }

    public void Practice1676()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 5; i <= n; i *= 5)
        {
            count += n / i;
        }

        Console.WriteLine(count);
    }

    public void Practice2751()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(sr.ReadLine());
        }

        Array.Sort(arr);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.AppendLine(arr[i].ToString());
        }

        sw.Write(sb);
        sw.Flush();
        sw.Close();
        sr.Close();
    }

    public void Practice14626()
    {
        string isbn = Console.ReadLine();
        int starIndex = isbn.IndexOf('*');

        for (int i = 0; i <= 9; i++)
        {
            string temp = isbn.Substring(0, starIndex) + i + isbn.Substring(starIndex + 1);
            int sum = 0;

            for (int j = 0; j < 12; j++)
            {
                int digit = temp[j] - '0';
                if ((j + 1) % 2 == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }

            int checkDigit = (10 - (sum % 10)) % 10;
            if (checkDigit == temp[12] - '0')
            {
                Console.WriteLine(i);
                break;
            }

        }
    }

    public void Practice7568()
    {
        int count = int.Parse(Console.ReadLine());
        List<(int weight, int height)> people = new List<(int, int)>();

        for (int i = 0; i < count; i++)
        {
            int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            people.Add((data[0], data[1]));
        }

        for (int i = 0; i < count; i++)
        {
            int rank = 1;

            for (int j = 0; j < count; j++)
            {
                if (i == j) continue;


                if (people[j].weight > people[i].weight && people[j].height > people[i].height)
                {
                    rank++;
                }
            }

            Console.Write(rank + " ");
        }
    }
    public void Practice10814()
    {
        int count = int.Parse(Console.ReadLine());
        List<(int age, string name, int index)> people = new List<(int, string, int)>();

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split();
            people.Add((int.Parse(input[0]), input[1], i));
        }

        var sorted = people.OrderBy(p => p.age).ThenBy(p => p.index);

        foreach (var p in sorted)
            Console.WriteLine($"{p.age} {p.name}");
    }

    public void Practice11650()
    {
        // 입력 최적화
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        int n = int.Parse(sr.ReadLine());

        List<(int x, int y)> points = new List<(int x, int y)>();

        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            points.Add((x, y));
        }

        
        points.Sort((a, b) =>
        {
            if (a.x == b.x)
                return a.y.CompareTo(b.y);
            return a.x.CompareTo(b.x);
        });

        // 출력 최적화
        StringBuilder sb = new StringBuilder();
        foreach (var point in points)
        {
            sb.AppendLine($"{point.x} {point.y}");
        }
        sw.Write(sb);
        sw.Flush(); 
        sw.Close(); 
        sr.Close();
    }

    public void Practice11651()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());


        int n = int.Parse(sr.ReadLine());
        List<(int x, int y)> points = new List<(int x, int y)>();

        for (int i = 0; i < n; i++)
        {
            string[] input = sr.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            points.Add((x, y));
        }


        points.Sort((a, b) =>
        {
            if (a.y == b.y)
                return a.x.CompareTo(b.x);
            return a.y.CompareTo(b.y); ;
        });


        StringBuilder sb = new StringBuilder();
        foreach (var point in points)
        {
            sb.AppendLine($"{point.x} {point.y}");
        }
        sw.Write(sb);
        sw.Flush();
        sw.Close();
        sr.Close();
    }

    public void Practice1018()
    {
        var size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);

        char[,] board = new char[n, m];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < m; j++)
            {
                board[i, j] = line[j];
            }
        }

        int min = 64; // 최대 64칸을 다시 칠할 수 있으므로

        for (int i = 0; i <= n - 8; i++)
        {
            for (int j = 0; j <= m - 8; j++)
            {
                int repaint1 = 0; // 'W'로 시작하는 체스판
                int repaint2 = 0; // 'B'로 시작하는 체스판

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        char current = board[i + x, j + y];
                        // x+y가 짝수일 땐 시작 색과 같아야 함
                        if ((x + y) % 2 == 0)
                        {
                            if (current != 'W') repaint1++;
                            if (current != 'B') repaint2++;
                        }
                        else
                        {
                            if (current != 'B') repaint1++;
                            if (current != 'W') repaint2++;
                        }
                    }
                }

                min = Math.Min(min, Math.Min(repaint1, repaint2));
            }
        }

        Console.WriteLine(min);
    }

    public void Practice1920()
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(a); // 이진 탐색을 위해 정렬

            StringBuilder sb = new StringBuilder();

            foreach (int target in targets)
            {
                sb.AppendLine(BinarySearch(a, target) ? "1" : "0");
            }

            Console.Write(sb);
        }

        static bool BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return true;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }
    }

    public void Practice2164()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<int> queue = new Queue<int>();

        // 1부터 n까지 큐에 넣기
        for (int i = 1; i <= n; i++)
        {
            queue.Enqueue(i);
        }

        // 카드가 한 장 남을 때까지 반복
        while (queue.Count > 1)
        {
            queue.Dequeue(); // 제일 위 카드 버리기
            int temp = queue.Dequeue(); // 다음 카드 꺼내서
            queue.Enqueue(temp); // 다시 뒤로 넣기
        }

        // 마지막 남은 카드 출력
        Console.WriteLine(queue.Peek());
    }

    public void Practice2839()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        while (n >= 0)
        {
            if (n % 5 == 0)
            {
                count += n / 5;
                Console.WriteLine(count);
                return;
            }
            n -= 3;
            count++;
        }

        Console.WriteLine(-1);  // 정확히 나눌 수 없는 경우
    }

    public void Practice4949()
    {
        while (true)
        {
            string line = Console.ReadLine();

            if (line == ".")
                break;

            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            foreach (char ch in line)
            {
                if (ch == '(' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0 || stack.Peek() != '(')
                    {
                        isBalanced = false;
                        break;
                    }
                    stack.Pop();
                }
                else if (ch == ']')
                {
                    if (stack.Count == 0 || stack.Peek() != '[')
                    {
                        isBalanced = false;
                        break;
                    }
                    stack.Pop();
                }
            }

            if (stack.Count != 0)
                isBalanced = false;

            Console.WriteLine(isBalanced ? "yes" : "no");
        }
    }
}


