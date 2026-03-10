using System.Collections.Concurrent;
using System.Diagnostics;

namespace ParallelProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter path: ");
            //string path = Console.ReadLine();

            //string[] files = Directory.GetFiles(path, null, SearchOption.AllDirectories);

            //long totalSize = 0;

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            ////    //for (int i = 0; i < files.Length; i++)
            ////    //{
            ////    //    FileInfo f = new FileInfo(files[i]);
            ////    //    totalSize += f.Length;
            ////    //}
            //Parallel.For(0, files.Length, () => 0,
            //    (index, loop, subtotal) =>
            //    {
            //        FileInfo f = new FileInfo(files[index]);
            //        subtotal += (int)f.Length;
            //        return subtotal;
            //    }, subtotal => Interlocked.Add(ref totalSize, subtotal));
            //sw.Stop();

            //Console.WriteLine($"Total Size: {totalSize} bytes\nTime: {sw.ElapsedMilliseconds} ms");

            //var limit = 36_000_000;
            //var numbers = Enumerable.Range(0, limit);
            //var primesCount = 0;

            ////List<long> primes = new List<long>();
            //Stopwatch sw = Stopwatch.StartNew();
            //////foreach (var number in numbers)
            //////{
            //////    if (IsPrime(number)) primes.Add(number);
            //////}
            //////var primes = numbers.Where(IsPrime).ToList();
            ////var primes = new ConcurrentBag<int>();
            //Parallel.ForEach<int, int>(numbers, () => 0,
            //    (number, loopState, subtotal) =>
            //    {
            //        if (IsPrime(number)) subtotal++;
            //        return subtotal;
            //    }, subtotal => Interlocked.Add(ref primesCount, subtotal));
            //sw.Stop();
            //Console.WriteLine($"Primes count: {primesCount}. Time: {sw.ElapsedMilliseconds} ms.");

            //var source = Enumerable.Range(0, 1_000_000);
            //var evenNums = from num in source.AsParallel().WithMergeOptions(ParallelMergeOptions.NotBuffered)
            //               where num % 2 == 0
            //               select num;

            //foreach (var evenNum in evenNums)
            //{
            //    Console.WriteLine(evenNum);
            //}

            //Console.WriteLine(evenNums. Count());
        }

        private static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(num); divisor++)
            {
                if (num % divisor == 0)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
