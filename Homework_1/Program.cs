Console.WriteLine("№1");

double e = Math.E;
Console.WriteLine($"{e:F1}");

Console.WriteLine("№2");

Console.WriteLine("50");
Console.WriteLine("10");

Console.WriteLine("№3");

Console.WriteLine("11");
Console.WriteLine("22");
Console.WriteLine("33");
Console.WriteLine("44");

Console.WriteLine("№4");

Console.Write("Введите число: ");
double number_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(number_1 + 10);

Console.WriteLine("№5");

Console.Write("Введите сторону квадрата: ");
double side = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(side * 4);

Console.WriteLine("№6");

Console.Write("Введите радиус: ");

double radius = Convert.ToDouble(Console.ReadLine());
double circumference = 2 * Math.PI * radius;
double area = Math.PI * radius * radius;
Console.WriteLine($"Длина окружности: {circumference}");
Console.WriteLine($"Площадь круга: {area}");

Console.WriteLine("№7");

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
x = x * Math.PI / 180;
Console.WriteLine(Math.Cos(x));

Console.WriteLine("№8");

Console.Write("Введите высоту трапеции: ");
double h = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первое основание: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе основание: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Периметр равнобедренной трапеции равен: {h * (a + b) / 2}");

Console.WriteLine("№9");
Console.Write("Введите цену стоимость 1 кг конфет: ");
double candy_price = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите цену стоимость 1 кг печенья: ");
double cookie_price = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите цену стоимость 1 кг яблок: ");
double apple_price = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сколько кг конфет купили: ");
double candy_kg = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сколько кг печенья купили: ");
double cookie_kg = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сколько кг яблок купили: ");
double apple_kg = Convert.ToDouble(Console.ReadLine());
double sum = candy_price * candy_kg + cookie_price * cookie_kg + apple_price * apple_kg;

Console.WriteLine($"Стоимость всей покупки: {sum}");

Console.WriteLine("№10");

Console.WriteLine("Мир Труд Май");
Console.WriteLine("Мир");
Console.WriteLine("      Труд");
Console.WriteLine("             Май");

Console.WriteLine("№11");

try
{
    Console.Write("Введите первое число: ");
    double first_num = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
    Console.Write("Введите второе число: ");
    double second_num = Convert.ToDouble(Console.ReadLine().Replace(',', '.'));
    Console.WriteLine($"{second_num} {first_num}");
}
catch (FormatException)
{
    Console.WriteLine($"Не правильный ввод");
}

Console.WriteLine("№12");



Console.WriteLine("Выберите фигуру: 1 - треугольник, 2 - четырехугольник, 3 - круг");
string shape = Console.ReadLine();
Console.WriteLine("Выберите, что будем считать: 1 - площадь, 2 - периметр");
string square_perimeter = shape + Console.ReadLine();

switch (square_perimeter)
{
    case "11":
        Console.WriteLine("Считаем площадь треугольника");
        Console.Write("Введите основание треугольника: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту треугольника: ");
        h = Convert.ToDouble(Console.ReadLine());
        double S_triangle = 0.5 * a * h;
        Console.WriteLine($"Площадь треугольника: {S_triangle}");
        break;

    case "12":
        Console.WriteLine("Считаем периметр треугольника");
        Console.Write("Введите первую сторону треугольника: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вторую сторону треугольника: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите третью сторону треугольника: ");
        double c1 = Convert.ToDouble(Console.ReadLine());
        double P_triangle = a1 + b1 + c1;
        Console.WriteLine($"Периметр треугольника: {P_triangle}");
        break;

    case "21":
        Console.WriteLine("Считаем площадь четырехугольника");
        Console.Write("Введите длину первой стороны: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину второй стороны: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        double S_quad = side1 * side2;
        Console.WriteLine($"Площадь четырехугольника: {S_quad}");
        break;

    case "22":
        Console.WriteLine("Считаем периметр четырехугольника");
        Console.Write("Введите длину первой стороны: ");
        double s1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину второй стороны: ");
        double s2 = Convert.ToDouble(Console.ReadLine());
        double P_quad = 2 * (s1 + s2);
        Console.WriteLine($"Периметр четырехугольника: {P_quad}");
        break;

    case "31":
        Console.WriteLine("Считаем площадь круга");
        Console.Write("Введите радиус круга: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double S_circle = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"Площадь круга: {S_circle}");
        break;

    case "32":
        Console.WriteLine("Считаем длину окружности");
        Console.Write("Введите радиус круга: ");
        radius = Convert.ToDouble(Console.ReadLine());
        double P_circle = 2 * Math.PI * radius;
        Console.WriteLine($"Длина окружности: {P_circle}");
        break;

    default:
        Console.WriteLine("Выбран неверный вариант");
        break;
}



Console.WriteLine("№13");


try
{
    Console.Write("Введите число: ");
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Вы ввели число {number}");
}
catch (FormatException)
{
    Console.WriteLine("Введено не число");
}

Console.WriteLine("№14");

Console.WriteLine("2 кг");
Console.WriteLine("13 17 ");


Console.WriteLine("№15");

Random rand = new Random();

for (int j = 0; j < 4; j++)
{
    Console.WriteLine(rand.Next());
}

Console.WriteLine("№16");

Console.WriteLine("Введите 3 коэффициентa уравнения через Enter");
double x1, x2;
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double D = Math.Pow(b, 2) - 4 * a * c;
if (D < 0)
{
    Console.WriteLine("Так как дискриминант меньше нуля, то уравнение не имеет действительных решений.");

}
else
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);

    Console.WriteLine($"x1 = {x1} x2 = {x2}");
}

Console.WriteLine("№17");
Console.Write("Введите первое число: ");
int first_numb = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_numb = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Среднее арифметическое = {(first_numb + second_numb) / 2}, среднее геометрическое = {Math.Sqrt(first_numb * second_numb)}");

Console.WriteLine("№18");

Console.Write("Введите координату x первой точки: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x второй точки: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками: {Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))}");

Console.WriteLine("№19");
Console.WriteLine("Схема а");

Console.Write("Введите значение a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение c: ");
c = Convert.ToInt32(Console.ReadLine());

int temp;

temp = (int)b;
b = c;
c = a;
a = temp;

Console.WriteLine("После обмена по схеме (а):");
Console.WriteLine($"a = {a}, b = {b}, c = {c}");

Console.WriteLine("Схема б");
Console.Write("Введите значение a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение c: ");
c = Convert.ToInt32(Console.ReadLine());

temp = (int)a;
a = c;
c = b;
b = temp;

Console.WriteLine("После обмена по схеме (б):");
Console.WriteLine($"a = {a}, b = {b}, c = {c}");


Console.WriteLine("№20");
Console.Write("Введите количество секунд: ");
int n = Convert.ToInt16(Console.ReadLine());
int hours = n / 3600;
double minutes = (n % 3600) / 60;
int seconds = n % 60;

Console.WriteLine($"Полных часов прошло: {hours}");
Console.WriteLine($"Полных минут в последнем часе: {minutes}");
Console.WriteLine($"Полных секунд в последней минуте: {seconds}");

Console.WriteLine("№21");

Console.WriteLine($"{543 / 130}");

Console.WriteLine("№22");

string num_22 = Console.ReadLine();

Console.WriteLine($"{num_22[2]}{num_22[1]}{num_22[0]}");

Console.WriteLine("№23");

int num_23 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число сотен = {num_23 / 100 % 10}  Число тысяч = {num_23 / 1000 % 10}");

Console.WriteLine("№24");

int num_24 = Convert.ToInt32(Console.ReadLine());
string str = num_24.ToString();
string a24 = $"{str[3]}{str[2]}{str[1]}{str[0]}";
string b24 = $"{str[1]}{str[0]}{str[3]}{str[2]}";
string c24 = $"{str[0]}{str[2]}{str[1]}{str[3]}";
string d24 = $"{str[3]}{str[2]}{str[0]}{str[1]}";
Console.WriteLine($"a) {Convert.ToInt32(a24)}");
Console.WriteLine($"б) {Convert.ToInt32(b24)}");
Console.WriteLine($"в) {Convert.ToInt32(c24)}");
Console.WriteLine($"г) {Convert.ToInt32(d24)}");

Console.WriteLine("№25");

Console.Write("Введите число n (100 ≤ n ≤ 999): ");
n = Convert.ToInt32(Console.ReadLine());

int d = n % 10;
int m = n / 10;
x = m * 10 + d;

Console.WriteLine($"Искомое число x: {x}");

Console.WriteLine("№26");
Console.Write("Введите часы (0 ≤ h ≤ 23): ");
h = Convert.ToInt32(Console.ReadLine()) % 12;
Console.Write("Введите минуты (0 ≤ m ≤ 59): ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите секунды (0 ≤ s ≤ 59): ");
int s = Convert.ToInt32(Console.ReadLine());

double angle = h * 30 + m * 0.5 + s * 0.0083;

Console.WriteLine($"Угол= {angle}°");


Console.WriteLine("№27");

Console.WriteLine("Введите угол часовой стрелки (в радианах)");
double y27 = double.Parse(Console.ReadLine());

Console.WriteLine($"Угол минутной стрелки равен {minutes / 30} радиан; время - {Math.Floor(6 * y27)}:{(180 * y27 - 30 * hours) * 2}");

Console.WriteLine("№28");
double minimal = 100000000000000;

double a28 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
double b28 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
double c28 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
if (minimal > a28)
{
    minimal = a28;
}
if (minimal > b28)
{
    minimal = b28;
}
if (minimal > c28)
{
    minimal = c28;
}
Console.WriteLine("\n" + minimal);

Console.WriteLine("№29");
double a29 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
double b29 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
double c29 = Math.Abs(Convert.ToDouble(Console.ReadLine()));

double[] chonado = [a29, b29, c29];

Console.WriteLine("\n" + chonado.Max() + chonado.Min());

Console.WriteLine("№30");
double a30 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
int temp_30 = 0;
for (int i = 1; i <= Math.Sqrt(a30) + 1; i++)
{
    if (a30 % i == 0)
    {
        temp_30++;
        if (i != a30 / i)
        {
            temp_30++;
        }
    }
}
Console.WriteLine(temp_30);
Console.WriteLine("№31");
Console.WriteLine("Введите коэффициенты A, B, C, D (A*X^3 + B*X^2 + C*X + D = 0):");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
D = int.Parse(Console.ReadLine());

bool rootsFound = false;
for (int X = -100; X <= 100; X++)
{
    double result = A * X * X * X + B * X * X + C * X + D;
    if (result == 0)
    {
        Console.WriteLine($"Корень уравнения: X = {X}");
        rootsFound = true;
    }
}

if (!rootsFound)
{
    Console.WriteLine("Корни не найдены.");
}

Console.WriteLine("№32");
Console.Write("Введите первый элемент прогрессии:");
a = int.Parse(Console.ReadLine());

Console.Write("Введите разность прогрессии:");
d = int.Parse(Console.ReadLine());

Console.Write("Введите номер элемента прогрессии:");
n = int.Parse(Console.ReadLine());

double an = a + (n - 1) * d;

Console.WriteLine($"Элемент прогрессии с номером {n} = {an}");

Console.WriteLine("№33");

Console.Write("Вы студент? (да/нет):");
string student = Console.ReadLine().ToLower();

Console.Write("Вы пенсионер? (да/нет):");
string pensioner = Console.ReadLine().ToLower();

Console.Write("Вы трудоустроены? (да/нет):");
string employed = Console.ReadLine().ToLower();

if ((student == "да" || pensioner == "да") && !(student == "да" && pensioner == "да") && employed != "да")
{
    Console.WriteLine("Вам дадут кредит.");
}
else
{
    Console.WriteLine("Вам не дадут кредит.");
}

Console.WriteLine("№34");

Console.Write("Как вас зовут? ");
string name = Console.ReadLine();
Console.WriteLine(name);
Console.Write("Как вас зовут? ");
name = Console.ReadLine();
Console.WriteLine(name);
Console.WriteLine($"Привет, {name}!");
Console.WriteLine("№35");
Console.WriteLine("Привет!");

Console.Write("Как вас зовут? ");
name = Console.ReadLine();
Console.WriteLine($"Привет, {name}!");

Console.Write("Знаешь ли ты что-нибудь о Тайной комнате? ");
string answer1 = Console.ReadLine();

Console.WriteLine("Да");

Console.Write("Можешь ли ты рассказать? ");
string answer2 = Console.ReadLine();

Console.WriteLine("Нет");

Thread.Sleep(5000);
Console.WriteLine("Но могу показать");

rand = new Random();
Console.ForegroundColor = (ConsoleColor)rand.Next(1, 16);

Console.WriteLine("Цвет изменен!");

Console.WriteLine("№36");
Console.WriteLine("1 - Случайные цифры, 2 - Ввод вручную:");
int choice = int.Parse(Console.ReadLine());

string[] digits = new string[12];

if (choice == 1)
{
    rand = new Random();
    for (int i = 0; i < 12; i++) digits[i] = rand.Next(0, 10).ToString();
}
else
{
    Console.WriteLine("Введите 12 цифр штрихкода:");
    digits = Console.ReadLine().Split(' ');
    if (digits.Length != 12) { Console.WriteLine("Ошибка! Введите 12 цифр."); return; }
}

sum = 0;
for (int i = 0; i < 12; i++) sum += int.Parse(digits[i]) * (i % 2 == 0 ? 1 : 3);
double controlDigit = (10 - (sum % 10)) % 10;

Console.WriteLine($"Контрольная цифра: {controlDigit}");
