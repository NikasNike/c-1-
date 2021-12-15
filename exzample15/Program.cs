//string [,] table = new string[2, 5];
//table[1, 2] = "Yellow bum";
////table[0, 0] table [0,1]  - столбик
////table [0,0 ] table [1, 0] - строка
//for (int rows = 0; rows <2; rows++)
//{
//    for (int colums = 0; colums < 5; colums++)
//    {
//        Console.WriteLine($"{table[rows, colums]}-");
//    }
//}

//числа щас
int[,] matrix = new int[3,4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j<4; j++)
    {
        Console.Write($"{matrix[i, j]} ");   //выводит что в таблице
    
    }
Console.WriteLine( ); //перелетает на строчку вниз
}

matrix.GetLength(0)  //считает сколько чисел в каком либо столбике // 0 - номер первого значения

//  9минута