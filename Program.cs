// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, этот день выходным

Console.WriteLine("Введите день недели: ");
int x = int.Parse(Console.ReadLine()!);

if (x <= 5)
{
    Console.WriteLine("Это будний день");
}
else if(x <= 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Ошибка введите день недели");
}