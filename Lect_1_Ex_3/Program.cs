// See https://aka.ms/new-console-template for more information
// int numberA = 31;
// int numberB = 5;
// int result = numberA + numberB;

// // Console.WriteLine(numberA + numberB);
// Console.WriteLine(result);

// int numberA = 10;
// int numberB = 5;
// Console.WriteLine(numberA / numberB); // 2

// если сделаем 12 / 5, то тоже получим 2, т.к. используем деление в целых числах. int(integer) - тип данных(контейнер), 
// позволяющий работать с целыми числами

// int numberA = 12;
// int numberB = 5;
// Console.WriteLine(numberA / numberB); // 2

// исправляем, заменяя int на double (контейнер, позволяющий работать с вещественными (дробными) числами)

// double numberA = 12;
// double numberB = 5;
// Console.WriteLine(numberA / numberB); // 2

// new Random().Next(min, max). Дает случайное ЦЕЛОЕ число от min до max-1 (т.е. max не входит, как в range)

int numberA = new Random().Next(1, 10); // 1,2,3,..9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10); // 1,2,3,..9
Console.WriteLine(numberB);
Console.WriteLine(numberA + numberB); // 