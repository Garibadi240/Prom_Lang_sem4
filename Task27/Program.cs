Console.Clear();
// input
int number = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");

// logic

//output
Console.WriteLine($"{number} -> {SumDigitsNumber(number)}");

int SumDigitsNumber(int numbers)
{
    int sum =0;
    while (numbers>0)
    {
        sum = sum + numbers%10;
        numbers= numbers/10;
    }
    return sum;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect&& userNumber>=0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
