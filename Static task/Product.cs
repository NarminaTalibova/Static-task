using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task
{
    public abstract class Product
    {
        private static int idCounter = 0;

        public int Id { get; } = ++idCounter;
        //public Product()
        //{
        //    Id = idCounter++;
        //}

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public abstract double TotalIncome { get; }

        public abstract void Sell(int count);

        public abstract void ShowInfo();
    }

}
