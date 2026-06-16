Tecnico[] tecnicos = new Tecnico[50];
int cantidadTecnicos = 0;

void RegistrarTecnico()
{
    Console.Clear();

    if (cantidadTecnicos == 50)
    {
        Console.WriteLine("No hay espacio para registrar más técnicos.");
        Console.ReadKey();
        return;
    }

    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine()!);

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == id)
        {
            encontrado = true;
            break;
        }
    }

    if (encontrado)
    {
        Console.WriteLine("ID ya registrado.");
        Console.ReadKey();
        return;
    }

    tecnicos[cantidadTecnicos].id = id;

    Console.Write("Nombre: ");
    tecnicos[cantidadTecnicos].nombre = Console.ReadLine()!;

    Console.Write("Especialidad: ");
    tecnicos[cantidadTecnicos].especialidad = Console.ReadLine()!;

    tecnicos[cantidadTecnicos].disponible = true;
    tecnicos[cantidadTecnicos].casos = 0;

    cantidadTecnicos++;

    Console.WriteLine("\nTécnico registrado correctamente.");
    Console.ReadKey();
}

void MostrarTecnicos()
{
    Console.Clear();

    if (cantidadTecnicos == 0)
    {
        Console.WriteLine("No hay técnicos registrados.");
    }
    else
    {
        for (int i = 0; i < cantidadTecnicos; i++)
        {
            Console.WriteLine("\n====================");
            Console.WriteLine("ID: " + tecnicos[i].id);
            Console.WriteLine("Nombre: " + tecnicos[i].nombre);
            Console.WriteLine("Especialidad: " + tecnicos[i].especialidad);
            Console.WriteLine("Casos: " + tecnicos[i].casos);
            Console.WriteLine("Disponible: " + tecnicos[i].disponible);
        }
    }

    Console.ReadKey();
}

void AsignarTecnico()
{
    Console.Clear();

    Console.Write("Ingrese ID del técnico: ");
    int buscar = int.Parse(Console.ReadLine()!);

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            if (tecnicos[i].disponible)
            {
                tecnicos[i].disponible = false;
                tecnicos[i].casos++;

                Console.WriteLine("\nTécnico asignado.");
            }
            else
            {
                Console.WriteLine("El técnico no está disponible.");
            }

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Técnico no encontrado.");
    }

    Console.ReadKey();
}

void ReasignarTecnico()
{
    Console.Clear();

    Console.Write("Ingrese ID del técnico: ");
    int buscar = int.Parse(Console.ReadLine()!);

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            tecnicos[i].disponible = true;

            Console.WriteLine("\nTécnico liberado.");

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Técnico no encontrado.");
    }

    Console.ReadKey();
}

struct Tecnico
{
    public int id;
    public string nombre;
    public string especialidad;
    public bool disponible;
    public int casos;
}