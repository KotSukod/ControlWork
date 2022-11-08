Console.Write("Введите длинну массива: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
int j = 0;
while (j < num)
{
    Console.Write("Введите значение: ");
    array[j] = Convert.ToString(Console.ReadLine()) ?? string.Empty;
    j++;
}
int i = 0;
int leng = 0;
int count = 0;
Console.WriteLine("Начальный массив: ");
while (i < array.Length) //Высчитываем длинну итогового массива
{
    Console.Write(array[i] + " ");
    if (array[i].Length < 4) leng++;
    i++;
}
string[] array2 = new string[leng];
i = 0;
Console.WriteLine();
Console.WriteLine("Получившийся массив: ");
while (i < array.Length) // Записываем данные в итоговый массив
{

    int help = array[i].Length;
    if (help < 4)
    {
        array2[count] = array[i];
        Console.Write(array2[count] + " ");
        count++;
    }
    i++;
}
