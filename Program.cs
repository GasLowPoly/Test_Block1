/* 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести как с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

int length = 0;


try
{
    Console.WriteLine("Hello! type anything and press Enter");


    Console.WriteLine("How many words you want?");
    length = Convert.ToInt32(Console.ReadLine());
    string[] words = new string[length];

    SetItems(words);

    Console.WriteLine("Your words:"); // печатаем собранный массив
    PrintArray(words);

    Console.WriteLine();
    Console.WriteLine("Filtred words:"); // печатаем собранный массив
    PrintArray(FilterAndGenNew(words));
}
catch
{
    Console.WriteLine("Something wrong with your number. Restart and try again");
}


void SetItems(string[] arrayName)
{
    int length = arrayName.Length;
    if (length > 0)
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Set word {i + 1}");
            arrayName[i] = Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Something wrong with your number. Restart and try again");
    }

}

void PrintArray(string[] arrayName)
{
    length = arrayName.Length;
    Console.Write("[ ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(arrayName[i] + " ");
    }
    Console.Write("]");
}

string[] FilterAndGenNew(string[] arrayName)
{
    int count = 0; //считаем нужные
    for (int i = 0; i < arrayName.Length; i++)
    {
        if (arrayName[i].Length <= 3) count++;
    }

    string[] result = new string[count]; // создаем новый массив, зная количество новых элементов
    int j = 0; // начальный индекс нового массива

    for (int i = 0; i < arrayName.Length; i++) // перебираем старый массив и собираем новый из подходящих элементов
    {

        if (arrayName[i].Length <= 3)
        {
            result[j] = arrayName[i];
            j++;
        }
    }
    return result;

}