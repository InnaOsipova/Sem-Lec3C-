//Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

string ShowCoord ( int number)
{
    switch (number)
    {
        case  1: 
        {
            return " x > 0 и у >0";
            
        }
        case 2: 
         {   
            return " x < 0 и у >0";
            
         }
        case  3: 
         {   
            return " x < 0 и у <0";
            
         }
        case  4: 
        {
            return " x > 0 и у < 0";
            
        }
    }
    return "ошибка";
}

Console.Write ("Введите номер четверти : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write(ShowCoord(num));
