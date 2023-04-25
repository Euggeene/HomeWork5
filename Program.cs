// *HomeWork5*

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] numArr = new int[5];

// int num =0;

// for(int i=0; i<numArr.Length; i++)
// {
// numArr[i]=new Random().Next(100,1000);

// if (numArr[i]%2 == 0)
//    {
//     num=num+1;
//    }
// }
// Console.WriteLine(String.Join(",",numArr));
// Console.WriteLine("Количество чётных чисел = "+num);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] numArr = new int[5];

// int sum =0;

// for(int i=0; i<numArr.Length; i++)
// {
// numArr[i]=new Random().Next(-99,100);

// if (i % 2 == 0)
//    {
//     sum = sum + numArr[i];
//    }
// }
// Console.WriteLine(String.Join(",",numArr));
// Console.WriteLine("Сумма чисел, стоящих на нечётных позициях = "+sum);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

// int[] numArray = new int[5];

// for(int i=0; i<numArray.Length; i++)
// {
// numArray[i]=new Random().Next(0,100);
// }

// int diff = numArray.Max() - numArray.Min();

// Console.WriteLine(String.Join(",",numArray));
// Console.WriteLine("Разница между максимальным и минимальным элементом массива = "+diff);