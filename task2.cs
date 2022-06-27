Console.WriteLine("введите число A");
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
