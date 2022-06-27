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