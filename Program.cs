
int[,] CreateMatrix(int min, int max)
{ 
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++) 
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t"); 
        }
        Console.WriteLine();
    }
}


int SumRow(int[] Row)
{
int sum=0; 
for (int i = 0; i < Row.Length; i++) 
  {
    sum += Row[i];
  }
return sum;
}

int FindMin(int[] Row)
{
int min = Row[0];
for (int i = 1; i < Row.Length; i++) 
   {
     if (Row[i]<min)
        {
            min = Row[i];
        }
   }
 return min;
}

int FindIndexMin(int[] Row)
{
int min = Row[0];
int IndexMin = 0;
for (int i = 1; i < Row.Length; i++) 
   {
     if (Row[i]<min)
        {
            min = Row[i];
            IndexMin = i;
        }
   }
 return IndexMin;
}

int Element(int[,] result)
{
Console.Write("Введите номер строки: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
if (numberRow > result.GetLength(0))
{
    Console.Write("В матрице нет строки с таким номером ");
    return -1;
}
else 
{
    Console.Write("Введите номер столбца: ");
    int numberColumn = Convert.ToInt32(Console.ReadLine());
    if (numberColumn > result.GetLength(1))
    {
        Console.Write("В матрице нет столбца с таким номером ");
        return -1;
    }
    else 
    return result[numberRow-1, numberColumn-1];
}
}

int[,] ReplaceRows (int[,] result)
{
int[] temp = new int[result.GetLength(1)]; 
for (int j = 0; j < result.GetLength(1); j++) 
  {
    temp [j] = result [0,j];
  }

int FirstRow = 0;
int LastRow = result.GetLength(0)-1;

for (int j = 0; j < result.GetLength(1); j++) 
  {
    result [FirstRow, j] = result [LastRow,j];
    result [LastRow,j] = temp[j];
  }
  return result;
}

int[] GetIndexMinElement(int[,] result)
{
int[] Index = new int[2];
int MinInArray = result[0,0];
for (int i = 0; i < result.GetLength(0); i++) 
{
    for (int j = 0; j < result.GetLength(1); j++) 
    {
        if (result [i,j]< MinInArray)
        {
            MinInArray = result [i,j];
            Index[0] = i;
            Index[1] = j;
        }
}
} 
Console.WriteLine($"Строка: {Index[0]+1}; Столбец: {Index[1]+1}\t");
return Index;
}

int[,] GetNewMatrix(int[,] result, int[] Index)
{
int [,] NewMatrix = new int[result.GetLength(0)-1, result.GetLength(1)-1];
  int row = 0; 
  int col = 0; 
for (int i = 0; i < result.GetLength(0); i++)
{
  if (i == Index[0]) continue;
for (int j = 0; j < result.GetLength(1); j++)
{
  if (j == Index[1]) continue;
    NewMatrix[row, col] = result[i, j];
    col++; 
}
col=0; 
row++; 
}
return NewMatrix;
}


// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] result = CreateMatrix(0, 100);
// PrintMatrix(result); 
// int FindElement = Element(result);
// if (FindElement != -1)
//     Console.WriteLine($"Элемент в массиве = {FindElement}\t");

// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int[,] result = CreateMatrix(0, 100);
// PrintMatrix(result);
// Console.WriteLine("Новая матрица: ");
// PrintMatrix(ReplaceRows(result));



// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.


// int[,] result = CreateMatrix(0, 10);
// PrintMatrix(result);
// int[] temp = new int[result.GetLength(1)]; 
// int[] ResultSum = new int [result.GetLength(0)];
// for (int i = 0; i < result.GetLength(0); i++) 
// {
//     for (int j = 0; j < result.GetLength(1); j++) 
//     {
//         temp [j] = result [i,j];
//         ResultSum [i] = SumRow(temp);
//     }
// }
// Console.WriteLine($"Сумма всех элементов в каждой строке: [ {string.Join("; ",ResultSum)} ]");
// Console.WriteLine($"Минимальная сумма чисел в строке  c индексом = {FindIndexMin(ResultSum)}"); 




// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива. Под удалением понимается 
// создание нового двумерного массива без строки и столбца


// int[,] result = CreateMatrix(0, 100);
// PrintMatrix(result);
// PrintMatrix(GetNewMatrix(result, GetIndexMinElement(result)));



