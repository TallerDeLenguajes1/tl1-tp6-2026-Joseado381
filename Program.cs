Console.WriteLine("Jellow, Guor");

int a, b;
a = 10;
b = a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

Console.WriteLine("Ingrese un Numero");

string texto = Console.ReadLine();

int Numero;

if (int.TryParse(texto, out Numero))
{
    int invertido = 0;
    if (Numero > 0 )
    {
        while (Numero > 0)
        {
            int digito = Numero % 10;
            invertido = invertido * 10 + digito;
            Numero = Numero / 10;

        }
    }else
    {
        Console.WriteLine("El numero debe ser mayor a 0");
    }
}else
{
    Console.WriteLine("El texto ingresado no es un numero");
}