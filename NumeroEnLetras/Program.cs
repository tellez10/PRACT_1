using System;

public static class Numero
{
    private static string[] unidades = {
        "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"
    };

    private static string[] decenas = {
        "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"
    };

    private static string[] especiales = {
        "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"
    };

    public static string Convertir(int numero)
    {
        if (numero < 10)
        {
            return unidades[numero];
        }
        else if (numero < 20)
        {
            return especiales[numero - 10];
        }
        else
        {
            int unidad = numero % 10;
            int decena = numero / 10;
            return decenas[decena] + (unidad > 0 ? " y " + unidades[unidad] : "");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Numero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string literal = Numero.Convertir(numero);
            Console.WriteLine($"literal: {literal}");
        }
        else
        {
            Console.WriteLine("Ingresar un numero valido.");
        }
    }
}
