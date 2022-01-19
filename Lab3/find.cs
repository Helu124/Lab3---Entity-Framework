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
    public class find
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
                    return id;
                }
                return -1;
            }
        }

        public static int FindBooks(int storeId, int addOrRemove)
        {
            using var context = new Lab2DatabaseContext();
            {
                var amount = context.Books.Count();
                var books = context.Books.ToList();
                var inventory = context.Inventories.ToList();

                switch (addOrRemove)
                {
                    case -2:

                        {
                            inventory = context.Inventories.Where(i => i.StoreId == storeId)
                                                           .ToList();
                            for (int i = 0; i < inventory.Count; i++)
                            {
                                int j = i + 1;
                                books = context.Books.Where(b => b.Isbn13 == inventory[i].Isbn).ToList();
                                
                                Console.WriteLine($"({j}) titel: {books[0].Title} amount: {inventory[i].Stock}");
                            }

                            break;
                        }
                    default:
                        {
                            int i = 0;
                            foreach (var item in books)
                            {i++;
                                Console.WriteLine($"({i}) titel:{item.Title}");
                            }

                            break;

                        }
                        
                }
                int bookindex;

                string input2 = Console.ReadLine();
                if (int.TryParse(input2, out bookindex))
                {
                    return bookindex-1;

                }


            }

            return 0;
        }

    }
}
