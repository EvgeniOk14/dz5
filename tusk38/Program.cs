void InputArray(double[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(-10000, 10000); 
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

Double RealeaseArray(double[] array)
{
    double min = 0;
    double max = 0;
    Double diff = 0;
  for(int i = 0; i < array.Length; i++)
  {
   if (array[i] < min) 
     min = array[i];
        if (array[i] > max) 
            max = array[i];
  }
     diff = max - min;  
    Console.WriteLine("max = " + " " + max);
    Console.WriteLine("min = " + " " + min);
  return diff;
  }
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
double[] array = new double[n]; 
InputArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("max - min = "+ " " + RealeaseArray(array));
