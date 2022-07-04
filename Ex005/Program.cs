// Дан текст, в этом тексте все пробелы заменить на черточки
// Все маленькие к заменить на большие  К, все большие С заменить на маленькие с.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
              +"ежели бы вас послали вместо нашего милого"
              +"Винценгероде, вы бы взяли приступом согласие"
              +"прусского короля. Вы так красноречивы. Вы"
              +"дадите мне чаю?";


string Replase (string text, char oldValue, char newValue)
{
   string result = String.Empty;
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
     if (text[i] != oldValue) result = result + $"{text[i]}";
     else result = result + $"{newValue}";
     
   }

   return result;

} 

string newText = Replase(text, ' ', '|');
Console.WriteLine();
Console.WriteLine(newText);
newText = Replase(newText, 'к', 'К');
Console.WriteLine();
Console.WriteLine(newText);
newText = Replase(newText, 'с', 'С');
Console.WriteLine();
Console.WriteLine(newText);