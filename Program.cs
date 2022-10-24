Console.WriteLine("Deklarera det första flyttalet: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Deklarera det andra flyttalet: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Deklarera det tredje flyttalet: ");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Medelvärdet på talet är: " + Medelvärde(a, b, c));

static double Medelvärde(double a, double b, double c)
{
return((a+b+c)/3);
}
