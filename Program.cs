// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int [,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min,max+1);
    return array;
}

void Show2dArray(int[,] array){ 
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

// int[,] Sort(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         int temp = 0;
//         for(int x=0; x < array.GetLength(1); x++){
//             for(int j=0; j < array.GetLength(1)-1; j++){
//                 if (array[i,j] < array[i,j+1]){
//                     temp = array[i,j];
//                     array[i,j]=array[i,j+1];
//                     array[i,j+1]=temp;
//                 }
//             }
//         } 
//     }
//     return array;
// }

// Console.Write("Input num of rows "); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of cols "); 
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of min "); 
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of max "); 
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// int[,] array1 = Sort(array);
// Show2dArray(array1);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void MinimumSum(int[,] array, int rows){
//     int[] sum = new int[rows];
//     sum[0] = 0;
//         for(int i = 0; i < array.GetLength(0); i++){
//             for(int j=0; j < array.GetLength(1); j++){
//                  sum[i] += array[i,j];
//             }
//         }
//     int minimum = sum[0];
//     int index = 0;
//     for(int i=1; i<sum.Length; i++){
//         if(sum[i] < minimum){
//             minimum = sum[i];
//             index = i;
//         }
//     }        
// Console.WriteLine($"{index} - строка с наименьшей суммой элементов");
// }

// Console.Write("Input num of rows "); 
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of cols "); 
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of min "); 
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input num of max "); 
// int max = Convert.ToInt32(Console.ReadLine());

// if (rows == cols)
//    Console.Write("Задан квадратный массив. Количество строк не должно быть ровно количеству столбцов."); 
// else{   
//    int[,] array = CreateRandom2dArray(rows,cols,min,max);
//    Show2dArray(array);
//    Console.WriteLine();
//    MinimumSum(array, rows);
// }   


// Напишите программу, которая заполнит спирально массив 4 на 4.




int[,] Spiral(int[,] array){
    int element = 1;
    while(element<16){
        for(int j=0; j<4; j++){
            int i =0;
            array[i,j]=element;
            element +=1;
        }
        for(int i=1; i<4; i++){
            int j =3;
            array[i,j]=element;
            element +=1;
        }
        for(int j=2; j>=0; j--){
            int i=3;
            array[i,j]=element;
            element +=1;
        }
        for(int i=2; i>0; i--){
            int j =0;
            array[i,j]=element;
            element +=1;
        }
        for(int j=1; j<3; j++){
            int i=1;
            array[i,j]=element;
            element +=1;
        }
        for(int j=2; j>0; j--){
            int i=2;
            array[i,j]=element;
            element +=1;
        }    
                
    }
    return array;
}

Console.WriteLine("Заполним массив по спирали "); 
int[,] array = new int[4,4];
Spiral(array);
Show2dArray(array);
