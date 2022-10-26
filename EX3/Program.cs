// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и определяет, является ли этот день выходным.
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(да, выходной");
  }
  if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Разве это день недели?");
  }
  else Console.WriteLine("(рабочий день");
}
