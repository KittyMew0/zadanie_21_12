/* Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением 
понимается создание нового двумерного массива без строки и столбца */   

Console.WriteLine("enter array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
int[,] array2 = new int[n - 1, m - 1];
//int minel = 0, mini = 0, minj = 0;

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

void Search() {
    int minel = array[0, 0], mini = 0, minj = 0;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (minel > array[i, j]) {
                minel = array[i, j];
                mini = i;
                minj = j;
            }
        }
    }
    Console.WriteLine("min i = " + mini + "min j = " + minj);

    int newRow = 0;
    for (int i = 0; i < n; i++) {
        if (i == mini) {
            continue;
        }
        int newCol = 0;
        for (int j = 0; j < m; j++) {
            if (j == minj) {
                continue;
            }

            array2[newRow, newCol] = array[i, j];
            Console.Write(array[i, j] + " ");
            newCol++;
        }

        Console.WriteLine();
        newRow++;
    }
}

CreateArray();
PrintArray();
Search();