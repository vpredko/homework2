Console.WriteLine ("Введите цифру: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number <= 5 & number >= 1)
    Console.WriteLine ("нет");
else if (number == 6 || number == 7)
    Console.WriteLine("да");
else
    Console.WriteLine ("нет такого дня недели");
    


