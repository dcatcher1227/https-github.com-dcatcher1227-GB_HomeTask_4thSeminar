//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Random random = new Random();
int size = 8;
int[] myArr = new int[size];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = random.Next(0, 99);
    Console.Write(myArr[i] + " ");
}
