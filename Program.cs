using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ===== GESTOR DE VEHICULOS ===== ");

        // Creamos un auto
        Auto coche1 = new Auto();
        coche1.Marca = "Toyota";
        coche1.Modelo = "Corolla";
        coche1.Año = 2020;
        coche1.NumPuertas = 4;
        coche1.MostrarInfo();

        Console.WriteLine();

        // Creamos una moto
        Moto moto1 = new Moto();
        moto1.Marca = "Yamaha";
        moto1.Modelo = "R1";
        moto1.Año = 2022;
        moto1.Cilindrada = 1000;
        moto1.MostrarInfo();

        Console.WriteLine();
        Console.WriteLine(">>>>> PRESIONE ENTER PARA SALIR <<<<<");
        Console.ReadKey();
    }

    // Clase base
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
        }
    }

    // Clase derivada: Auto
    public class Auto : Vehiculo
    {
        public int NumPuertas { get; set; }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Número de Puertas: {NumPuertas}");
        }
    }

    // Clase derivada: Moto
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cilindrada: {Cilindrada} cc");
        }
    }
}
