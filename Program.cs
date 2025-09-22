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


void Hello() => Console.WriteLine("Hello");
void Goodbye() => Console.WriteLine("Good Bye");

string General() {
    string[] weather = ["Sun", "Windy", "Rainy"];
    Random random = new Random();
    int index = random.Next(weather.Length);
    return weather[index];
}


Hello();
Console.WriteLine(General());
Goodbye();