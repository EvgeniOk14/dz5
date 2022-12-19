void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(array.Length);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int RealeaseArray(int[] array, int n)
{
  
    int Sum = 0;
  for(int i = 0; i < array.Length; i++)
  {
   if (i % 2 != 0)
     Sum = Sum + array[i];  
  }
  return Sum;
  
}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(RealeaseArray(array, n));
