namespace Static_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 17;

            if (num.IsPrime())
            {
                Console.WriteLine($"{num} sadədir.");
            }
            else
            {
                Console.WriteLine($"{num} sadə deyil.");
            }
        }
    }
}