Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Компьютер загадывает число от 1 до 10...");
Console.WriteLine("Ваша задача - отгадать это число. Удачи! ;-)");
int num = new Random().Next(1, 10);
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num == num1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Вы победили! Ура-ура!!!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Вы проиграли! Попробуйте ещё раз. :-(");
    Console.Write("Загаданное число - ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(num);
}