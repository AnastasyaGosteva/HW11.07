void CheackPalindrom(string number)  
{  
    char[] firstNumber = number.ToCharArray();
    char[] secondNumber = number.ToCharArray();
    Array.Reverse(secondNumber);

    string number1 = new String(firstNumber);
    string number2 = new String(secondNumber);
    
    if (number1 == number2) Console.Write($"Число {number} палиндром!");  

    else Console.Write($"Число {number} не палиндром!");
}

void Check(string number)
{
    if (number.Length > 5 | number.Length <5 ) 
    Console.Write("Ошибка ввода!");
    else
    CheackPalindrom(number);
}

string GetInput(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string number = GetInput("Введите пятизначное число: ");
Check(number); 
