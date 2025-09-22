//void SayHello() => Console.WriteLine("Hello");
//SayHello();

//Console.Write("Введите имя: ");
//string a = Console.ReadLine();
//Console.Write("Введите язык (русский, фнглийский, немецкий ): ");
//string b = Console.ReadLine().ToLower();
//void SayRu() => Console.WriteLine($"Привет ${a}");
//void SayEn() => Console.WriteLine($"Hello ${a}");
//void SayDe() => Console.WriteLine($"Guten Tag ${a}");
//switch (b) {
//    case "русский":
//        SayRu(); break;
//    case "английский":
//        SayEn(); break;
//    case "немецкий":
//        SayDe(); break;
//    default:
//        Console.WriteLine("Язык не найден"); break;
//}

//void print(string messeg) {
//    Console.WriteLine(messeg);
//}
//print("Hello");

//void sam(int x, int y) {
//    Console.WriteLine(x + y);
//    Console.WriteLine(x - y);

//}
//sam(3,6);

//string a = Console.ReadLine();
//int b = int.Parse(Console.ReadLine());
//void PrintPerson(string PersonName = "Неиветсно", int age=12, string vuz= "неизвестно") {
//    Console.WriteLine($"Имя: {PersonName}, возраст {age} {vuz} ");

//}
//PrintPerson(vuz: "вф вОЛГУ", age: 28, PersonName: "ERTERW");

//string Getmessage() =>  "Hello";

//int getnumber() {
//    return 10;
//}

//Console.WriteLine(Getmessage());
//var a = Getmessage();

//int numbers = int.Parse(Console.ReadLine());
//void Check(int number) {
//    if (number < 0) {
//        Console.WriteLine("Отрицательное");
//        return;
//    }
//    else {
//        Console.WriteLine("положительное");
//        return;
//    }
//}

//Check(numbers);


//Random ranodm = new();
//int number = ranodm.Next(1,100);
//Console.WriteLine(number);


//void Hello() => Console.WriteLine("Hello");
//void Goodbye() => Console.WriteLine("Good Bye");

//string General() {
//    string[] weather = ["Sun", "Windy", "Rainy"];
//    Random random = new Random();
//    int index = random.Next(weather.Length);
//    return weather[index];
//}


//Hello();
//Console.WriteLine(General());
//Goodbye();

//int Factorial(int n)
//{
//    if (n == 1) return 1;
//    return n * Factorial(n - 1);
//}

//Console.WriteLine(Factorial(5));


//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = 0;
//    int numbers2Sum = 0;
//    foreach (int number in numbers1)
//    {
//        numbers1Sum += number;
//    }
//    foreach (int number in numbers2)
//    {
//        numbers2Sum += number;
//    }
//    if (numbers1Sum > numbers2Sum)
//    {
//        Console.WriteLine("Сумма чисел из1 больше");
//    }
//    else if (numbers1Sum < numbers2Sum)
//    {
//        Console.WriteLine("Сумма чисел из2 больше");
//    }
//    else {
//        Console.WriteLine("Сумма чисел равны");
//    }
//    int Sum(int[] numbers)
//    {
//        int result = 0;
//        foreach (int number in numbers)
//        {
//            result += number;
//        }
//        return result;
//    }
//}

//int[] numbers1 = [1, 2, 3];
//int[] numbers2 = [3,4,5,6,7];
//Compare(numbers1, numbers2);



//int Sum(int[] numbers)
//{
//    int limit = 0;
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        if (IsPassed(number,limit)) result += number;
//    }
//    return result;
//    static bool IsPassed(int number, int lim)
//    {
//        return number > lim;
//    }
//}


//int[] numbers1 = [-3, -2, -1, 0, 1, 2, 3];
//int[] numbers2 = [3, -4, 5, -6, 7];
//Console.WriteLine(numbers1);
//Console.WriteLine(numbers2);



//1
//Ничего
//void ShowWelcomeMessage()
//Метод вызовет ошибку компиляции
//void PrintNumber(int number)
//PrintMessage("Hello, World!")

//2
//void GreetUser(string name)
//{
//    Console.WriteLine($"Привет, {name}! Добро пожаловать в программу!");
//}
//GreetUser("Артур");

//3
//int AddNumbers(int a, int b)
//{
//    return a + b;
//}
//int result = AddNumbers(5, 7);
//Console.WriteLine("Сумма: " + result);

//4
//void CheckEven(int num)
//{
//    if (num % 2 == 0)
//        Console.WriteLine($"{num} — чётное число");
//    else
//        Console.WriteLine($"{num} — нечётное число");
//}
//CheckEven(8);
//CheckEven(13);

//5
//int FindMax(int[] arr)
//{
//    int max = arr[0];
//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//            max = arr[i];
//    }
//    return max;
//}
//int[] numbers = { 5, 12, 7, 20, 3 };
//int max = FindMax(numbers);
//Console.WriteLine("Наибольшее число: " + max);

//6
//double ConvertCelsiusToFahrenheit(double celsius)
//{
//    return celsius * 9.0 / 5.0 + 32;
//}
//double celsius = 25;
//double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
//Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

//7
//int CountVowels(string input)
//{
//    int count = 0;
//    string vowels = "aeiou"; // учитываем заглавные и строчные

//    foreach (char c in input.ToLower())
//    {
//        if (vowels.Contains(c))
//            count++;
//    }

//    return count;
//}
//string text = "Hello, World!";
//int vowelsCount = CountVowels(text);
//Console.WriteLine($"Количество гласных: {vowelsCount}");

//8
//string GeneratePassword(int length)
//{
//    const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
//    Random rand = new Random();
//    char[] password = new char[length];

//    for (int i = 0; i < length; i++)
//    {
//        password[i] = chars[rand.Next(chars.Length)];
//    }

//    return new string(password);
//}

//int length = 10;
//string password = GeneratePassword(length);
//Console.WriteLine(password);

//9
//bool IsPalindrome(string input)
//{
//    string clean = input.Replace(" ", "").ToLower();
//    int left = 0;
//    int right = clean.Length - 1;
//    while (left < right)
//    {
//        if (clean[left] != clean[right])
//            return false;

//        left++;
//        right--;
//    }

//    return true;
//}

//string text1 = "level";
//string text2 = "hello";
//Console.WriteLine(IsPalindrome(text1));
//Console.WriteLine(IsPalindrome(text2));

//10
//int[] ReverseArray(int[] arr)
//{
//    int[] reversed = new int[arr.Length];

//    for (int i = 0; i < arr.Length; i++)
//    {
//        reversed[i] = arr[arr.Length - 1 - i];
//    }

//    return reversed;
//}
//int[] numbers = { 1, 2, 3, 4, 5 };
//int[] reversed = ReverseArray(numbers);
//Console.WriteLine(string.Join(", ", numbers));
//Console.WriteLine(string.Join(", ", reversed));

//11
//double Add(double a, double b)
//{
//    return a + b;
//}

//double Subtract(double a, double b)
//{
//    return a - b;
//}

//double Multiply(double a, double b)
//{
//    return a * b;
//}

//double Divide(double a, double b)
//{
//    return a / b;
//}

//Console.Write("Выберите операцию(+|-|*|/):");
//string choice = Console.ReadLine();
//Console.Write("Введите первое число: ");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Введите второе число: ");
//double num2 = Convert.ToDouble(Console.ReadLine());
//switch (choice)
//{
//    case "+":
//        Console.WriteLine("Результат: " + Add(num1, num2));
//        break;
//    case "-":
//        Console.WriteLine("Результат: " + Subtract(num1, num2));
//        break;
//    case "*":
//        Console.WriteLine("Результат: " + Multiply(num1, num2));
//        break;
//    case "/":
//        if (num2 != 0)
//            Console.WriteLine("Результат: " + Divide(num1, num2));
//        else
//            Console.WriteLine("Ошибка: деление на ноль!");
//        break;
//    default:
//        Console.WriteLine("Неверный выбор, попробуйте снова.");
//        break;
//}

//12
//bool IsPrime(int number)
//{
//    if (number < 2)
//        return false;

//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//            return false;
//    }

//    return true;
//}
//void PrintPrimesUpTo(int n)
//{
//    for (int i = 2; i <= n; i++)
//    {
//        if (IsPrime(i))
//        {
//            Console.Write(i + " ");
//        }
//    }
//    Console.WriteLine();
//}
//int n = 20;
//Console.WriteLine($"Простые числа до {n}:");
//PrintPrimesUpTo(n);