using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task
{
    public class Book : Product
    {
        public string AuthorName { get; set; }

        public int PageCount { get; set; }

        public override double TotalIncome => Price * Count;

        public override void Sell(int count) { Count -= count; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Author Name: {AuthorName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
