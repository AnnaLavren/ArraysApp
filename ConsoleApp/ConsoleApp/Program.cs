class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя количество элементов массива
        Console.Write("Введите количество элементов массива: ");
        int arrayLength = int.Parse(Console.ReadLine());

        // Создаем и заполняем исходный массив строк
        string[] inputArray = new string[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write($"Элемент [{i}] -> ");
            inputArray[i] = Console.ReadLine();
        }

        // Находим количество строк, которые удовлетворяют условию
        int shortStringsCount = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                shortStringsCount++;
            }
        }

        // Создаем новый массив строк с нужной длиной
        string[] resultArray = new string[shortStringsCount];

        // Заполняем новый массив строками, удовлетворяющими условию
        int resultIndex = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        // Выводим результат на экран
        Console.Write("Исходный массив: ");
        PrintArray(inputArray);

        Console.Write(" -> Отфильтрованный массив: ");
        PrintArray(resultArray);
    }

    // Метод для вывода массива строк в указанном формате
    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]");
    }
}