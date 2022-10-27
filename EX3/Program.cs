// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и определяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
  if (dayNumber == 6 || dayNumber == 7) 
  Console.WriteLine("да, выходной");
  else 
  if (dayNumber < 1 || dayNumber > 7) 
  Console.WriteLine("Разве это день недели?");
  else 
  Console.WriteLine("рабочий день");

