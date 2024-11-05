// Console.WriteLine("№1");

// double e = Math.E;
// Console.WriteLine($"{e:F1}");

// Console.WriteLine("№2");

// Console.WriteLine("50");
// Console.WriteLine("10");

// Console.WriteLine("№3");

// Console.WriteLine("11");
// Console.WriteLine("22");
// Console.WriteLine("33");
// Console.WriteLine("44");

// Console.WriteLine("№4");

// Console.Write("Введите число: ");
// double number_1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(number_1 + 10);

// Console.WriteLine("№5");

// Console.Write("Введите сторону квадрата: ");
// double side = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(side * 4);

// Console.WriteLine("№6");

// Console.Write("Введите радиус: ");

// double radius = Convert.ToDouble(Console.ReadLine());
// double circumference = 2 * Math.PI * radius;
// double area = Math.PI * radius * radius;
// Console.WriteLine($"Длина окружности: {circumference}");
// Console.WriteLine($"Площадь круга: {area}");

// Console.WriteLine("№7");

// Console.Write("Введите x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// x = x * Math.PI / 180;
// Console.WriteLine(Math.Cos(x));

// Console.WriteLine("№8");

// Console.Write("Введите высоту трапеции: ");
// double h = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите первое основание: ");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите второе основание: ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Периметр равнобедренной трапеции равен: {h * (a + b) / 2}");

// Console.WriteLine("№9");
// Console.Write("Введите цену стоимость 1 кг конфет: ");
// double candy_price = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите цену стоимость 1 кг печенья: ");
// double cookie_price = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите цену стоимость 1 кг яблок: ");
// double apple_price = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите сколько кг конфет купили: ");
// double candy_kg = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите сколько кг печенья купили: ");
// double cookie_kg = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите сколько кг яблок купили: ");
// double apple_kg = Convert.ToDouble(Console.ReadLine());
// double sum = candy_price * candy_kg + cookie_price * cookie_kg + apple_price * apple_kg;

// Console.WriteLine($"Стоимость всей покупки: {sum}");

// Console.WriteLine("№10");

// Console.WriteLine("Мир Труд Май");
// Console.WriteLine("Мир");
// Console.WriteLine("      Труд");
// Console.WriteLine("             Май");

// Console.WriteLine("№11");

// try
// {
//     Console.Write("Введите первое число: ");
//     double first_num = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
//     Console.Write("Введите второе число: ");
//     double second_num = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
//     Console.WriteLine($"{second_num} {first_num}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Не правильный ввод: {ex.Message}");
// }

Console.WriteLine("№12");

Console.WriteLine("Выберите фигуру: 1 - треугольник, 2 - четырехугольник, 3 - круг");
string shape = Console.ReadLine();
Console.WriteLine("Выберите что будем считать? 1 - площадь, 2 - периметр");
string square_perimeter = shape + Console.ReadLine();
switch (square_perimeter)
{
    case "11":
        Console.WriteLine("Введите первую сторону треугольника");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону треугольника");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите третью сторону треугольника");
        double c = Convert.ToDouble(Console.ReadLine());
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine(S);
        break;
    case "12":
        break;
    case "21":
        break;
    case "22":
        break;
    case "31":
        break;
    case "32":
        break;
}



Console.WriteLine("№13");
Console.WriteLine("№14");
Console.WriteLine("№15");
Console.WriteLine("№16");
Console.WriteLine("№17");
Console.WriteLine("№18");
Console.WriteLine("№19");
Console.WriteLine("№20");
Console.WriteLine("№21");
Console.WriteLine("№22");
Console.WriteLine("№23");
Console.WriteLine("№24");
Console.WriteLine("№25");
Console.WriteLine("№26");
Console.WriteLine("№27");
Console.WriteLine("№28");
Console.WriteLine("№29");
Console.WriteLine("№29");
Console.WriteLine("№30");
Console.WriteLine("№31");
Console.WriteLine("№32");
Console.WriteLine("№33");
Console.WriteLine("№34");
Console.WriteLine("№35");
Console.WriteLine("№36");

