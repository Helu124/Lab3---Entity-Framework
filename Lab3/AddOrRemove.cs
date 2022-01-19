using Lab3;
using Lab3.Data;
using Lab3.Models;

namespace Lab3
{
    public class AddOrRemove

    {
        static public void Add(int storeId, int bookId)
        {



            using var context = new Lab2DatabaseContext();
            {
                var inventory = context.Inventories.Where(i => i.StoreId == storeId).ToList();
                var book = context.Books.Select(b => b.Isbn13).ToList();
                var count = context.Inventories.Count();
                if (inventory.Exists(i => i.Isbn == book[bookId]))
                {
                    Console.WriteLine(" Hur många böker vill du ha?");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int amount))
                    {


                        foreach (var found in inventory)
                        {
                            if (found != null && found.Isbn == book[bookId] && found.StoreId == storeId)
                            {
                                found.Stock = amount + found.Stock;
                                context.SaveChanges();
                            }
                        }


                    }
                }
                else if (inventory.Exists(i => i.Isbn != book[bookId]))

                {
                    Console.WriteLine(" Hur många böker vill du ha?");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int amount))
                    {
                        var newInventory = new Inventory { Isbn = book[bookId], StoreId = storeId, Stock = amount };
                        context.Inventories.Add(newInventory);
                        context.SaveChanges();


                    }
                }


            }


        }
        public static void Remove(int storeId, int bookId)
        {
            using var context = new Lab2DatabaseContext();
            {
                var inventory = context.Inventories.Where(i => i.StoreId == storeId).ToList();
                var book = context.Books.Select(b => b.Isbn13).ToList();
                var count = context.Inventories.Count();
                if (inventory.Exists(i => i.Isbn == book[bookId]))
                {
                    Console.WriteLine(" Hur många böker vill du ta bort?");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int amount))
                    {


                        foreach (var found in inventory)
                        {
                            if (found != null && found.Isbn == book[bookId] && found.StoreId == storeId)
                            {

                                found.Stock = found.Stock - amount;
                                if (found.Stock <= 0)
                                {
                                    context.Inventories.Remove(found);
                                }
                                context.SaveChanges();
                            }
                        }


                    }
                }

            }
        }
    }
}
