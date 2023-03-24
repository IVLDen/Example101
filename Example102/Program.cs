// Задача 54

/* int [,] arr = new int [3,4] ;

void FillArr (int [,] arrr) {

Random rand = new Random();

    for (int i = 0; i < arrr.GetLength(0); i++){

    for (int j = 0; j < arrr.GetLength(1); j++){
        arrr [i, j] = rand.Next (1, 20);
    }
    }

}

void PrintArr (int [,] arrr) {

  for (int i = 0; i < arrr.GetLength(0); i++){

     Console.WriteLine();
    for (int j = 0; j < arrr.GetLength(1); j++){
     Console.Write(arrr[i,j] + " ");
}
}
}


void OrderArr (int [,] arrr) {
 
  
  int temp;

  for (int i = 0; i < arrr.GetLength(0); i++){
    for (int j = 0; j < arrr.GetLength(1); j++){
       for (int k = j+1; k <= arrr.GetLength(0); k++){
           
      if (arrr[i,k] > arrr[i,j]) {

       temp = arrr[i,j];
       arrr[i,j] = arrr[i,k];
       arrr[i,k] = temp;
       }
    }
} 
} }

FillArr(arr);
PrintArr(arr);
Console.WriteLine();

OrderArr(arr);
PrintArr(arr);
*/

//--------------------------------------------------------------------------------------------------

// Задача 56

/* int [,] arr = new int [3,4] ;

void FillArr (int [,] arrr) {

Random rand = new Random();

    for (int i = 0; i < arrr.GetLength(0); i++){

    for (int j = 0; j < arrr.GetLength(1); j++){
        arrr [i, j] = rand.Next (1, 20);
    }
    }

}

void PrintArr (int [,] arrr) {

  for (int i = 0; i < arrr.GetLength(0); i++){

     Console.WriteLine();
    for (int j = 0; j < arrr.GetLength(1); j++){
     Console.Write(arrr[i,j] + " ");
}
}
}

int OrderArr (int [,] arrr) {
 
  
  int sum = 0;
  int min = 999;

  for (int i = 0; i < arrr.GetLength(0); i++){
    for (int j = 0; j < arrr.GetLength(1); j++){
       sum = sum + arrr[i,j]; 
    }
        if (sum < min) min = sum;

} 
return min;
}

FillArr(arr);
PrintArr (arr);
Console.WriteLine();

int min = OrderArr(arr);
Console.WriteLine();
Console.WriteLine(min); */

//----------------------------------------------------------------------------------------------------------------


// Задача 58: 

/*
Random rnd = new Random();
 int[,] array2D = CreateMatrix(rnd.Next(2,4), rnd.Next(2, 4), 0, 9);
    int[,] matrix = CreateMatrix(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);

 
static int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}|");
            else Console.Write($"{matrix[i, j],1}");
        }
        Console.WriteLine("|");
    }
}
static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


   
    PrintMatrix(array2D);
    Console.WriteLine();
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintMatrix(DivMatrix(array2D, matrix));
    Console.ReadLine();
*/

//Задача 60

/*Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
} */


// Задача 62

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);


void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}