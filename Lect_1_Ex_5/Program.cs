// команда очистки консоли
Console.Clear();
// задаем позицию курсора (отступ от начала строки, номер строки), нумерация строк и позиций в консоли идет с 0
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("*"); //ставит * на 4 строки вниз и на 10 знаков вправо по строке

// int xa = 1;
// int ya = 1;
// int xb = 1;
// int yb = 30;
// int xc = 40;
// int yc = 30; // эту запись можно сделать проще

int xa = 35, ya = 1,
    xb = 1, yb = 25,
    xc = 70, yc = 25;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya; // со старта просто указываем первую точку (можно любую)

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // выводим рандомное число в диапазонеполуинтервала [0; 3), где первое число включено, а последнее нет, т.е. 0, 1, 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2; //выводим координаты половины отрезка от нашей точки до случайно определенной
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count += 1; // равнозначно записи count = count + 1 или count++
}