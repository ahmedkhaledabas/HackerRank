using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {

        public static int SaveThePrisoner(int n, int m, int s)
        {
            return ((s - 1 + m - 1) % n) + 1;
        }

        public static List<int> cc(List<int> a , int k , List<int> queries)
        {
            List<int> result = new List<int>();
            for(int i = 0; i<k; i++)
            {
                if(a.Count -1 > 1)
                {
                    int last = a[^1];
                    a.RemoveAt(a.Count - 1);
                    a.Insert(0, last);
                }
            }
            //2 3 1
            for(int i = 0; i< queries.Count; i++)
            {
                result.Add( a[queries[i]]);
            }
            return result;
        }

        //public static int SaveThePrisoner(int n, int m, int s)
        //{

        //    for (int i = 2; i <= m; i++)
        //    {
        //        if (s < n) s++;
        //        else if (s == n) s = 1;
        //    }
        //    return s;
        //}

        //public static long get(string s, int n)
        //{
        //    // aba  10
        //    long numOfA = s.Count(c => c == 'a');  //2
        //    long fullRepeat = n / s.Length; // 10 / 3 = 3
        //    long reminingRepeat = n % s.Length;// 1
        //    long countInRemaining = s.Substring(0, (int)reminingRepeat).Count(c => c == 'a');
        //    return (numOfA * fullRepeat) + countInRemaining;
        //}

        public static List<int> CutTheSticks(List<int> arr)
        {
            List<int> result = new();

            while (arr.Count > 0)
            {
                result.Add(arr.Count);
                int min = arr.Min();
                arr = arr.Where(s => s > min).Select(s => s - min).ToList();
            }

            return result;
        }

        //public static List<int> CutTheSticks(List<int> arr)
        //{
        //    List<int> result = new();
        //    int min = arr.Min();
        //    int count = arr.Count;
        //    result.Add(count);
        //    for(int i = 0; i < arr.Count; i++)
        //    {
        //        int diff = arr[i] - min;
        //        var index = arr.FindIndex(i , 1, s => s == arr[i]);
        //        arr.RemoveAt(index);
        //        arr.Insert(index, diff);

        //        if (i == arr.Count - 1)
        //        {
        //            i = -1;
        //            arr.RemoveAll(s=>s==0);
        //            count = arr.Count;
        //            if (arr.Count == 0) break;
        //            result.Add(count);
        //             min = arr.Min();

        //        }
        //    }
        //    return result;
        //}

        static void Main(string[] args)
        {
            Factorial factorial = new();
            Console.WriteLine(factorial.GetFactorial(25));

            //string s = "aba";
            //Console.WriteLine(get(s, 10));
            //ACMTeam aCMTeam = new();
            //var r = aCMTeam.CalcACMTeam(["10101", "11100", "11010" , "00101"]);
            //foreach(var a in r)
            //{
            //    Console.WriteLine(a);
            //}
            //1 2 3 1 2 3 3 3
            //List<int> x =  [0, 1, 0 ,0 , 0 , 1];
            //int result = x.GroupBy(n => n).Where(n => n.Count() == 1).Select(n => n.Key).ToList().Count;
            //x.RemoveAll(n=> n ==1);
            //for(int i = 0; i < x.Count; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}
            //List<int> arr = [1, 2, 3, 1, 2, 3, 3, 3];
            //static int EqualizeArray(List<int> arr)
            //{
            //    // Count occurrences of each number
            //    var frequency = arr.GroupBy(n => n)
            //                       .ToDictionary(g => g.Key, g => g.Count());

            //    // Find the max frequency of any number
            //    int maxFrequency = frequency.Values.Max();

            //    // Calculate the minimum deletions needed
            //        return arr.Count - maxFrequency;
            //}
            //Console.WriteLine(EqualizeArray(arr));
            //Console.WriteLine(SaveThePrisoner(3, 7, 3));
            //Console.WriteLine($"Enter length of friends ");
            //int length = int.Parse(Console.ReadLine());
            //string[] friends = new string[length];
            //for (int i = 1; i < length+1; i++)
            //{
            //    Console.WriteLine($"Enter friends {i} value ");
            //    friends[i-1] = Console.ReadLine();
            //}

            //friends.Print();

            //bool isVIP = true;
            //switch (isVIP)
            //{
            //    case bool i when i == false:
            //        Console.WriteLine("false");
            //        break;
            //    case bool i:
            //        Console.WriteLine("true");
            //        break;
            //}

            //int cardNo = 13;
            //string cardName = cardNo switch
            //{
            //    1 => "ACE",
            //    13 => "KING",
            //    12 => "QUEEN",
            //    11 => "JACK",
            //    _ => cardNo.ToString()
            //};
            //Console.WriteLine(cardName);

            //[0 , 1, ,1 , 2 , 3 , 5 , 8 , 13 , ..]
            //int one = 0;
            //int tow = 1;

            //int[] fib = new int[10];
            //fib[0] = one;
            //fib[1] = tow;
            //for(int i = 2; i < fib.Length; i++)
            //{
            //    fib[i] = one + tow;
            //    one = fib[i-1];
            //    tow = fib[i];
            //}
            //[0 , 1, ,1 , 2 , 3 , 5 , 8 , 13 , ..]

            //for(int i = 0 , prev = 0 , current = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(prev);
            //    int fibnew = prev + current;
            //    prev = current;
            //    current = fibnew;
            //}

            Console.ReadKey();
        }

    }




    public static class Extention
    {
        public static void Print<T>(this T[] source)
        {
            if (!source.Any())
            {
                Console.WriteLine("No Available Data ");
                return;
            }
            Console.Write("{ ");
            for (int i = 0; i < source.Length ; i++)
            {
                Console.Write(source[i]);
                Console.Write(i < source.Length-1 ? " , " : " }");
               
            }

        }
    }
}
