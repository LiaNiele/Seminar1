/* Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее. */
int num1;
 
int num2;

 //ввод данных

Console.Write("Введите первое число: ");              
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

//сравнение и вывод максимального

if(num1>num2) {
    Console.WriteLine("max= " + num1);
}
else {
    Console.WriteLine("max= " + num2);
}



/* Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел. */

int num1;

int num2;

int num3;

//ввод данных

Console.Write("Введите первое число: ");               
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

// задаем переменную макс

int max = num1;

// сравнение чисел

if(num2>max) {
    max = num2;
}
else {
    max = num1;
}                              

if(num3>max) {
    max = num3;
}
else{
    max = num1;
}

// вывод макс числа

Console.WriteLine(max);



/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). */

int num;

Console.WriteLine("Введите число: ");

num = Convert.ToInt32(Console.ReadLine());

// задаем переменную остаток от деления

int rod = num % 2;

if(rod == 0) {
    Console.WriteLine("Четное");
}
else {
    Console.WriteLine("Нечетное");
}



/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. */

int num;

// Ввод данных

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current<=num) {
    if(current % 2 == 0) {
        Console.Write(current + " ");
    }
    current++;
}

