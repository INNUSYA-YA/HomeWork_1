Console.WriteLine("ВВедите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("Наибольшее число" + "-" + a);
}
else
{
    Console.Write("Наибольшее число" + "-" + b);
}
