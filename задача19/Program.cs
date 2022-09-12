// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;


bool isPolindrom = Polindrom(number);

string txt = isPolindrom == true? "палиндром" : "Не палиндром";
Console.WriteLine(txt);

bool Polindrom(string number)
{
for (int i = 0; i < number.Length / 2; i++)
{
if (number[i] != number[number.Length - i - 1])
return false;
}
return true;
}
