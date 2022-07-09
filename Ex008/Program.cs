//Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

//void  ChengeArray (int[] arr)
//{
//    for (int i=0 ; i< arr.Length; i++)
//    {
//        arr[i]= arr[i]*(-1); 
//        Console.Write(" "+arr[i]);
//    }
      
//}

//int[] array = new int[] { 1, -3, 5, -7, 9 }; 
//ChengeArray(array);






//Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

string  Surchnumber (int[] arr,  int num)
{
   for (int i=0 ; i< arr.Length; i++)
    {
        
        if (arr[i] == num)
        {
            
            return "присуиствует";
            
        }
    }
      return "отсутствует";
}

int[] array = new int[] { 1, -3, 5, -7, 9 }; 
Console.Write ("Введите искомое число  :");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(Surchnumber(array, number));
