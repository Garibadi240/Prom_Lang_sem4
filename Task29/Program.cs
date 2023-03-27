int [] array = new [8];
FillArray(array);
PrintArray(array);
// input
int number = GetNumberForNumber("Введите основание: ", "Ошибка ввода!");
int degree = GetNumberForDegree("Введите показатель: ", "Ошибка ввода!");

// logic

//output

FillArray(int[] array){
    int lenght = array.lenght;
    for (int i = 0; i < length; i++)
    {
        array[i]=new Random().Next(0.2);
    }
}

PrintArray(int[] array){
   int lenght = array.lenght; 
   Console.Write("[");
   for (int i = 0; i < length; i++)
   {
    Console.Write($"{array[i]}");
    if (i<lenght-1) Console.Write(", ");
   }
      Console.Write("]");
}