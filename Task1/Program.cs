//int[] arr = new int[5];
//arr[0] = 5;
//arr[1] = 7;
//arr[2] = 5;
//arr[3] = 4;
//arr[4] = 3;

//Console.WriteLine(arr[0]);
//Console.WriteLine(arr[1]);
//Console.WriteLine(arr[2]);
//Console.WriteLine(arr[3]);
//Console.WriteLine(arr[4]);

//int[] arr2 = new int [5] {1,2,3,4,5};

//int[] arr3 = {1,2,3,4,5};

//Создать массив и заполнить его целыми числами от 1 до N (N – произвольное
//натуральное число). Вывести элементы массива на экран.

//int n = 10;
//int[] arr = new int[n];
//int i = 0;

//while (i < arr.Length)
//{
//    arr[i] = i + 1;
///Console.Write(arr[i]);
///Console.Write(' ');
//   Console.Write($"{arr[i]} ");
// i = i + 1;
//}

//Создать целочисленный массив на 10 элементов и заполнить его произвольными
//числами. Вывести на экран чётные элементы массива

//int n = 10;
//int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
//int i = 0;
//while (i < array.Length)
//{
//   if (array[i] % 2 == 0)
//  {
//     Console.Write($"{array[i]} ");
//  }
// i = i + 1;
//}


//Дано N гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири.

int n = 5;
int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];


while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;

}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }

}
Console.WriteLine(max);

max = array[0];
foreach(int e in array)
{   
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);