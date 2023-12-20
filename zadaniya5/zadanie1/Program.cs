/* Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

Console.WriteLine("enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
Console.WriteLine("enter a position: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int m1 = Convert.ToInt32(Console.ReadLine());

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

int SearchEl() {
    if (n1 > n) {
        Console.WriteLine("there is no element");
    }
    else if (m1 > m) {
        Console.WriteLine("there is no element");
    }
    else {
        Console.WriteLine("your element is " + array[n1, m1]);      
    }
    return 0;
}

CreateArray();
Console.WriteLine("here's an array");
PrintArray();
SearchEl();