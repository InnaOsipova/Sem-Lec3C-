//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//int  Count2 (string str)
//{
//    int count =  str.Length;
//    return count;
//}

//Console.WriteLine(Count2("2345456"));

//int Count23 (int num)
//{
//    int i = 0;
//    while ((num) > 0)
//    {
//        i++;
//        num = num/10;
//    }
//    return i;
//}
//Console.WriteLine(Count23(777555777));

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//int Count23 (int num)
//{
//   int p1 = 1;
//   for (int i = 1; i<=num; i++ )
//{
//    p1 = p1 * i;
//}
//return p1;
//}
//Console.WriteLine(Count23(2));

//int Function(int num)
//{
//    if (num == 0) return 1;
 
//    return num * Function(num - 1);
//}

//Console.WriteLine(Function(0));


//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void Function1 ()
{
    int[] array = new int[8];
    for( int i= 0; i<=7; i++)
    {
       array[i] =  new Random().Next(0,2);
       Console.WriteLine(array[i]);
    }
     
    
}

Function1();