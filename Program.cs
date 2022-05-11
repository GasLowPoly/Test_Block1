/* 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести как с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

int count1 = 0;
int count2 = 0;

try
{
    Console.WriteLine("Hello! type anything and press Enter");


    Console.WriteLine("How many words you want?");
    count1 = Convert.ToInt32(Console.ReadLine());
    string[] words = new string[count1];

    SetItems(words);

    Console.WriteLine("Your words:");
    PrintArray(words);

    Console.WriteLine(string.Empty);
    Console.WriteLine("Filtred words:");
    PrintArray(NewArray(words));
}
catch
{
    Console.WriteLine("Something wrong with your number. Restart and try again");
}


void SetItems(string[] arrayName)
{
    int length = arrayName.Length;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Set word {i + 1}");
        arrayName[i] = Console.ReadLine();
        if (arrayName[i]==string.Empty) arrayName[i] = "Nothing";
        if (arrayName[i].Length <= 3) count2++;
    }

}
string[] NewArray(string[] arrayName)
{
    int length = arrayName.Length;
    string[] result = new string[count2];
    int j = 0;

    for (int i = 0; i < length; i++)
    {
        if (arrayName[i].Length <= 3)
        {
            result[j] = arrayName[i];
            j++;
        }
    }
    return result;
}
void PrintArray(string[] arrayName)
{
    int length = arrayName.Length;
    Console.Write("[ ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(arrayName[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine(string.Empty);
}