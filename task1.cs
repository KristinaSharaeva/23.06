using System;
Console.WriteLine("введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB) {
    Console.WriteLine(numberA);
} else {
    Console.WriteLine(numberB);
}