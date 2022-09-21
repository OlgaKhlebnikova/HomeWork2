// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int RandomNum = new Random().Next(1,1000000000);
Console.WriteLine($"Число: {RandomNum}");
if (RandomNum < 100)
{ 
    Console.WriteLine($"Третьей цифры в числе  {RandomNum} нет " );
}
 
else
{
    Console.WriteLine($"Третьей цифрой в числе  {RandomNum} является {RandomNum.ToString()[2]}" );
}




