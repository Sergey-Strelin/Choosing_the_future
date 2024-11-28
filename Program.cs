// Решение итогового задания курса Выбор специализации


// запрос количества вводимых строк
Console.Write("Укажите сколько строк будет введено - ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 0)
{
    string[] array = InitArrray(number);
    Console.WriteLine("Вы ввели следующие строки:");
    ViewArray(array);
    string[] nArray = SeachArray(array);
    if (nArray.GetLength(0) == 0) // есть что выводить? если ноль, то строк короче 4х символов нет
    {
        Console.WriteLine("Строк короче 4х символов НЕТ!");
    }
    else
    {
        Console.WriteLine("Выводим строки короче 4х симолов:");
        ViewArray(nArray);
    }
} 
else {Console.WriteLine("Введите целое число больше нуля!");}

// организуем ввод строк в массив
string[] InitArrray(int number)
{
    string[] newArray = new string[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите текст в {i+1} строку - ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}


// выводим содержимое получившегося массива на экран
void ViewArray (string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} \t");
    }
    Console.WriteLine("");
}

// ищем и выводим строки длинной короче 4х символов
string[] SeachArray(string[] firstArray)
{
    int n = 0; // размер массива c результатом
    string[] newArray = new string[n];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        if (firstArray[i].Length < 4 )
        {
            n ++;
            Array.Resize(ref newArray, n);
            newArray[n-1] = firstArray[i];
        }   
    }  
    return newArray;
}