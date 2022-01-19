using Lab3;

int found = AddOrRemove.SearchStore();
int input = int.Parse(Console.ReadLine());
int books = AddOrRemove.FindBooks(found, input);
Console.WriteLine(books);



//string input = Console.ReadLine();

//switch (input)
//{
//    case "1":
//        {
//            ShowInventory.Show(1);
//            break;
//        }
//        case "2":
//        {
//            ShowInventory.Show(2);
//            break;
//        }
//        case"3":
//        {
//            ShowInventory.Show(3);
//            break;
//        }
//    default:
//        break;
//}