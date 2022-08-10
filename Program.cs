// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    Console.WriteLine($"{firstNumber} > {secondNumber}");  
else if (firstNumber < secondNumber)
    Console.WriteLine($"{firstNumber} < {secondNumber}");  
else
    Console.WriteLine($"{secondNumber} = {firstNumber}");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max;
if (firstNumber > secondNumber)
    max = firstNumber;    
else
    max = secondNumber;
if (thirdNumber > max)
    max = thirdNumber;
Console.WriteLine("Max number is " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int balance = number % 2;
if (balance == 0)
    Console.WriteLine("Number is even");
else
    Console.WriteLine("Number is odd");
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if (i + 2 <= number)
        {
            Console.Write(", ");
        }
    }
    i++;
}
*/