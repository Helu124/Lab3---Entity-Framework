using Lab3;

Menu();

//Console.WriteLine(books);
//AddOrRemove.Remove(found,books);

static void Menu()
{

    Console.WriteLine("[1] Search books in stores\n[2] Add books to store\n[3] Remove books from the store");

    int show = int.Parse(Console.ReadLine());

    switch (show)
    {
        case 1:
            {
                SearchStores();
                Console.WriteLine("[1] Show books in store ");

                int showBooksInStores = int.Parse(Console.ReadLine());
                Find.FindBooks(showBooksInStores, -2);

                break;
            }
        case 2:
            {
                Console.Clear();
                Console.WriteLine("[1] Add books to store stocks");

                int showStoresInput = int.Parse(Console.ReadLine());
                Console.Clear();

                int found = Find.SearchStore();

                Console.Clear();
                int books = Find.FindBooks(found, -2);

                AddBooks(found, books);

                break;
            }
        case 3:
            {

                Console.Clear();
                Console.WriteLine("[1] Remove books from store stocks");

                int showStoresInput = int.Parse(Console.ReadLine());
                Console.Clear();

                int found = Find.SearchStore();

                Console.Clear();
                int books = Find.FindBooks(found, -2);

                RemoveBooks(found, books);

                break;
            }
        default:
            Console.WriteLine("Invalid number");
            Console.Clear();
            Menu();
            break;
    }
}


static void SearchStores()
{
    Console.Clear();
    Find.SearchStore();
    Console.Clear();
}

static void AddBooks(int storeId, int bookId)
{
    Console.WriteLine("How many books do you want added to the store stocks?");
    AddOrRemove.Add(storeId, bookId);
}

static void RemoveBooks(int storeId, int bookId)
{
    Console.WriteLine("How many books do you want removed from the store stocks?");
    AddOrRemove.Remove(storeId, bookId);
}