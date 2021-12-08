using System;
using System.Text;
using System.Diagnostics;

namespace FirstProject
{
    class Program
    {
        static void StringToEnd(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string result = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                result += i + " ";
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds);
            Console.WriteLine(result);
            Console.WriteLine(elapsedTime);
        }
        static void StringToBeginning(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string result = string.Empty;
            for (int i = n; i >= 1; i--)
            {
                result = i + " " + result;
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(result);
            Console.WriteLine(elapsedTime);
        }
        static void SBuilderAppend(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                result.Append(i + " ");
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(result);
            Console.WriteLine(elapsedTime);
        }
        static void SBuilderInsert(int n)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            StringBuilder result = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                result.Insert(0,i + " ");
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(result);
            Console.WriteLine(elapsedTime);
        }
        static void Main(string[] args)
        {
            int s;
            do
            {
                int n = int.Parse(Console.ReadLine());
                s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1:
                        StringToEnd(n);
                        break;
                    case 2:
                        StringToBeginning(n);
                        break;
                    case 3:
                        SBuilderAppend(n);
                        break;
                    case 4:
                        SBuilderInsert(n);
                        break;
                    case 0: break;
                }
            }
            while (s != 0);
        }
    }
}
