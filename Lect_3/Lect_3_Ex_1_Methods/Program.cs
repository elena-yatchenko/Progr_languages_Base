// 4 группы методов: 
// 1) ничего не принимают, ничего не возвращают
// 2) что-то принимают, ничего не возвращают
// 3) ничего не принимают, но могут возвращать что-то (например, генерировать случайные элементы)
// 4) что-то принимают, что-то возвращают

// 1 и 2 - void-методы

// Group 1
void Method1()
{
    Console.WriteLine("Автор... ");
}
// Method1(); // - вызов метода

// Group 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения") // Вызов метода;


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i += 1;
    }  
}
// Когда аргументов несколько, лучше использовать именованные аргументы: 
// т.е. явно указывать какому аргументу какое значение присваиваем. В этом случае их можно вводить не по порядку

// Method21(msg: "Text of message", count: 4);

// CTRL + C - прерывание, если программа зациклилась (т.е. в бесконечный цикл вошла)

// Group 3

int Method3()
{
    return DateTime.Now.Year;
}

// Method3(); // вызов

int year = Method3();
// Console.WriteLine(year);

// Group 4
// string Method4(int count, string text)
// {
//     int i = 0; 
//     string result = ""; // = string.Empty

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "testing");
// Console.WriteLine(res);

// или этот же метод можно записать через цикл For
// Цикл FOR - цикл со счетчиком

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i)
// }

// string Method41(int count, string text)
// {    
//     string result = ""; // = string.Empty
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method41(10, "testing");
// Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ

// Например, есть прямоугольная область, хотим закрасить (что-то сделать)
// со всеми строками всех столбиков

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(i * j)
    }
    Console.WriteLine()
}

// Задача - вывод таблицы умножения на экран

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine(); // добавляем искусственно пустую строку между блоками
}

// $"{i} x {j} = {i*j}" - интерполяция, аналог f-строки из Питона
