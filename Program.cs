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

string[] ThreeLetterWords (string[] array) {     //функция отбора строк менее 3 символов
    string[] newArray = new string[array.Length];  //новый массив
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) {             // если символов меньше 3х
            newArray[i] = array[i];             //запишем в новый массив
        }
    } return newArray;
}

string[] originArray = CreatStringArray();
System.Console.WriteLine("The array you entered: ");
PrintArray(originArray);
System.Console.WriteLine();
System.Console.WriteLine("Elements of the input array are less than three characters: ");
PrintArray(ThreeLetterWords(originArray));