/* Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов. */

Console.WriteLine("enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int[,] array = new int[n, m];

void CreateArray() {
    for (int i = 0; i < n; i++) { 
        for (int j = 0; j < m; j++) {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray() {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}

int SearchSum() {
    int minSum = int.MaxValue; 
    int minSumIndex = -1; 

    for (int i = 0; i < n; i++) {
        int sum = 0;

        for (int j = 0; j < m; j++) {
            sum = array[i, j] + sum;
        }
        //Console.WriteLine("Sum for line " + i + ": " + sum);

        if (sum < minSum) {
            minSum = sum;
            minSumIndex = i;
        }
    }

    Console.WriteLine("Line with the smallest sum: " + minSumIndex);
    return minSumIndex;
}

CreateArray();
PrintArray();
Console.WriteLine("sumi");
SearchSum();