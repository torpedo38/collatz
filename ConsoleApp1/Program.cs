// uloha 3
int x = 0;

for (int i = 2; i < 100001; i++)
{
    int a = 0;
    int b = i;

    while (b > 1)
    {
        if (b % 2 == 0)
        {
            b = b / 2;
            a++;
        }
        else
        {
            b = b * 3 + 1;
            a++;
        }
        if (b > x)
        {
            x = b;
        }
        if (b == 1570824736)
        {
            Console.WriteLine(i);
        }
    }
}
Console.WriteLine(x);



//pokus o ulohu 4
int x = 0;
int y = 1;
int z = 3;

for (int i = 2; i < 100000001; i++)
{
    int a = 0;
    int b = i;

    while (b > 1)
    {
        if (b % 2 == 0)
        {
            b = b / 2;
            a++;
        }
        else
        {
            b = b * 3 + 1;
            a++;
        }
    }
    if (a > x)
    {
        x = a;
        y = 1;
    }
    else if (a == x)
    {
        y++;
    }
    else
    {
        y = 1;
    }
    if (y == z)
    {
        Console.WriteLine(y);
        Console.WriteLine(i);
        Console.WriteLine(a);
        Console.WriteLine();
        z++;
    }
}
return -1;