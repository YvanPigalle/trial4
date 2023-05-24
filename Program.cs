//Задача: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.



/*

Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B ");
int b = Convert.ToInt32(Console.ReadLine());
int pwr = a;

for (int i = 1; i < b; i++)
{
pwr *= a;
}
Console.WriteLine("Power of A for B is: " + pwr);

*/





//Задача: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*

Console.Write("Input number: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("The sum of all digits of this number: " + sum);

*/



//Задача: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



int [] Create8Array (int size, int minVal, int maxVal)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void  ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    Console.Write (array1[i]+ " ");
    Console.WriteLine();
}

int sizeArray = 8;
int minVal = -999;
int maxVal = 999;

int [] createdArray = Create8Array(sizeArray, minVal, maxVal);
ShowArray(createdArray);