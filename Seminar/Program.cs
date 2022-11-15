//Console.Write("Good morning");

//int number = 11;
//Console.WriteLine("Доброе утро! Сегодня" + number+ " ноября");
//Console.Write($"Доброе утро! Сегодня {number} ноября");
//Console.WriteLine("Input your number:");
//Console.ReadLine();
//int number = Convert.ToInt32(Console.ReadLine());

//Напишите программу,которая на вход принимает число и выдает его квадрат

/*Console.WriteLine("input you numbe:");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
Console.WriteLine($"квадрат {number} будет {result}");*/

//Напишите программу которая на вход принимает два числа ,и проверяет является ли первое число 
//квадратом второго числа.
 //a=25 .b=5  ->yes
 //a=2   b=10 ->no
 //a=9   b=-3 ->yes
 //a=-3  b=9  ->no


/* Console.WriteLine("Введите первое число:");
 int number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число:");
 int number2 = Convert.ToInt32(Console.ReadLine());

 if ( number2*number2==number1)
 {
      Console.WriteLine($"Число {number1} является квадратом {number2}");
 }
 else Console.WriteLine($"Число {number1} Не является квадратом {number2}");
 */

// Напишите программу которая на вход принимает число (N),
 //а на выходе показывает все целые числа от -N до N.    
 

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);
while (current<= number)
 {
    Console.WriteLine(current +"" );
    current++;
 }
 
 

/*Напишите программу которая на вход принимает трехзначное число и
на выходе показывает последнее цифру этого числа.*/
/*
456->6
782->2
918->8

246/100 ->2
246/10 ->24

246 % 100 -> 46
246 % 10 -> 6


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >99 && number < 1000){
    int current = number % 10;
    Console.WriteLine($"последнее число {number} - {current}");}
else
{
    Console.WriteLine("Число не трехзначное");
}   */   