// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символам

string Prompt(string message) // приглашение к вводу строки
{
    string? word = " ";
    System.Console.WriteLine($"{message} ");
    return word = Console.ReadLine();  // подсветка - что то с исключениями вроде, пока не проходили
}

string[] CreatStringArray()  // инициализация массива из введенных строк
{
    string[] array = new string[5];  // массив будет из 5 элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Enter string {i + 1}: "); //каждому элементу предлогаем ввести значение - строку
    }
    return array;
}

void PrintArray(string[] array) //печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

