void InputArray(int[] array)
{
    for (int i=0; i < array.Length; i++)
     array[i] = new Random().Next(99,999);
}
void PrintArray(int[]array) 
{
    Console.Write($"[{String.Join(", ", array)}]");
}
     
         int ReleaseArray(int[] array, int n)
        { 
      
             int SumIndex = 0;
        
                 for (int i = 0; i < array.Length; i++)
               {
               
                  if (array[i] % 2 == 0)
               
                    SumIndex = SumIndex + 1;
               }
    
            return SumIndex;
      }

 Console.Clear();
 Console.Write("Введите число элементов массива: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int [] array = new int [n];
 InputArray(array);
 PrintArray(array);
 Console.WriteLine();
 ReleaseArray(array, n);
 Console.WriteLine("Количество нечётных элементов равно: " + ReleaseArray(array, n));
