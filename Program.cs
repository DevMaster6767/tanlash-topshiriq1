//1.String ustida amallar
Console.Write("iltimos, bir satr kiriting=> ");
string str = Console.ReadLine();
Console.Write("iltimos, bir son kiriting=> ");
int son1= Convert.ToInt32(Console.ReadLine());
if (son1 > str.Length)
{
    Console.WriteLine(str.ToUpper());
}
else
{
    Console.WriteLine(str.ToLower());
}
Console.WriteLine();

//2.Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang.
Console.Write("iltimos, birinchi sonni kiriting=> ");
int x= Convert.ToInt32(Console.ReadLine());
Console.Write("iltimos, ikkinchi sonni kiriting=> ");
int y= Convert.ToInt32(Console.ReadLine());
if (x>y)
{
    Console.WriteLine($"{x} katta {y} dan");
}
else if (x<y)
{
    Console.WriteLine($"{x} kichik {y} dan");
}
else if (x==y)
{
    Console.WriteLine($"{x} teng {y} ga");
}
else
{
    Console.WriteLine($"{x} ni {y} ga solishtirib bo'lmaydi");
}
Console.WriteLine();

//3. hafta kuni
Console.Write("hafta kunini kiriting=> ");
string str1 = Console.ReadLine();
if ( str1.ToLower()=="dushanba")
{
    Console.WriteLine("Monday");
}
else if ( str1.ToLower()=="seshanba")
{
    Console.WriteLine("Tuesday");
}
else if ( str1.ToLower()=="chorshanba")
{
    Console.WriteLine("Wednesday");
}
else if ( str1.ToLower()=="payshanba")
{
    Console.WriteLine("Thursday");
}
else if ( str1.ToLower()=="juma")
{
    Console.WriteLine("Friday");
}
else if ( str1.ToLower()=="shanba")
{
    Console.WriteLine("Saturday");
}
else if ( str1.ToLower()=="yakshanba")
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("There is no such day of the week");
}