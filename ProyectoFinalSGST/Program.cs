Incidencia[] incidencias = new Incidencia[100];
int cantidad = 0;

Tecnico[] tecnicos = new Tecnico[50];
int cantidadTecnicos = 0;

int MainMenu()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("=== SISTEMA DE SOPORTE TECNOLOGIA UAM ===");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("1. Gestión de incidencias");
    Console.WriteLine("2. Gestión de Técnicos");
    Console.WriteLine("3. Reportes y estadísticas");
    Console.WriteLine("4. Guardar información");
    Console.WriteLine("5. Cargar información");
    Console.WriteLine("0. Salir");
    Console.ResetColor();
    Console.ForegroundColor= ConsoleColor.DarkGreen;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    return int.Parse(Console.ReadLine()!);
}

int MenuIncidencias()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=== GESTION DE INCIDENCIAS ===");
    Console.WriteLine("1. Registrar incidencia");
    Console.WriteLine("2. Buscar incidencia");
    Console.WriteLine("3. Modificar incidencia");
    Console.WriteLine("4. Eliminar incidencia");
    Console.WriteLine("5. Mostrar incidencias");
    Console.WriteLine("0. Regresar");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    return int.Parse(Console.ReadLine()!);
}

int MenuTecnicos()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=== GESTION DE TÉCNICOS ===");
    Console.WriteLine("1. Registrar técnico");
    Console.WriteLine("2. Mostrar técnicos");
    Console.WriteLine("3. Asignar técnico");
    Console.WriteLine("4. Reasignar técnico");
    Console.WriteLine("5. Eliminar técnico");
    Console.WriteLine("0. Regresar");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    return int.Parse(Console.ReadLine()!);
}

int MenuReportes()
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=== REPORTES Y ESTADÍSTICAS ===");
    Console.WriteLine("1. Reporte general");
    Console.WriteLine("2. Incidencias por categoria");
    Console.WriteLine("3. Incidencias por prioridad");
    Console.WriteLine("4. Incidencias por edificio");
    Console.WriteLine("5. Incidencias por piso");
    Console.WriteLine("6. Técnico mas ocupado");
    Console.WriteLine("7. Técnico menos ocupado");
    Console.WriteLine("8. Aula con mas reportes");
    Console.WriteLine("9. Historial mensual");
    Console.WriteLine("10. Comparacion entre meses");
    Console.WriteLine("0. Regresar");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();

    return int.Parse(Console.ReadLine()!);
}

// GESTION DE INCIDENCIAS

void RegistrarIncidencia()
{
    Console.Clear();

    Console.Write("Codigo: ");
    incidencias[cantidad].Codigo = Console.ReadLine()!;

    Console.Write("Nombre del reportante: ");
    incidencias[cantidad].Reportante = Console.ReadLine()!;

    Console.Write("Tipo de usuario: ");
    incidencias[cantidad].TipoUsuario = Console.ReadLine()!;

    Console.Write("Aula: ");
    incidencias[cantidad].Aula = Console.ReadLine()!;

    Console.Write("Categoria: ");
    incidencias[cantidad].Categoria = Console.ReadLine()!;

    Console.Write("Descripcion: ");
    incidencias[cantidad].Descripcion = Console.ReadLine()!;

    Console.Write("Mes (1-12): ");
    string mes = Console.ReadLine()!;

    Console.Write("Año: ");
    string anio = Console.ReadLine()!;

    incidencias[cantidad].Fecha = mes + "/" + anio;

    Console.Write("Prioridad: ");
    incidencias[cantidad].Prioridad = Console.ReadLine()!;

    Console.Write("Estado: ");
    incidencias[cantidad].Estado = Console.ReadLine()!;

    cantidad++;

    Console.WriteLine("\nIncidencia registrada correctamente.");
    Console.ReadKey();
}

void BuscarIncidencia()
{
    Console.Clear();

    Console.Write("Ingrese codigo: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Codigo == buscar)
        {
            Console.WriteLine("\nCodigo: " + incidencias[i].Codigo);
            Console.WriteLine("Reportante: " + incidencias[i].Reportante);
            Console.WriteLine("Tipo Usuario: " + incidencias[i].TipoUsuario);
            Console.WriteLine("Aula: " + incidencias[i].Aula);
            Console.WriteLine("Categoria: " + incidencias[i].Categoria);
            Console.WriteLine("Descripcion: " + incidencias[i].Descripcion);
            Console.WriteLine("Fecha: " + incidencias[i].Fecha);
            Console.WriteLine("Prioridad: " + incidencias[i].Prioridad);
            Console.WriteLine("Estado: " + incidencias[i].Estado);

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Incidencia no encontrada.");
    }

    Console.ReadKey();
    Console.WriteLine();
}

void ModificarIncidencia()
{
    Console.Clear();

    Console.Write("Codigo a modificar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Codigo == buscar)
        {
            Console.Write("Nuevo estado: ");
            incidencias[i].Estado = Console.ReadLine()!;

            Console.Write("Nueva prioridad: ");
            incidencias[i].Prioridad = Console.ReadLine()!;

            Console.Write("Nueva descripcion: ");
            incidencias[i].Descripcion = Console.ReadLine()!;

            Console.WriteLine("\nIncidencia modificada.");

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Incidencia no encontrada.");
    }

    Console.ReadKey();
    Console.WriteLine();
}

void EliminarIncidencia()
{
    Console.Clear();

    Console.Write("Codigo a eliminar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Codigo == buscar)
        {
            for (int j = i; j < cantidad - 1; j++)
            {
                incidencias[j].Codigo = incidencias[j + 1].Codigo;
                incidencias[j].Reportante = incidencias[j + 1].Reportante;
                incidencias[j].TipoUsuario = incidencias[j + 1].TipoUsuario;
                incidencias[j].Aula = incidencias[j + 1].Aula;
                incidencias[j].Categoria = incidencias[j + 1].Categoria;
                incidencias[j].Descripcion = incidencias[j + 1].Descripcion;
                incidencias[j].Fecha = incidencias[j + 1].Fecha;
                incidencias[j].Prioridad = incidencias[j + 1].Prioridad;
                incidencias[j].Estado = incidencias[j + 1].Estado;
            }

            cantidad--;
            encontrado = true;

            Console.WriteLine("\nIncidencia eliminada.");
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Incidencia no encontrada.");
    }

    Console.ReadKey();
    Console.WriteLine();
}

void MostrarIncidencias()
{
    Console.Clear();

    if (cantidad == 0)
    {
        Console.WriteLine("No hay incidencias registradas.");
    }
    else
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("\n====================");
            Console.WriteLine("Codigo: " + incidencias[i].Codigo);
            Console.WriteLine("Reportante: " + incidencias[i].Reportante);
            Console.WriteLine("Tipo de Usuario: " + incidencias[i].TipoUsuario);
            Console.WriteLine("Aula: " + incidencias[i].Aula);
            Console.WriteLine("Categoria: " + incidencias[i].Categoria);
            Console.WriteLine("Descripcion: " + incidencias[i].Descripcion);
            Console.WriteLine("Fecha: " + incidencias[i].Fecha);
            Console.WriteLine("Prioridad: " + incidencias[i].Prioridad);
            Console.WriteLine("Estado: " + incidencias[i].Estado);
        }
    }

    Console.ReadKey();
    Console.WriteLine();
}

// GESTION DE TECNICOS
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
    Console.WriteLine("Función en desarrollo.");
    Console.ReadKey();
}
void EliminarTecnico()
{
    Console.Clear();

    Console.Write("ID del técnico a eliminar: ");
    int buscar = int.Parse(Console.ReadLine()!);

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            for (int j = i; j < cantidadTecnicos - 1; j++)
            {
                tecnicos[j] = tecnicos[j + 1];
            }

            cantidadTecnicos--;

            Console.WriteLine("\nTécnico eliminado correctamente.");
            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("\nTécnico no encontrado.");
    }

    Console.ReadKey();
}

void HistorialMensual()
{
    Console.Clear();

    int[] meses = new int[12];

    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');

        if (fecha.Length == 2)
        {
            int mes = int.Parse(fecha[0]);
            meses[mes - 1]++;
        }
    }

    Console.WriteLine("===== HISTORIAL MENSUAL =====");

    for (int i = 0; i < 12; i++)
    {
        Console.WriteLine("Mes " + (i + 1) + ": " + meses[i] + " incidencias");
    }

    Console.ReadKey();
}

void CompararMeses()
{
    Console.Clear();

    int[] meses = new int[12];

    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');

        if (fecha.Length == 2)

        {
            int mes = int.Parse(fecha[0]);
            meses[mes - 1]++;
        }
    }

    Console.WriteLine("===== COMPARACION ENTRE MESES =====");

    for (int i = 1; i < 12; i++)
    {
        int diferencia = meses[i] - meses[i - 1];

        Console.WriteLine(
            "Mes " + i +
            " -> Mes " + (i + 1) +
            " = " + diferencia + " incidencias");
    }

    Console.ReadKey();
}

void Main()
{
    int opcionMain;
    do
    {
        opcionMain = MainMenu();
        switch (opcionMain)
        {
            case 1:
                int opcionIncidencias;
                do
                {
                    opcionIncidencias = MenuIncidencias();
                    switch (opcionIncidencias)
                    {
                        case 1:
                            RegistrarIncidencia();
                            break;
                        case 2:
                            BuscarIncidencia();
                            break;
                        case 3:
                            ModificarIncidencia();
                            break;
                        case 4:
                            EliminarIncidencia();
                            break;
                        case 5:
                            MostrarIncidencias();
                            break;
                        case 0:
                            Console.WriteLine("Regresando al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                } while (opcionIncidencias != 0);
                break;
            case 2:
                int opcionTecnicos;
                do
                {
                    opcionTecnicos = MenuTecnicos();
                    switch(opcionTecnicos)
                    {
                        case 1:
                            RegistrarTecnico();
                            break;
                        case 2:
                            MostrarTecnicos();
                            break;
                        case 3:
                            AsignarTecnico();
                            break;
                        case 4:
                            ReasignarTecnico();
                            break;
                        case 5:
                            EliminarTecnico();
                            break;
                           
                        case 0:
                            Console.WriteLine("Regresando al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                } while (opcionTecnicos != 0);
                break;
            case 3:
                int opcionReportes;

                do
                {
                    opcionReportes = MenuReportes();

                    switch (opcionReportes)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Total de incidencias registradas: " + cantidad);
                            Console.ReadKey();
                            break;

                        case 9:
                            HistorialMensual();
                            break;

                        case 10:
                            CompararMeses();
                            break;

                        case 0:
                            Console.WriteLine("Regresando al menú principal...");
                            break;

                        default:
                            Console.WriteLine("Reporte en desarrollo.");
                            Console.ReadKey();
                            break;
                    }

                } while (opcionReportes != 0);

                break;
            case 4:
                break;
            case 5:
                break;
            case 0:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Saliendo del sistema...");
                Console.ResetColor();
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
    } while (opcionMain != 0);
}

Main();

struct Incidencia
{
    public string Codigo;
    public string Reportante;
    public string TipoUsuario;
    public string Aula;
    public string Categoria;
    public string Descripcion;
    public string Fecha;
    public string Prioridad;
    public string Estado;
}

struct Tecnico
{
    public int id;
    public string nombre;
    public string especialidad;
    public bool disponible;
    public int casos;
}