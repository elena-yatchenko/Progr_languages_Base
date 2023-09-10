// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Введите ваше имя ");
// string username = Console.ReadLine();
// // в программировании '=' - оператор присваивания, который говорит: 
// // "возьми то, что справа, и положи в то, что слева"
// Console.WriteLine("Привет, "); // пишет все на отдельной строке
// Console.WriteLine(username);

// Введите ваше имя 
// Elena
// Привет, 
// Elena

// Console.Write("Введите ваше имя ");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);

// Введите ваше имя Елена
// Привет, Елена

// используем оператор ветвления if else для выведения особого приветствия для Маши

Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // перевели введенную строку в нижний регистр, чтоб исключить ошибки большая/маленькая буква
{
    Console.Write("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}