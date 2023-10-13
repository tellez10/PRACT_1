using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Funciones funcion = new Funciones();
        funcion.AgregarCelulares();
        funcion.Prom_Celular();
        funcion.Cel_MarcaS();
        funcion.Celular_RSA();
        funcion.Celular_Ingreso();
        funcion.Exp_Lambda();
        funcion.Cons_Linq();
    }
}

class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string SistemaOperativo { get; set; }
    public int RAM { get; set; }
    public int Almacenamiento { get; set; }
    public Celular(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento)
    {
        Marca = marca;
        Modelo = modelo;
        SistemaOperativo = sistemaOperativo;
        RAM = ram;
        Almacenamiento = almacenamiento;
    }
}

class CelularNuevo : Celular
{
    public DateTime FechaIngreso { get; set; }
    public double Precio { get; set; }

    public CelularNuevo(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento, DateTime fechaIngreso, double precio)
        : base(marca, modelo, sistemaOperativo, ram, almacenamiento)
    {
        FechaIngreso = fechaIngreso;
        Precio = precio;
    }
}

class Funciones
{
    private List<CelularNuevo> celularesNuevos = new List<CelularNuevo>();

    public void AgregarCelulares()
    {
        celularesNuevos.Add(new CelularNuevo("Samsung", "Galaxy S21", "Android", 8, 128, new DateTime(2022, 1, 15), 799.99));
        celularesNuevos.Add(new CelularNuevo("Apple", "iPhone 12", "iOS", 6, 64, new DateTime(2022, 3, 10), 899.99));
        celularesNuevos.Add(new CelularNuevo("Samsung", "Galaxy S22", "Android", 12, 256, new DateTime(2022, 2, 5), 999.99));
        celularesNuevos.Add(new CelularNuevo("Apple", "iPhone 13", "iOS", 6, 128, new DateTime(2022, 5, 20), 1099.99));
        celularesNuevos.Add(new CelularNuevo("Google", "Pixel 6", "Android", 8, 128, new DateTime(2022, 4, 30), 799.99));
        celularesNuevos.Add(new CelularNuevo("OnePlus", "9 Pro", "Android", 12, 256, new DateTime(2022, 6, 10), 899.99));
        celularesNuevos.Add(new CelularNuevo("Samsung", "Galaxy S21 FE", "Android", 6, 128, new DateTime(2022, 7, 1), 599.99));
        celularesNuevos.Add(new CelularNuevo("Apple", "iPhone SE", "iOS", 4, 64, new DateTime(2022, 8, 15), 499.99));
        celularesNuevos.Add(new CelularNuevo("Xiaomi", "Mi 11", "Android", 8, 256, new DateTime(2022, 9, 5), 699.99));
        celularesNuevos.Add(new CelularNuevo("Samsung", "Galaxy A52", "Android", 6, 128, new DateTime(2022, 10, 20), 499.99));
    }

    public void Prom_Celular()
    {
        Console.WriteLine("-----------------------------------------");
        double promedioPrecio = celularesNuevos.Average(c => c.Precio);
        Console.WriteLine($"PPOMEDIO PRECIOS DE CELULARES: ${promedioPrecio:F2}\n");
    }

    public void Cel_MarcaS()
    {
        Console.WriteLine("-----------------------------------------");
        var celularesSamsung = celularesNuevos.Where(c => c.Marca.Equals("Samsung")).ToList();
        Console.WriteLine("CELULARES MARCA SAMSUMG:");
        foreach (var celular in celularesSamsung)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}");
            Console.WriteLine($"Precio: ${celular.Precio}");
            Console.WriteLine();
        }
    }

    public void Celular_RSA()
    {
        var resultado = from celular in celularesNuevos
                        where celular.RAM == 8 && celular.SistemaOperativo == "Android" && celular.Almacenamiento == 128
                        select celular;
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("CELULARES CON  RAM = 8GB, SO = ANDROID Y ALAMCENAMIENTO DE 128 GB:");
        foreach (var celular in resultado)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}");
            Console.WriteLine($"Precio: ${celular.Precio}");
            Console.WriteLine();
        }
    }

    public void Celular_Ingreso()
    {
        var resultado = from celular in celularesNuevos
                        where celular.FechaIngreso.Year == 2005
                        select celular;
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("CELULARES QUE INGRESARON EL ANIO 2005:");
        foreach (var celular in resultado)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}");
            Console.WriteLine($"Precio: ${celular.Precio}");
            Console.WriteLine();
        }
    }

    public void Exp_Lambda()
    {
        var celularesApple = celularesNuevos.Where(c => c.Marca.Equals("Apple"));
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Modelo y Precio de los Celulares Apple (Expresiones Lambda):");
        foreach (var celular in celularesApple)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}");
            Console.WriteLine($"Precio: ${celular.Precio}");
            Console.WriteLine();
        }
    }

    public void Cons_Linq()
    {
        var celularesApple = from celular in celularesNuevos
                             where celular.Marca.Equals("Apple")
                             select celular;
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Modelo y Precio de los Celulares Apple (Consultas LINQ):");
        foreach (var celular in celularesApple)
        {
            Console.WriteLine($"Modelo: {celular.Modelo}");
            Console.WriteLine($"Precio: ${celular.Precio}");
            Console.WriteLine();
        }
    }

}
