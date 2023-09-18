// Task 1

// Дан текст (задан отдельной строкой в задаче). В тексте нужно все пробелы заменить черточками, маленькие буквы 
// "к" заменить большими "К", а большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "querty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'k', 'K');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'C', 'c');
// Console.WriteLine(newText);

// Task 2. Упорядочить массив. 
// Ипользуем алгоритм сортировки методом выбора (min-max)

// Суть алгоритма: 
// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого (мин) значения со значением первой неотсортированной позиции
// 3. Повторять, пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// пишем метод выведения полученного массива на экран. Даже несколько методов

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

// PrintArray(arr);

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length-1; i++) // 1 отнимаем, т.к. последний элемент уже не с чем сравнивать
    {
        int minPosition = i;
        //
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; // сохраняем значение рабочего элемента (который сравнивали с текущим минимумом)
        array[i] = array[minPosition]; // на место рабочего элемента (крайняя левая позиция неотсортированного 
        // массива) ставим элемент, который является минимальным на данном шаге
        array[minPosition] = temporary; // на место, где стоял минимальный элемент, переносим рабочий элемент 
        // (сдвиг его вправо, теперь он становится первым элементом нового неотсортированного массива)

    }
}

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

//Меняем сортировку от максимального к минимальному

void SelectionSortMax (int[] array)
{
    for (int i = 0; i < array.Length-1; i++) // 1 отнимаем, т.к. последний элемент уже не с чем сравнивать
    {
        int maxPosition = i;
        //
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            } 
        }
        int temporary = array[i]; 
        array[i] = array[maxPosition]; 
        array[maxPosition] = temporary; 
    }
}

PrintArray(arr);
SelectionSortMax(arr);

PrintArray(arr);
