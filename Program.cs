namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=2, b=3;
            Console.WriteLine($"{a} : {b}");
            Console.WriteLine();

            Swapper<int>.Swap(ref a, ref b );
            Console.WriteLine($"{a} : {b}");




        }
    }
    class Swapper<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
    
}