using Task3;

System.Console.Write($"Enter a day: ");
int day = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Enter a month: ");
int month = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

Date date1 = new Date(day, month, year);


System.Console.WriteLine();

System.Console.WriteLine($"Date: {date1.ToString()}");