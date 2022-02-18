using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string Name;
        public int Price;
        public int Count;
        public int TotalIncome;
        public Product(string name,int price,int count,int totalincome)
        {
            Name = name;
            Price = price;
            Count = count;
            TotalIncome = totalincome;
        }
        public string Sell()
        {
            if (Count<=0)
            {
                return "mehsul qoqku";
            }
            else
            {
                Count--;
                TotalIncome += Price;
                return "satis ugurla heyata kecirildi";
            }
        }
        public string Info()
        {
            return $"Name={Name}\nPrice={Price}\nCount={Count}\nTotalIncome={TotalIncome}";
        }
    }
}
