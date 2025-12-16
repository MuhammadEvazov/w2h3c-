using Task1;

System.Console.Write($"Enter the Title of the book: ");
string title = Console.ReadLine();

System.Console.Write($"Enter the author of the book: ");
string author = Console.ReadLine();

System.Console.Write($"Enter a year the book published: ");
int year = Convert.ToInt32(Console.ReadLine());

Book book1 = new Book(title, author, year);

book1.GetInfo();
System.Console.WriteLine($"Is the book published recently? {book1.IsPublishedRecently()}");