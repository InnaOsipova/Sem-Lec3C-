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
    int[] transarray = Randomarray();
    Array.Reverse(transarray); 
    Console.WriteLine();
    for (int i  = 0; i < array.Length/2 ; i++)
    {
           Console.WriteLine($"{array[i]} * {transarray[i]} = {array[i]*transarray[i]}");
        
    
    }
    
    
   