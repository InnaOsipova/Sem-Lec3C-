//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

string FindQvart(int x, int y)
{
   if (x>0 && y>0)   return "1";
   if (x>0 && y<0)   return "4";
   if (x<0 && y>0)   return "2";
   if (x<0 && y<0)   return "3";
   return "не работает";
   
}  


Console.Write ("Введите X :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите Y :");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindQvart(x1,y1));
