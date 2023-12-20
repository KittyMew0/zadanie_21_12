/* Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
и последнюю строку массива. */

Console.WriteLine("enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
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

void ChangeArray() {
    int temp;
    for (int j = 0; j < m; j++) {
        temp = array[n - 1, j];
        array[n - 1, j] = array[0, j];
        array[0, j] = temp;
    }
}

CreateArray();
Console.WriteLine("here's an array");
PrintArray();
ChangeArray();
Console.WriteLine("new array");
PrintArray();