// string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };
string[] array1 = new string[] {"Russia", "Denmark", "Kazan" };

void PrintData(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]}, ");
    }
    Console.Write("]");
}

string[] ArryaNew(string[] aray)
{
    int count = 0;
// Перебираем массив и проверяем условие
    for (int i = 0; i < aray.Length; i++)
    {
        if (aray[i].Length <= 3)
        {
            count++;
        }
    }
// Собираем новый массив
    string[] arrya2 = new string[count];
    int count2 = 0;
    for (int i = 0; i < aray.Length; i++)
    {
        if (aray[i].Length <= 3)
        {
            arrya2[count2] = aray[i];
            count2++;

        }
    }

    return arrya2;
}

// Результат метода
string[] errayNew = ArryaNew(array1);
PrintData(array1);
Console.Write(" -> ");
PrintData(errayNew);
