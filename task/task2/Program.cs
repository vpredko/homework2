Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number2 = Convert.ToString(number);
if  (number <= 99)
    Console.WriteLine("третьей цифры нет");
else
    Console.WriteLine("третья цифра -> " + number2[2]);
