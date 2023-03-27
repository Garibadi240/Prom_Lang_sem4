Console.Clear();
// input
int number = GetNumberForNumber("Введите основание: ", "Ошибка ввода!");
int degree = GetNumberForDegree("Введите показатель: ", "Ошибка ввода!");

// logic

//output
Console.WriteLine($"({number}, {degree}) -> {UserPow(number, degree)}");

int UserPow(int numbers, int degree)
{
    int pow = 1;
    while (degree>0)
    {
        pow = pow*numbers;
        degree--; 
    }
    return pow;
}

int GetNumberForNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect&&userNumber!=0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberForDegree(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect&&userNumber>)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
