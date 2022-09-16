//case 1
Console.WriteLine ("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int NumberB = int.Parse(Console.ReadLine() ?? "0");
if (NumberA > NumberB)
{
Console.Write("Первое число больше второго");
}
if (NumberA < NumberB)
{
Console.Write("Первое число меньше второго");
}
if (NumberA == NumberB)
{
Console.Write("Числа равны");
}
//case 2
Console.WriteLine (" Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите первое число: ");
int NumA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int NumB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третье число: ");
int NumС = int.Parse(Console.ReadLine() ?? "0");
int max = NumA;
if (NumA>max) max = NumA;
if (NumB>max) max = NumB;
if (NumС>max) max = NumС;
Console.Write("Ваше максимальное число: ");
Console.Write(max);
//case 3
Console.WriteLine ("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Введите число: ");
int NumA = int.Parse(Console.ReadLine() ?? "0");
if (NumA % 2 == 0) Console.Write("Четное");
else Console.Write("Нечетное");
//case 4
Console.Clear();
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
int i = 1;
bool not = true;
Console.WriteLine("Введите число:");
int num = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
}
i++;
}
if (not)
{
Console.WriteLine("Нет чётных чисел!");
}