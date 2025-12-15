using System;

class Estudiante
{
    // Atributos de la clase
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos;

    // Método para mostrar los datos
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("- " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear objeto estudiante
        Estudiante est = new Estudiante();

        // Ingreso de datos
        Console.Write("Ingrese ID: ");
        est.Id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        est.Direccion = Console.ReadLine();

        // Array de teléfonos
        est.Telefonos = new string[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingrese teléfono " + (i + 1) + ": ");
            est.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar información
        Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
        est.MostrarDatos();
    }
}
