//Задача 41: Пользователь вводит с клавиатуры M чисел.
 //Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/*Console.WriteLine("Сколько чисел M будет введено?");
int m = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите число №{index + 1}:");
        int N = Convert.ToInt32(Console.ReadLine());
        array[index] = N;
        index++;
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

int[] array = new int[m];
// int count = array.Length;

FillArray(array);
Console.WriteLine("вы ввели: ");
PrintArray(array);
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) res += 1;
}
Console.WriteLine(" ");

Console.WriteLine($"из них чисел больше 0 = {res}");
*/


//Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("значения b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("значения k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("значения b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("значения k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double point1 = (b2 - b1) / (k1 - k2);
double point2 = (k1 * b2 - k2 * b1) / (k1 - k2);

if (k1 != k2)
{
    Console.WriteLine("");
    Console.WriteLine($"прямые имеют точку пересечения ({point1:f2} ; {point2:f2})");
}
else
{
    if (b1 == b2)
    {
        Console.WriteLine("прямые совпадают, а не являются параллельными");
    }
    else
    {
        Console.WriteLine("прямые параллельны");
    }
}

