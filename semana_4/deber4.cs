using System;

namespace AgendaTelefonica
{
    struct Contacto
    {
        public string Nombre;
        public string Telefono;
        public string Correo;
    }

    class Agenda
    {
        private Contacto[] contactos;
        private int contador;

        public Agenda(int tamaño)
        {
            contactos = new Contacto[tamaño];
            contador = 0;
        }

        public void AgregarContacto()
        {
            if (contador >= contactos.Length)
            {
                Console.WriteLine("Agenda llena.");
                return;
            }

            Console.Write("Nombre: ");
            contactos[contador].Nombre = Console.ReadLine() ?? "";

            Console.Write("Teléfono: ");
            contactos[contador].Telefono = Console.ReadLine() ?? "";

            Console.Write("Correo: ");
            contactos[contador].Correo = Console.ReadLine() ?? "";

            contador++;
            Console.WriteLine("Contacto agregado correctamente.");
        }

        public void MostrarContactos()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay contactos registrados.");
                return;
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\nContacto #" + (i + 1));
                Console.WriteLine("Nombre: " + contactos[i].Nombre);
                Console.WriteLine("Teléfono: " + contactos[i].Telefono);
                Console.WriteLine("Correo: " + contactos[i].Correo);
            }
        }

        public void BuscarContacto()
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine() ?? "";

            for (int i = 0; i < contador; i++)
            {
                if (contactos[i].Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contacto encontrado:");
                    Console.WriteLine("Nombre: " + contactos[i].Nombre);
                    Console.WriteLine("Teléfono: " + contactos[i].Telefono);
                    Console.WriteLine("Correo: " + contactos[i].Correo);
                    return;
                }
            }

            Console.WriteLine("Contacto no encontrado.");
        }
    }

    class Program
    {
        static void Main()
        {
            Agenda agenda = new Agenda(10);
            int opcion = 0;

            do
            {
                Console.WriteLine("\nAGENDA TELEFÓNICA");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        agenda.AgregarContacto();
                        break;
                    case 2:
                        agenda.MostrarContactos();
                        break;
                    case 3:
                        agenda.BuscarContacto();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
