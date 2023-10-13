using System;
abstract class Celular
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
    public abstract void MostrarCelular();
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
    public override void MostrarCelular()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
        Console.WriteLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}");
        Console.WriteLine($"Precio: ${Precio}");
    }
}
class CelularDefectuoso : Celular
{
    public DateTime FechaDefecto { get; set; }
    public string Motivo { get; set; }
    public CelularDefectuoso(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento, DateTime fechaDefecto, string motivo)
        : base(marca, modelo, sistemaOperativo, ram, almacenamiento)
    {
        FechaDefecto = fechaDefecto;
        Motivo = motivo;
    }
    public override void MostrarCelular()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
        Console.WriteLine($"RAM: {RAM} GB");
        Console.WriteLine($"Almacenamiento: {Almacenamiento} GB");
        Console.WriteLine($"Fecha de Defecto: {FechaDefecto.ToShortDateString()}");
        Console.WriteLine($"Motivo del Defecto: {Motivo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CelularNuevo celularNuevo = new CelularNuevo("Samsung", "Galaxy S21", "Android", 8, 128, DateTime.Now, 799.99);
        CelularDefectuoso celularDefectuoso = new CelularDefectuoso("Apple", "iPhone 12", "iOS", 6, 64, DateTime.Now, "Pantalla rota");
        Console.WriteLine("Informacion del Celular Nuevo:");
        celularNuevo.MostrarCelular();
        Console.WriteLine();
        Console.WriteLine("Informacion del Celular Defectuoso:");
        celularDefectuoso.MostrarCelular();
    }
}
