//int s = 0;
//int k = 0;
//int n =0;
//Console.WriteLine("Введите число:");
//do
//{
//    try
//    {
//        n = int.Parse(Console.ReadLine());
//        s = s + n;
//        k = k + 1;
//    }
//    catch (Exception e)
//    {
//    Console.WriteLine(e.Message);
//}
//}
//while(n!=0);
//k = k - 1;
//Console.WriteLine($"Сумма чисел:{s},количество: {k}");

//int k = 6;
//Console.WriteLine(++k);
//Console.WriteLine(k);
//Console.WriteLine(++k*--k);
//Console.WriteLine(k);

//int s = 0;
//int i = 1;
//while (i <= 100)
//{
//    i++;
//    if (i % 5 == 0) continue;
//    s += i;
//    s += 1;
//}
//Console.WriteLine($"S={s}");
//Console.Write("Введите число:");
//long n = 0;
//int k3 = 0;
//int kLast = 0;
//int sumGreater5 = 5;
//long multGreater7 = 0;
//int kodd =0;
//int k05 = 0;
//int last = n % 10;
//while (n != 0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if(temp == last) kLast++;
//    if (temp % 2 == 0) kodd++;
//    if (temp > 5) sumGreater5 += temp;
//    if (temp > 7) multGreater7 *= temp;
//    if (temp ==0 || temp ==5) k05++;
//    n/=10;
//}
//Console.WriteLine($"количество 3;{k3}");
//Console.WriteLine($"Последняя цифра встречается;{kLast}");
//Console.WriteLine($"Количество четных;{kodd}");
//Console.WriteLine($"Сумма больше 5: {sumGreater5}");

//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        Console.Write($"{i}*{j}={i * j}");
//    }
//        Console.WriteLine();
//}
//int n = 10;
//for(int i = 10; i <=5;i++)
//{
//    for(int j = 1; j <=i; j++)
//} 
//Console.Write()

//double P = 24;
//double r = 0.06;
//int yearstar = 1826;
//int t = yearsend - yearstar;
//double A = P * Math.Pow(1 + r, t);
//Console.WriteLine($"Начальная сумма:{P}");
//Console.WriteLine($"Годовая ставка:{r * 100}%");
//Console.WriteLine($"Срок вклада:{t} лет ({yearstar}-{yearsend})");
//Console.WriteLine($"Состояние счета:{A:N2}");

try
{
    double balance = 24;
    double rate = 0.06;
    int yearstar = 1826;
    int yearend = 2026;
    for (int year= yearstar;year<= yearend;year++)
    {
        balance = balance + balance * rate;
    }
    Console.WriteLine($"Состояние счета:{balance:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
//Базовый уровень

