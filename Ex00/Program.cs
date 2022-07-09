//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.

int Sqrt2 (int num)
{
    //int count = 0;
   // int[] array = new int [num-1];
    // while (count < num)
    // {
       int a  = num * num;
        //Console.WriteLine(array[count]);
     //   count++;
    // }
     return a;
}

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int index =1;
while(index <= number)
{
    Console.WriteLine(Sqrt2(index));
    index++;
}



