//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

System.Console.WriteLine("Задача 34");
int[] FillArray1()
{
    int[] arr = new int[4];
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(100,1000);
    }
    return arr;
}

int Search2(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
        count ++;
        }
    }
   return count;
}

int[]NewArr1 = FillArray1();

System.Console.WriteLine($"[{string.Join(", ", NewArr1)}]");

System.Console.WriteLine(Search2(NewArr1));


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

System.Console.WriteLine("Задача 36");
int[] FillArray2()
{
    int[] arr = new int[4];
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(-1000,1000);
    }
    return arr;
}

int SumArray(int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2==0)
        {
        sum += array[i];
        }
    }
   return sum;
}

int[]NewArr2 = FillArray2();

System.Console.WriteLine($"[{string.Join(", ", NewArr2)}]");

System.Console.WriteLine(SumArray(NewArr2));

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

System.Console.WriteLine("Задача 38");

int[] FillArray3()
{
    int[] arr = new int[4];
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(0,100);
    }
    return arr;
}

int MinMaxArray(int[] array)
{
    int i = 0;
    int max = array[i];
    int min = array[i];
    for (i=0; i<array.Length; i++)
    {
        if (array[i]>max)
        {
        max = array[i];
        }
        if (array[i]<min)
        {
            min=array[i];
        }
    }
   return max-min;
}

int[]NewArr3 = FillArray3();

System.Console.WriteLine($"[{string.Join(", ", NewArr3)}]");

System.Console.WriteLine(MinMaxArray(NewArr3));