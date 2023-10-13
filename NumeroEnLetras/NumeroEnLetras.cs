using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class NumEnLetras
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

    public static string ConvertirEnLetras(int numero)
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
