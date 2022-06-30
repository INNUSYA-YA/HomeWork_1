Console.WriteLine("ВВедите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    if(a>c)
    Console.WriteLine("Наибольшее число" + "-" + a);
    else
    {
        Console.WriteLine("Наибольшее число" + "-" + c);
    }
}
else
{
    if(b>c)
    Console.WriteLine("Наибольшее число" + "-" + b);
    else
    {
         Console.WriteLine("Наибольшее число" + "-" + c);
    }
}