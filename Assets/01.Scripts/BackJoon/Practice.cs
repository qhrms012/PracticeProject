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

}

