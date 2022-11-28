// МЕТОД_1 - принимает от пользователя строки/слова.
string ReadData(string msg) // Принимает данные от пользователя
{
    Console.Write(msg);
    string text = Console.ReadLine() ?? "0"; // конструкция ??"0" нивелирует ошибку NULL
    return text;
}

// МЕТОД_2 - формирует пользовательский массив из полученных строк/слов.
string[] FillArray(int length) // Создаёт массив.
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadData("Введите текст: ");
    }
    return array;
}

// МЕТОД_3 - выводт на экран сформированный  массив.
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Массив пустой.");  // если новый массив пустой - выводится сообщение
    }
    else
    {
        Console.Write("["); for (int i = 0; i < array.Length - 1; i++) //первое значение массива
        {
            Console.Write(array[i] + ", "); //промежуточные значение
        }
        Console.WriteLine(array[array.Length - 1] + "]"); //последнее значение
    }
}

// МЕТОД_4 - сортирует элементы 1го массива и формирует новый массив (длина которых <= заданного значения)
string[] SortArray(string[] array, int lengthArray, int length) // Создаёт новый массив по условию задачи.
{
    string[] sortArray = new string[0];
    for (int i = 0; i < lengthArray; i++)
    {
        if (array[i].Length <= length)
        {
            Array.Resize(ref sortArray, sortArray.Length + 1);
            sortArray[sortArray.Length - 1] = array[i];
        }
    }
    return sortArray;
}


// МЕТОД_5 - передаёт новый массив в Метод_3.

// Вызов МЕТОД_3 - выводт на экран сортированный массив или сообщение о пустом массиве.