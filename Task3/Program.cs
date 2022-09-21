// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int namber = Convert.ToInt32(Console.ReadLine());
if (namber > 1 && namber < 6)
{
Console.WriteLine( "Ввведенное число " + namber + " соответсвует дню недели и это не выходной :(");
}
else if (namber == 6 || namber == 7)
{
    Console.WriteLine( "Ввведенное число " + namber + " соответсвует  дню недели. И это выходной !!!");
} 
else
{
Console.WriteLine( "Ввведенное число " + namber + " не соответсвует дню недели.");
}