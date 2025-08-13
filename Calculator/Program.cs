string getSign(int choice)
{
    if (choice == 1)
    {
        return "+";
    }
    else if (choice == 2)
    {
        return "-";
    }
    else if (choice == 3)
    {
        return "*";
    }
    else if (choice == 4)
    {
        return "/";
    }
    else
    {
        return "";
    }
}

float getNum (int choice, float num1, float num2)
{
    if (choice == 1)
    {
        return num1 + num2;
    }
    else if (choice == 2)
    {
        return num1 - num2;
    }
    else if (choice == 3)
    {
        return num1 * num2;
    }
    else if (choice == 4)
    {
        if (num2 == 0)
        {
            return 0;
        }
        else
        {
            return num1 / num2;
        }
    }
    else
    {
        return 0;
    }
}

bool run = true;

while (run == true)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine("0) Quit");
    Console.WriteLine("1) Add");
    Console.WriteLine("2) Subtract");
    Console.WriteLine("3) Multiply");
    Console.WriteLine("4) Divide");
    Console.WriteLine("-------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-------------------------");

    if (choice == 0)
    {
        run = false;
    }
    else if (choice > 0 && choice < 5)
    {

        string sign = getSign(choice);

        float num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{num1:F2}" + sign);
        float num2 = Convert.ToInt32(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine($"{num1:F2}" + sign + $"{num2:F2}" + "=" + "undefined");
        }
        else
        {
            float num3 = getNum(choice, num1, num2);
            Console.WriteLine($"{num1:F2}" + sign + $"{num2:F2}" + "=" + $"{num3:F2}");
        }
    }
    else
    {
        ;
    }
}