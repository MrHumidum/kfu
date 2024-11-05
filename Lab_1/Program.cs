Console.WriteLine("Упражнение 2.1\n");


Console.Write("Введите свое имя: ");
string name = Console.ReadLine();

Console.WriteLine($"Привет {name}");


Console.WriteLine("\nУпражнение 2.2\n");


Console.Write("Введите первое число: ");
double number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
double number_2 = Convert.ToInt32(Console.ReadLine());

if (number_2 != 0)
{
    Console.WriteLine(number_1 / number_2);
}
else
{
    Console.WriteLine("На 0 делить нельзя :/");
}


Console.WriteLine("\nДомашнее задание 2.1\n");


Console.Write("Введите букву: ");

char letter = Console.ReadKey().KeyChar;
if (letter == 'z' || letter == 'я')
{
    letter = 'a';
}
else if (letter == 'Z' || letter == 'Я')
{
    letter = 'A';
}
else
{
    letter = (char)(letter + 1);
}

Console.WriteLine($"\nСледующая буква: {letter}");


Console.WriteLine("\nДомашнее задание 2.2\n");

Console.WriteLine("Введите коэффициенты уравнения");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

double D = Math.Pow(b, 2) - 4 * a * c;
if (D < 0)
{
    Console.WriteLine("Так как дискриминант меньше нуля, то уравнение не имеет действительных решений.");

}
else
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);

    Console.WriteLine($"x1 = {x1} x2 = {x2}");
}

