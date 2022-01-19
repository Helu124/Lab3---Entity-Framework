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
    public class AddOrRemove
    {
        public static int SearchStore()
        {
            using var context = new Lab2DatabaseContext();
            {
                var store = context.Stores.ToList();

                foreach (var item in store)
                {
                    Console.WriteLine($"({item.Id}) {item.StoreName}");
                }

                int id;
                string input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    return id - 1;
                }
                return -1;
            }
        }

        public static int FindBooks(int storeId, int addOrRemove)
        {
            using var context = new Lab2DatabaseContext();
            {
                var books = context.Books.ToList();
                var inventory = context.Inventories.ToList();

                switch (addOrRemove)
                {
                    case -2:
                        {
                            inventory = context.Inventories.Where(i => i.StoreId == storeId).ToList();
                            break;
                        }
                    default:
                        break;
                }
                foreach (var item in inventory)
                {
                    Console.WriteLine(books);
                }
            }

            return 0;
        }

    }
}
