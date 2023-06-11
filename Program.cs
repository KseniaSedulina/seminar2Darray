//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*double[,] Create2dArray ()
{
    Console.WriteLine("Enter count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double [,] created2dArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
    for (int j = 0; j < columns; j++)
    {
        created2dArray [i,j] = new Random().Next (minVal, maxVal + 1);
    }
    }
    return created2dArray;
}

void Print2Array (double[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write (array2d [i,j] + " ");
        }
        Console.WriteLine ();
        }
Console.WriteLine ();
}
double[,] new2dArray = Create2dArray ();
Print2Array(new2dArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
// у пользователя нужно запросить 2 величины: 1 отвечает за номер строки, 2 - за номер столбца.
// если элемент физически существует, то пользователю выводится ЗНАЧЕНИЕ.

/* 
int m = 5;
int n = 5;
int [,] arr = new int [m, n];
Console.WriteLine("Enter the value: ");
int number = Convert.ToInt32(Console.ReadLine());
FillArray (arr);
FindElementArray (arr, number);

void FillArray(int [,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
        {        
            for (int j = 0; j < arrayToFill.GetLength(1); j++)
            {
                arr [i,j] = new Random().Next(1, 10);
                Console.Write (arrayToFill [i,j] + " ");
            }   
            Console.WriteLine ();
        }
}

void FindElementArray (int [,] FindElement, int usernumber)
{
    bool find = false;
    for (int i = 0; i < FindElement.GetLength(0); i++)
    {
        for (int j = 0; j < FindElement.GetLength(1); j++)
        {
            if (FindElement [i,j] == usernumber)
            Console.WriteLine("Your value is located at the coordinates" + i + " " + j);            find = true;
        
        }   
    }
    if (!find)
    Console.WriteLine ("Your value does not exist in this array");
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// нужно идти сначала по столбцам, потом в каждом столбце идти сверху вниз. 2 цикла: внешний и внутренний. Нужно идти по строке j 

Console.WriteLine("Enter count of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter count of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine(" ");
    }
}
