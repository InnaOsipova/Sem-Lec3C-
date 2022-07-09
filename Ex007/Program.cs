//Задача 31: Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
//положительных элементов массива.

int[] Randomarray ()
{
    int[] array1 = new int [12];
    for( int i = 0; i< array1.Length; i++)
    {
        array1[i] = new Random().Next(-9,10);
    }
    return array1;
}
 
    int pos = 0;
    int neg = 0;
    foreach(int item in Randomarray())
    {
        pos += item > 0 ? item : 0;
        neg += item < 0 ? item : 0;    
    }

    Console.WriteLine($" сумма позитива {pos} сумма негатива {neg}");

    
