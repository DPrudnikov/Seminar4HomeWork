// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = {1,4,6,16,5,5,32,7};

int length = array.Length;
int count = 0;

while (count < length)
{
    Console.WriteLine (array[count]);
    count++;
}
Console.WriteLine ("End");