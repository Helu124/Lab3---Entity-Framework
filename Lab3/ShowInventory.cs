using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;
using Lab3.Models;
using Lab3.Data;

namespace Lab3
{
    public class ShowInventory
    {

        public static void Show(int StoreId)
        {
            
            using var context = new Lab2DatabaseContext();
            {
                var store = context.Inventories.Where(i => i.StoreId == StoreId).ToList();
                
                foreach (var item in store)
                {
                    var books = context.Books.Where(b => b.Isbn13 == item.Isbn).Select(b => b.Title).ToList();
                    Console.WriteLine($"Amount: {item.Stock}, Titles: {books[0]}");
                }
            }

        }
    }
}
