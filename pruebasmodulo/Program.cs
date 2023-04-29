using System.ComponentModel.Design;
using System.Data;

int valoruno = 2;
int valordos = 100;
int valortres = 77;

int resultado = valoruno + valordos + valortres;

Console.WriteLine(resultado);

//Ejercicio 2

Console.WriteLine("Por favor ingrese el nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese una ciudad");
string ciudad = Console.ReadLine();

Console.WriteLine($"Hola {nombre} bienvenido a {ciudad}");

//Ejercicio 3

Console.WriteLine("Por favor ingrese el nombre");
string nombreuno = Console.ReadLine();

Console.WriteLine("Por favor ingrese la edad");
string edad = Console.ReadLine();

Console.WriteLine($"Te llamas {nombreuno} y tienes {edad} años");

//Ejercicio 4 

Console.WriteLine("Favor ingrese dos numeros");
int numerouno = int.Parse(Console.ReadLine());

Console.WriteLine("Numero dos: ");
int numerodos = int.Parse(Console.ReadLine());

if (numerouno > numerodos)
{
    Console.WriteLine($"{numerouno} es mayor");
}
else
{
    Console.WriteLine($"{numerodos} es mayor");
}

//Ejercicio 5

Console.WriteLine("Por favor ingrese un nombre de la semana para indicarle si es fin de semana o no"); string semana = Console.ReadLine();

switch (semana)
{
    case "Lunes":
        Console.WriteLine("No es fin de semana");
        break;
    case "Martes":
        Console.WriteLine("No es fin de semana");
        break;
    case "Miercoles":
        Console.WriteLine("No es fin de semana");
        break;
    case "Jueves":
        Console.WriteLine("No es fin de semana");
        break;
    case "Viernes":
        Console.WriteLine("No es fin de semana");
        break;
    case "Sabado":
        Console.WriteLine("Es fin se semana");
        break;
    case "Domingo":
        Console.WriteLine("Es fin se semana");
        break;

    default:
        Console.WriteLine("El Nombre que ingreso es incorrecto");
        break;
}

//Ejercicio 6

Console.WriteLine("Ingrese el precio del producto que desea adquirir");
int valorproducto = int.Parse(Console.ReadLine());

string pago = "";
if (valorproducto > 0)
{
    Console.WriteLine("Ingrese si el metodo de pago sera efectivo o tarjeta");
    pago = Console.ReadLine();
    if (pago == "efectivo")
    {
        Console.WriteLine("Gracias por su compra");
    }
}
else
{
    Console.WriteLine("Ingrese un monto positivo");
}

if (pago == "tarjeta")
{
    Console.WriteLine("Ingrese el numero de cuenta");
    string nrocuenta = Console.ReadLine();
    Console.WriteLine("Gracias por su compra");
}

//Ejercicio 7

Console.WriteLine("Ejercicio 7");
for (int i = 0; i <= 99; i++)
{
    Console.WriteLine(i + 1);
}

//Ejercicio 8

Console.WriteLine("Ejercicio 8");
int num = 0;
while (num <= 99)
{
    num++;
    Console.WriteLine(num);
}

//Ejercicio 9

Console.WriteLine("Ejercicio 9");
for (int i = 0; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//Ejercicio 10

Console.WriteLine("Ejercicio 10");
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}










