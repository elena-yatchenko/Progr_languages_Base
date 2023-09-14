// МАССИВЫ

// ТИП ДАННЫХ[] ИМЯ = {Значение1,Значение2, ...}
// int[] array = {9,28,1,32,1990}

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// //             0  1  2  3  4 5  6 7 8
// int[] array = { 1, 21, 13, 41, 5, 66, 17, 9, 8 };
// // замена элемента массива
// array[0] = 12;
// Console.WriteLine(array[0]); // 12
// Console.WriteLine(array[4]); // 5

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(result);


//!!! Выше рассматривали пример для 9 элементов. Если их будет другое количество - инфо позже

// Пример 2. Есть массив array из n элементов, требуется найти элемент массива,
// равный find

// int[] array = {1, 18, 31, 4, 15, 16, 17, 18};

// int n = array.Length; // определяем сколько элементов в массиве
// int find = 18;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     //index = index + 1;
//     index++;
// } // 7

// Если будет несколько элементов ==18, выведутся индексы их всех: 
// 1
// 7
// можно поставить break после того, как нашли первый элемент, который равен find.



// создаем функцию для заполнения массива
// ключевое слово VOID используется для методов, которые НИЧЕГО НЕ ВОЗВРАЩАЮТ. т.е. тут не используем return

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        // добавляем в элемент массива с данным индексом рандомное число от 1 до 9
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


// делаем метод, который будет печатать массив
void PrintArray(int [] col)
{
    int count = col.Length;
    // называть переменные можем как хотим. в другом методе это был index, здесь - position.
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Тестируем созданные методы

// создаем новый массив из 10 элементов, который по умолчанию будет заполнен 0-ми
// int[] array = new int[10];
// // автозаполнение созданного массива случайно подобранными значениями
// FillArray(array);
// // печать полученного массива
// PrintArray(array);

// 6
// 8
// 8
// 2
// 7
// 9
// 3
// 6
// 9
// 8

// ПРИМЕР 3. Адаптируем решение задачи с нахождением индекса элемента со значением find с использованием метода

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // int position = 0; - если оставить в таком виде, то даже если элемента с заданным значением нет в массиве, 
    // будет в результате все равно в ответ выходить ответ 0 (как и в случае, когда искомый элемент реально есть 
    // в массиве и находится на 0-м индексе, т.е. первым в массиве). Для таких случаев придумали возвращать не 0, а 
    // значение position = -1 (или -2, нет разницы). 
  
    int position = -2;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// int[] array = new int[10];

// FillArray(array);
// // можем принудительно добавить пару 4 в массив после его заполнения
// array[3] = 4;
// array[9] = 4;

// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf (array, 4);
// Console.WriteLine(pos);

// 1
// 3
// 2
// 4
// 7
// 2
// 4
// 7
// 9
// 9

// 3 - показана только та 4-ка, которая на 1-й позиции

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf (array, 444);
Console.WriteLine(pos);

// 7                                                                                       ay> dotnet run
// 9
// 3
// 2
// 4
// 2
// 1
// 3
// 3
// 2

// -2