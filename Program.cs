﻿// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
Console.WriteLine("введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int sum = numberA*numberA;
Console.WriteLine(sum);
*/ 

/* Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB) {
    Console.WriteLine("yes");
} else {
    Console.WriteLine("No");
}
*/ 


/* Console.WriteLine("введите номер дня недели");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1) {
    Console.WriteLine ("Понедельник");
}
if (numberA == 2) {
    Console.WriteLine ("Вторник");
}
if (numberA == 3) {
    Console.WriteLine ("Среда");
}
if (numberA == 4) {
    Console.WriteLine ("Четверг");
}
if (numberA == 5) {
    Console.WriteLine ("Пятница");
}
if (numberA == 6) {
    Console.WriteLine ("Суббота");
}
if (numberA == 7) {
    Console.WriteLine ("Воскресенье");
}
if (numberA > 7 || numberA < 1) {
    Console.WriteLine ("Ошибка");
}
*/

/* Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) {
    Console.WriteLine(numberA);
} else {
    Console.WriteLine(numberB);
}
*/

/* Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число С");
int numberС = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberС) {
    Console.WriteLine(numberA);
} else 
    if (numberB > numberA && numberB > numberС) {
    Console.WriteLine(numberB);
} else
    if (numberС > numberA && numberС > numberB) { 
    Console.WriteLine(numberС);
} else
    Console.WriteLine("error");
 */

/* Console.WriteLine("введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0) {
    Console.WriteLine("четное");
} else {
    Console.WriteLine("нечетное");
}
*/

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
int [] result = new int [number/2];
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0){
    result [index] = i;
    index++;
    }
}
for (int i=0; i< result.Length; i++)
 Console.WriteLine(result[i]);



 