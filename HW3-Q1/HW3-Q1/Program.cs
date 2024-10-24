Console.WriteLine("Enter your binary number");
string bi  = Console.ReadLine();
Decimal(bi);
int pow (int a, int b)
{
    int c = 1;
    for (int i = 0; i < b; i++)
    {
        c *= a;
    }

    return c;
}

void Decimal(string bi)
{
    int temp = 0;
    for (int i = bi.Length - 1; i >= 0; i--)
    {
        temp = temp + (int.Parse(bi[i].ToString()) * pow(2, bi.Length - 1 - i));
    }
    Console.WriteLine(temp);
}

