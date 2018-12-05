using EntityFrameWork.Data;
using EntityFrameWork.Models;
using System.Collections.Generic;
using System.Linq;
namespace EntityFrameWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICollection<Item> items = null;
            using(var context=new ShopContext())
            {
               items=context.Items.ToList();
                context.Items.Add(new Item
                {
                    Name = "tea",
                    Price = 400
                });
                context.SaveChanges();
            }
            foreach(var item in items)
            {
                System.Console.WriteLine(item.Name);
            }
        }
    }
}
