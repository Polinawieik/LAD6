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

//try
//{
//    double balance = 24;
//    double rate = 0.06;
//    int yearstar = 1826;
//    int yearend = 2026;
//    for (int year= yearstar;year<= yearend;year++)
//    {
//        balance = balance + balance * rate;
//    }
//    Console.WriteLine($"Состояние счета:{balance:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
////Базовый уровень

using System.Runtime.CompilerServices;

int[] mas1 = new int[5];
int[] mas2 = { 1, 4, 2, 9, 3 };
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);

//ввод вручную
//int[] mas4 = new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4 [i] = int.Parse(Console.ReadLine());
//for (int i = 0;i<mas4.Length;i++)
//    Console.Write($"{mas4[i]}");
////ввод по формуле
//int[] mas5 = new int[5];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.Write($"{mas5[i]}");
//}
//Console.WriteLine();

//задание
//int[] mas= new int[10];
//Random rnd= new Random();
//for (int i = 0; i < mas.Length; i++) ;
//{
//    mas[i] = rnd.Next(-7,8);
//    Console.Write($"{mas[i]}");
//}
//Console.WriteLine();
//Console.Write("Введите n:");
//int n =int.Parse(Console.ReadLine());
//int index = -1;
//int= less_n = 0;
//for (int i = 0;i <mas.Length; i++)
//{
//    if (mas[i] == n) index = i;
//    if (mas[i] < n) ++;

//}

//задание 2


//отсортировать элементы массива по возрастанию
//Random rnd=new Random();
//int[] mas= new int[rnd];

////C
//try
//{
//    Console.Write()
//}
//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new int[n];


//}

//Первая
//string? text = "Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id = null;
//int personId = id ?? 1;
//Console.WriteLine(personId);

//Random random = new Random();
//int n = random.Next(5, 11);
//for (int i = 0; i < n; i++)


try
{
    Random random = new Random();
string[] mas = new string[5];
Console.Write("Массив: ");
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = Convert.ToString(random.Next(10, 100), 2);
    Console.Write($"{mas[i]}   ");
}
Console.WriteLine();
string D = Convert.ToString(random.Next(10, 100), 2);
Console.WriteLine($"Заданное двоичное число D: {D}");
int decimalD = Convert.ToInt32(D, 2);
int index = 0;
for (int i = 1; i < mas.Length; i++)
{
    int currentVal = Convert.ToInt32(mas[i], 2);
    int maxVal = Convert.ToInt32(mas[index], 2);
    if (Math.Abs(currentVal - decimalD) > Math.Abs(maxVal - decimalD))
    {
        index = i;
    }
}
Console.WriteLine($"Наиболее удаленное значение: {mas[index]}; его индекс: {index}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
