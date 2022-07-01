Console.WriteLine("ВВедите любое число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a-(a-1);
string c = " ";
while(b<=a)
{
    if(b%2==0)
    {
       c = c + " " + b;
       b=b+2;
        }
    else
       {
          b=b+1; 
              }
    
  }
    
Console.WriteLine(c);
