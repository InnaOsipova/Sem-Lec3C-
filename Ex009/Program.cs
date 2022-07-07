//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] Randomarray ()
{
    int[] array1 = new int [123];
    for( int i = 0; i< array1.Length; i++)
    {
        array1[i] = new Random().Next(-100,1000);
    }
    return array1;
}
 
    int kol = 0;
    
    foreach(int item in Randomarray())
    {
        if (item >= 10 ) 
        {   if(item <= 99)
            { 
               kol++;  
            }
        }
    }

    Console.WriteLine($" количество {kol}");

    