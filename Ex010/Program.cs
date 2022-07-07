//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.


int[] Randomarray ()
{
    int[] array1 = new int [11];
    for( int i = 0; i< array1.Length; i++)
    {
        array1[i] = new Random().Next(-10,10);
        Console.Write ("  "+array1[i]);
    }
    return array1;
}
   
    int[] array = Randomarray();
     Console.WriteLine();
    for (int i  = 0; i < array.Length ; i++)
    {
        for ( int j = array.Length-1-i; j >=i; j--)
        {
           Console.WriteLine($"{array[i]} * {array[j]} = {array[i]*array[j]}");
           break;
        }
    
    }
    
    
   
    