using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Clavo", Precio = 9.5m, IdProducto = 1, FechaProducto = DateTime.Now },
            new Producto { Nombre = "Tornillos", Precio = 8.3m, IdProducto =  2, FechaProducto = DateTime.Now },
            new Producto { Nombre = "Taquetes", Precio = 7.2m, IdProducto = 3, FechaProducto = DateTime.Now }
        };
        Console.Write("Ingrese el ID del producto a buscar: ");
        int id = int.Parse(Console.ReadLine());

        Producto productoEncontrado = BuscarPorId(productos, id);

        if(productoEncontrado != null)
        {
            Console.WriteLine($"Producto encontrado: {productoEncontrado.Nombre}, Precio: {productoEncontrado.Precio}, Fecha: {productoEncontrado.FechaProducto.ToString("d")}");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }

    }


    static Producto BuscarPorId(List<Producto> productos, int id)
    {

        
        foreach (var producto in productos)
        {
            if (producto.IdProducto == id)
            {
                return producto;
            }
        } 
            return null;
    }

    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int IdProducto { get; set; }

        public DateTime FechaProducto { get; set; }
    }
}
