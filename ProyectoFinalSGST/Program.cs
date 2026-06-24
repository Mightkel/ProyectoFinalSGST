using System.IO;
using System.Linq;

Incidencia[] incidencias = new Incidencia[100];
int cantidad = 0;

Tecnico[] tecnicos = new Tecnico[50];
int cantidadTecnicos = 0;

int MainMenu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("=========================================");
    Console.WriteLine("=== SISTEMA DE SOPORTE TECNOLOGIA UAM ===");
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("1. Gestión de incidencias");
    Console.WriteLine("2. Gestión de Técnicos");
    Console.WriteLine("3. Reportes y estadísticas");
    Console.WriteLine("4. Guardar información");
    Console.WriteLine("5. Cargar información");
    Console.WriteLine("0. Salir");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey(true);
        return -1;
    }

}

int MenuIncidencias()
{
    Console.Clear();
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
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}

int MenuTecnicos()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=== GESTION DE TÉCNICOS ===");
    Console.WriteLine("1. Registrar técnico");
    Console.WriteLine("2. Mostrar técnicos");
    Console.WriteLine("3. Asignar técnico");
    Console.WriteLine("4. Liberar técnico");
    Console.WriteLine("5. Modificar técnico");
    Console.WriteLine("6. Eliminar técnico");
    Console.WriteLine("0. Regresar");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}

int MenuReportes()
{
    Console.Clear();
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
    Console.WriteLine("10. Comparación entre meses");
    Console.WriteLine("11. Historial Anual");
    Console.WriteLine("12. Comparación Anual");
    Console.WriteLine("0. Regresar");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}

void MostrarError(string mensaje)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mensaje);
    Console.ResetColor();

    Console.ReadKey(true);

    int filaError = Console.CursorTop - 1;

    Console.SetCursorPosition(0, filaError);
    Console.Write(new string(' ', Console.WindowWidth));

    Console.SetCursorPosition(0, filaError);
}

// GESTION DE INCIDENCIAS
void CodigoIncidencia()
{
    string codigo;
    bool repetido;

    do
    {
        int fila = Console.CursorTop;
        repetido = false;

        Console.Write("Código de incidencia: ");
        codigo = Console.ReadLine()!;

        for (int i = 0; i < cantidad; i++)
        {
            if (incidencias[i].Codigo.ToUpper() == codigo.ToUpper())
            {
                repetido = true;
                MostrarError("El código ya existe.");

                Console.SetCursorPosition(0, fila);
                Console.Write(new string(' ', Console.WindowWidth));

                Console.SetCursorPosition(0, fila);
                break;
            }

        }

    } while (repetido);

    incidencias[cantidad].Codigo = codigo;

}

int TipoUsuario()
{
    Console.WriteLine("Seleccione el tipo de usuario:");
    Console.WriteLine("1. Estudiante");
    Console.WriteLine("2. Docente");
    Console.WriteLine("3. Administrativo");
    Console.WriteLine("4. Otro");
    Console.Write("Digite su opción: ");
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}

int AulaIncidencia()
{
    Console.Write("Aula (Ejemplo: A101): ");
    string aula = Console.ReadLine()!;
    if (aula.Length == 4 && char.IsLetter(aula[0]) && char.IsDigit(aula[1]) && char.IsDigit(aula[2]) && char.IsDigit(aula[3]))
    {
        incidencias[cantidad].Aula = aula;
        return 1;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. El formato del aula debe ser una letra seguida de tres dígitos (Ejemplo: A101).");
        Console.ResetColor();
        return -1;
    }
}

int CategoriaIncidencia()
{
    Console.WriteLine("Seleccione la categoría de la incidencia:");
    Console.WriteLine("1. Hardware");
    Console.WriteLine("2. Software");
    Console.WriteLine("3. Red");
    Console.WriteLine("4. Impresoras");
    Console.WriteLine("5. Otro");
    Console.Write("Digite su opción: ");
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}

string LeerFecha()
{
    string fecha;

    do
    {
        Console.Write("Fecha (MM/yyyy): ");
        fecha = Console.ReadLine()!;

        if (DateTime.TryParseExact(
            fecha,
            "MM/yyyy",
            null,
            System.Globalization.DateTimeStyles.None,
            out _))
        {
            return fecha;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Fecha inválida. Use el formato MM/yyyy.");
        Console.ResetColor();

    } while (true);
}

int PrioridadIncidencia()
{
    Console.WriteLine("Seleccione la prioridad de la incidencia:");
    Console.WriteLine("1. Baja");
    Console.WriteLine("2. Media");
    Console.WriteLine("3. Alta");
    Console.WriteLine("4. Crítica");
    Console.Write("Digite su opción: ");
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}

int EstadoIncidencia()
{
    Console.WriteLine("Seleccione el estado de la incidencia:");
    Console.WriteLine("1. Abierta");
    Console.WriteLine("2. En proceso");
    Console.WriteLine("3. Cerrada");
    Console.Write("Digite su opción: ");
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        return -1;
    }
}
void RegistrarIncidencia()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("          REGISTRAR INCIDENCIA           ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    if (cantidad >= 100)
    {
        Console.ForegroundColor= ConsoleColor.DarkRed;
        Console.WriteLine("===============");
        Console.WriteLine("No hay espacio.");
        Console.WriteLine("===============");
        Console.ResetColor();
        return;
    }

    CodigoIncidencia();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    Console.Write("Nombre del reportante: ");
    incidencias[cantidad].Reportante = Console.ReadLine()!;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    switch (TipoUsuario())
    {
        case 1:
            incidencias[cantidad].TipoUsuario = "Estudiante";
            break;
        case 2:
            incidencias[cantidad].TipoUsuario = "Docente";
            break;
        case 3:
            incidencias[cantidad].TipoUsuario = "Administrativo";
            break;
        case 4:
            incidencias[cantidad].TipoUsuario = "Otro";
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Opción no válida. Se asignará 'Otro' por defecto.");
            Console.ResetColor();
            incidencias[cantidad].TipoUsuario = "Otro";
            Console.ReadKey(true);
            break;
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    while (true)
    {
        int aulaResultado = AulaIncidencia();
        if (aulaResultado == 1)
        {
            break;
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    switch (CategoriaIncidencia())
    {
        case 1:
            incidencias[cantidad].Categoria = "Hardware";
            break;
        case 2:
            incidencias[cantidad].Categoria = "Software";
            break;
        case 3:
            incidencias[cantidad].Categoria = "Red";
            break;
        case 4:
            incidencias[cantidad].Categoria = "Impresoras";
            break;
        case 5:
            incidencias[cantidad].Categoria = "Otro";
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Opción no válida. Se asignará 'Otro' por defecto.");
            Console.ResetColor();
            incidencias[cantidad].Categoria = "Otro";
            Console.ReadKey(true);
            break;
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    Console.Write("Descripcion: ");
    incidencias[cantidad].Descripcion = Console.ReadLine()!;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    incidencias[cantidad].Fecha = LeerFecha();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    switch (PrioridadIncidencia())
    {
        case 1:
            incidencias[cantidad].Prioridad = "Baja";
            break;
        case 2:
            incidencias[cantidad].Prioridad = "Media";
            break;
        case 3:
            incidencias[cantidad].Prioridad = "Alta";
            break;
        case 4:
            incidencias[cantidad].Prioridad = "Crítica";
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Opción no válida. Se asignará 'Baja' por defecto.");
            Console.ResetColor();
            incidencias[cantidad].Prioridad = "Baja";
            Console.ReadKey(true);
            break;
    }

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n===========================\n");
    Console.ResetColor();
    switch (EstadoIncidencia())
    {
        case 1:
            incidencias[cantidad].Estado = "Abierta";
            break;
        case 2:
            incidencias[cantidad].Estado = "En proceso";
            break;
        case 3:
            incidencias[cantidad].Estado = "Cerrada";
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Opción no válida. Se asignará 'Abierta' por defecto.");
            Console.ResetColor();
            incidencias[cantidad].Estado = "Abierta";
            Console.ReadKey(true);
            break;
    }

    cantidad++;

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nIncidencia registrada correctamente.");
    Console.ResetColor();
    Console.ReadKey(true);
}

void BuscarIncidencia()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("           BUSCAR INCIDENCIA             ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.Write("Código a buscar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Codigo == buscar)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCodigo: " + incidencias[i].Codigo);
            Console.WriteLine("Reportante: " + incidencias[i].Reportante);
            Console.WriteLine("Tipo Usuario: " + incidencias[i].TipoUsuario);
            Console.WriteLine("Aula: " + incidencias[i].Aula);
            Console.WriteLine("Categoria: " + incidencias[i].Categoria);
            Console.WriteLine("Descripcion: " + incidencias[i].Descripcion);
            Console.WriteLine("Fecha: " + incidencias[i].Fecha);
            Console.WriteLine("Prioridad: " + incidencias[i].Prioridad);
            Console.WriteLine("Estado: " + incidencias[i].Estado);
            Console.ResetColor();

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Incidencia no encontrada.");
        Console.ResetColor();
    }

    Console.ReadKey(true);
    Console.WriteLine();
}

void ModificarIncidencia()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("           MODIFICAR INCIDENCIA          ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    Console.Write("Código a modificar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Codigo == buscar)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================\n");
            Console.ResetColor();
            switch (TipoUsuario())
            {
                case 1:
                    incidencias[i].TipoUsuario = "Estudiante";
                    break;
                case 2:
                    incidencias[i].TipoUsuario = "Docente";
                    break;
                case 3:
                    incidencias[i].TipoUsuario = "Administrativo";
                    break;
                case 4:
                    incidencias[i].TipoUsuario = "Otro";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Opción no válida. Se asignará 'Otro' por defecto.");
                    Console.ResetColor();
                    incidencias[i].TipoUsuario = "Otro";
                    Console.ReadKey(true);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================\n");
            Console.ResetColor();
            switch (CategoriaIncidencia())
            {
                case 1:
                    incidencias[i].Categoria = "Hardware";
                    break;
                case 2:
                    incidencias[i].Categoria = "Software";
                    break;
                case 3:
                    incidencias[i].Categoria = "Red";
                    break;
                case 4:
                    incidencias[i].Categoria = "Impresoras";
                    break;
                case 5:
                    incidencias[i].Categoria = "Otro";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Opción no válida. Se asignará 'Otro' por defecto.");
                    Console.ResetColor();
                    incidencias[i].Categoria = "Otro";
                    Console.ReadKey(true);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================\n");
            Console.ResetColor();
            switch (EstadoIncidencia())
            {
                case 1:
                    incidencias[i].Estado = "Abierta";
                    break;
                case 2:
                    incidencias[i].Estado = "En proceso";
                    break;
                case 3:
                    incidencias[i].Estado = "Cerrada";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Opción no válida. Se asignará 'Abierta' por defecto.");
                    Console.ResetColor();
                    incidencias[i].Estado = "Abierta";
                    Console.ReadKey(true);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================\n");
            Console.ResetColor();
            switch (PrioridadIncidencia())
            {
                case 1:
                    incidencias[i].Prioridad = "Baja";
                    break;
                case 2:
                    incidencias[i].Prioridad = "Media";
                    break;
                case 3:
                    incidencias[i].Prioridad = "Alta";
                    break;
                case 4:
                    incidencias[i].Prioridad = "Crítica";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Opción no válida. Se asignará 'Baja' por defecto.");
                    Console.ResetColor();
                    incidencias[i].Prioridad = "Baja";
                    Console.ReadKey(true);
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================\n");
            Console.ResetColor();
            Console.Write("Nueva descripcion: ");
            incidencias[i].Descripcion = Console.ReadLine()!;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nIncidencia modificada.");
            Console.ResetColor();

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Incidencia no encontrada.");
    }

    Console.ReadKey(true);
    Console.WriteLine();
}

void EliminarIncidencia()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("           ELIMINAR INCIDENCIA           ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    Console.Write("Código a eliminar: ");
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

    Console.ReadKey(true);
    Console.WriteLine();
}

void MostrarIncidencias()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("          MOSTRAR INCIDENCIAS            ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    if (cantidad == 0)
    {
        Console.WriteLine("No hay incidencias registradas.");
    }
    else
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n===========================\n");
            Console.ResetColor();
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

    Console.ReadKey(true);
    Console.WriteLine();
}

// GESTION DE TECNICOS
void RegistrarTecnico()
{
    Console.Clear();

    if (cantidadTecnicos == 50)
    {
        Console.WriteLine("No hay espacio para registrar más técnicos.");
        Console.ReadKey(true);
        return;
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("            REGISTRAR TÉCNICO            ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();


    string Id;
    bool encontrado;
    do
    {
        int fila = Console.CursorTop;
        encontrado = false;

        Console.Write("ID: ");
        Id = Console.ReadLine()!;

        for (int i = 0; i < cantidadTecnicos; i++)
        {
            if (tecnicos[i].id.ToUpper() == Id.ToUpper())
            {
                encontrado = true;
                MostrarError("ID ya registrado.");

                Console.SetCursorPosition(0, fila);
                Console.Write(new string(' ', Console.WindowWidth));

                Console.SetCursorPosition(0, fila);

                break;
            }
        }
    } while (encontrado);

    tecnicos[cantidadTecnicos].id = Id;

    Console.Write("Nombre: ");
    tecnicos[cantidadTecnicos].nombre = Console.ReadLine()!;

    Console.Write("Especialidad: ");
    tecnicos[cantidadTecnicos].especialidad = Console.ReadLine()!;

    tecnicos[cantidadTecnicos].disponible = true;
    tecnicos[cantidadTecnicos].casos = 0;

    cantidadTecnicos++;

    Console.WriteLine("\nTécnico registrado correctamente.");
    Console.ReadKey(true);
}

void MostrarTecnicos()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("            MOSTRAR TÉCNICOS             ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    if (cantidadTecnicos == 0)
    {
        Console.WriteLine("No hay técnicos registrados.");
    }
    else
    {
        for (int i = 0; i < cantidadTecnicos; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====================");
            Console.ResetColor();
            Console.WriteLine("ID: " + tecnicos[i].id);
            Console.WriteLine("Nombre: " + tecnicos[i].nombre);
            Console.WriteLine("Especialidad: " + tecnicos[i].especialidad);
            Console.WriteLine("Casos: " + tecnicos[i].casos);
            Console.WriteLine("Disponible: " + tecnicos[i].disponible);
            Console.WriteLine("Incidencia Asignada: " + tecnicos[i].incidenciaAsignada);
        }
    }

    Console.ReadKey(true);
}

void AsignarTecnico()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("            ASIGNAR TÉCNICOS             ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Ingrese ID del técnico: ");
    string buscar = Console.ReadLine()!;
    Console.ResetColor();

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            if (tecnicos[i].disponible)
            {
                Console.ReadKey(true);
                Console.Clear();

                int fila = Console.CursorTop;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Ingrese el Código de la incidencia a asignar: ");
                string buscarincidencia = Console.ReadLine()!;
                Console.ResetColor();

                bool encontradoincidencia = false;

                for (int j = 0; j < cantidad; j++)
                {
                    if (incidencias[j].Codigo == buscarincidencia)
                    {
                        encontradoincidencia = true;
                        tecnicos[i].incidenciaAsignada = buscarincidencia;

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nTécnico asignado.");
                        Console.ResetColor();

                        incidencias[j].Estado = "En proceso";
                        tecnicos[i].disponible = false;
                        tecnicos[i].casos++;
                        encontrado = true;

                        break;
                    }
                }

                if (!encontradoincidencia)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Incidencia no encontrada.");
                    Console.ResetColor();

                    Console.SetCursorPosition(0, fila);
                    Console.Write(new string(' ', Console.WindowWidth));

                    Console.SetCursorPosition(0, fila);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("El técnico no está disponible.");
                Console.ResetColor();
            }
            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Técnico no encontrado.");
    }

    Console.ReadKey(true);
}

void LiberarTecnico()
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("            LIBERAR TÉCNICOS             ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    Console.Write("Ingrese ID del técnico: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            tecnicos[i].disponible = true;
            tecnicos[i].incidenciaAsignada = "";

            Console.WriteLine("\nTécnico liberado.");

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Técnico no encontrado.");
    }

    Console.ReadKey(true);
}

void ModificarTecnico()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("           MODIFICAR TÉCNICOS            ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    Console.Write("Ingrese ID del técnico a modificar: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            Console.WriteLine("\nDatos actuales:");
            Console.WriteLine("Nombre: " + tecnicos[i].nombre);
            Console.WriteLine("Especialidad: " + tecnicos[i].especialidad);

            Console.Write("\nNuevo nombre: ");
            tecnicos[i].nombre = Console.ReadLine()!;

            Console.Write("Nueva especialidad: ");
            tecnicos[i].especialidad = Console.ReadLine()!;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nTécnico modificado correctamente.");
            Console.ResetColor();

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

void EliminarTecnico()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("            ELIMINAR TÉCNICOS            ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("=========================================");
    Console.ResetColor();

    Console.Write("Ingrese ID del técnico: ");
    string buscar = Console.ReadLine()!;

    bool encontrado = false;

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].id == buscar)
        {
            for (int j = i; j < cantidadTecnicos - 1; j++)
            {
                tecnicos[j].id = tecnicos[j + 1].id;
                tecnicos[j].nombre = tecnicos[j + 1].nombre;
                tecnicos[j].especialidad = tecnicos[j + 1].especialidad;
                tecnicos[j].disponible = tecnicos[j + 1].disponible;
                tecnicos[j].casos = tecnicos[j + 1].casos;
            }

            cantidadTecnicos--;

            Console.WriteLine("\n Técnico eliminado correctamente.");

            encontrado = true;
            break;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Técnico no encontrado.");
    }

    Console.ReadKey(true);

}

//Reportes Y Estadísticas
void ReporteGeneral()
{
    Console.Clear();
    int abiertas = 0;
    int proceso = 0;
    int cerradas = 0;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Estado.ToLower() == "abierta")
            abiertas++;

        else if (incidencias[i].Estado.ToLower() == "en proceso")
            proceso++;

        else if (incidencias[i].Estado.ToLower() == "cerrada")
            cerradas++;
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== REPORTE GENERAL =====");
    Console.ResetColor();
    Console.WriteLine($"Total incidencias: {cantidad}");
    Console.WriteLine($"Abiertas: {abiertas}");
    Console.WriteLine($"En proceso: {proceso}");
    Console.WriteLine($"Cerradas: {cerradas}");

    Console.ReadKey(true);
}

void IncidenciasPorCategoria()
{
    Console.Clear();
    int hardware = 0;
    int software = 0;
    int red = 0;
    int impresoras = 0;
    int otros = 0;

    for (int i = 0; i < cantidad; i++)
    {
        switch (incidencias[i].Categoria.ToLower())
        {
            case "hardware":
                hardware++;
                break;

            case "software":
                software++;
                break;

            case "red":
                red++;
                break;

            case "impresoras":
                impresoras++;
                break;

            default:
                otros++;
                break;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== INCIDENCIAS POR CATEGORÍA =====");
    Console.ResetColor();
    Console.WriteLine($"Hardware: {hardware}");
    Console.WriteLine($"Software: {software}");
    Console.WriteLine($"Red: {red}");
    Console.WriteLine($"Impresoras: {impresoras}");
    Console.WriteLine($"Otros: {otros}");

    Console.ReadKey(true);
}

void IncidenciasPorPrioridad()
{
    Console.Clear();
    int baja = 0;
    int media = 0;
    int alta = 0;
    int critica = 0;

    for (int i = 0; i < cantidad; i++)
    {
        switch (incidencias[i].Prioridad.ToLower())
        {
            case "baja":
                baja++;
                break;

            case "media":
                media++;
                break;

            case "alta":
                alta++;
                break;

            case "critica":
                critica++;
                break;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== INCIDENCIAS POR PRIORIDAD =====");
    Console.ResetColor();
    Console.WriteLine($"Baja: {baja}");
    Console.WriteLine($"Media: {media}");
    Console.WriteLine($"Alta: {alta}");
    Console.WriteLine($"Crítica: {critica}");

    Console.ReadKey(true);
}

void IncidenciasPorEdificio()
{
    Console.Clear();

    int A = 0;
    int B = 0;
    int C = 0;
    int D = 0;
    int E = 0;
    int F = 0;
    int G = 0;
    int H = 0;
    int I = 0;
    int J = 0;
    int K = 0;
    int L = 0;
    int M = 0;
    int N = 0;
    int O = 0;
    int P = 0;

    for (int i = 0; i < cantidad; i++)
    {
        char edificio = char.ToUpper(incidencias[i].Aula[0]);

        switch (edificio)
        {
            case 'A':
                A++;
                break;

            case 'B':
                B++;
                break;

            case 'C':
                C++;
                break;

            case 'D':
                D++;
                break;
            case 'E':
                E++;
                break;
            case 'F':
                F++;
                break;
            case 'G':
                G++;
                break;
            case 'H':
                H++;
                break;
            case 'I':
                I++;
                break;
            case 'J':
                J++;
                break;
            case 'K':
                K++;
                break;
            case 'L':
                L++;
                break;
            case 'M':
                M++;
                break;
            case 'N':
                N++;
                break;
            case 'O':
                O++;
                break;
            case 'P':
                P++;
                break;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== INCIDENCIAS POR EDIFICIO =====");
    Console.ResetColor();
    Console.WriteLine($"Edificio A: {A}");
    Console.WriteLine($"Edificio B: {B}");
    Console.WriteLine($"Edificio C: {C}");
    Console.WriteLine($"Edificio D: {D}");
    Console.WriteLine($"Edificio E: {E}");
    Console.WriteLine($"Edificio F: {F}");
    Console.WriteLine($"Edificio G: {G}");
    Console.WriteLine($"Edificio H: {H}");
    Console.WriteLine($"Edificio I: {I}");
    Console.WriteLine($"Edificio J: {J}");
    Console.WriteLine($"Edificio K: {K}");
    Console.WriteLine($"Edificio L: {L}");
    Console.WriteLine($"Edificio M: {M}");
    Console.WriteLine($"Edificio N: {N}");
    Console.WriteLine($"Edificio O: {O}");
    Console.WriteLine($"Edificio P: {P}");

    Console.ReadKey(true);
}

void IncidenciasPorPiso()
{
    Console.Clear();
    int piso1 = 0;
    int piso2 = 0;
    int piso3 = 0;
    int piso4 = 0;

    for (int i = 0; i < cantidad; i++)
    {
        int piso = int.Parse(incidencias[i].Aula[1].ToString());

        switch (piso)
        {
            case 1:
                piso1++;
                break;

            case 2:
                piso2++;
                break;

            case 3:
                piso3++;
                break;
            case 4:
                piso4++;
                break;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== INCIDENCIAS POR PISO =====");
    Console.ResetColor();
    Console.WriteLine($"Piso 1: {piso1}");
    Console.WriteLine($"Piso 2: {piso2}");
    Console.WriteLine($"Piso 3: {piso3}");
    Console.WriteLine($"Piso 4: {piso4}");

    Console.ReadKey(true);
}

void TecnicoMasOcupado()
{
    Console.Clear();
    if (cantidadTecnicos == 0)
    {
        Console.WriteLine("No hay técnicos registrados.");
        Console.ReadKey(true);
        return;
    }

    int mayor = 0;

    for (int i = 1; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].casos > tecnicos[mayor].casos)
            mayor = i;
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== TÉCNICO MÁS OCUPADO =====");
    Console.ResetColor();
    Console.WriteLine($"Nombre: {tecnicos[mayor].nombre}");
    Console.WriteLine($"Casos: {tecnicos[mayor].casos}");

    Console.ReadKey(true);
}

void TecnicoMenosOcupado()
{
    Console.Clear();
    if (cantidadTecnicos == 0)
    {
        Console.WriteLine("No hay técnicos registrados.");
        Console.ReadKey(true);
        return;
    }

    int menor = 0;

    for (int i = 1; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].casos < tecnicos[menor].casos)
            menor = i;
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== TÉCNICO MENOS OCUPADO =====");
    Console.ResetColor();
    Console.WriteLine($"Nombre: {tecnicos[menor].nombre}");
    Console.WriteLine($"Casos: {tecnicos[menor].casos}");

    Console.ReadKey(true);
}

void AulaConMasReportes()
{
    Console.Clear();
    if (cantidad == 0)
    {
        Console.WriteLine("No hay incidencias.");
        Console.ReadKey(true);
        return;
    }

    string aulaMayor = "";
    int maximo = 0;

    for (int i = 0; i < cantidad; i++)
    {
        int contador = 0;

        for (int j = 0; j < cantidad; j++)
        {
            if (incidencias[i].Aula == incidencias[j].Aula)
            {
                contador++;
            }
        }

        if (contador > maximo)
        {
            maximo = contador;
            aulaMayor = incidencias[i].Aula;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== AULA CON MÁS REPORTES =====");
    Console.ResetColor();
    Console.WriteLine($"Aula: {aulaMayor}");
    Console.WriteLine($"Cantidad de incidencias: {maximo}");

    Console.ReadKey(true);
}

void HistorialMensual()
{
    Console.Clear();

    Dictionary<int, int[]> historial = new Dictionary<int, int[]>();

    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');

        if (fecha.Length == 2)
        {
            int mes = int.Parse(fecha[0]);
            int anio = int.Parse(fecha[1]);

            if (!historial.ContainsKey(anio))
            {
                historial[anio] = new int[12];
            }

            historial[anio][mes - 1]++;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== HISTORIAL MENSUAL =====");
    Console.ResetColor();

    foreach (var anio in historial.OrderBy(a => a.Key))
    {
        Console.WriteLine("\nAño " + anio.Key);

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(
                "Mes " + (i + 1) + ": " + anio.Value[i] + " incidencias");
        }
    }

    Console.ReadKey(true);
}

void ComparacionEntreMeses()
{
    Console.Clear();

    Dictionary<string, int> meses = new Dictionary<string, int>();

    for (int i = 0; i < cantidad; i++)
    {
        string fecha = incidencias[i].Fecha;

        if (meses.ContainsKey(fecha))
        {
            meses[fecha]++;
        }
        else
        {
            meses[fecha] = 1;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== COMPARACIÓN ENTRE MESES =====");
    Console.ResetColor();

    var años = meses.Keys
        .GroupBy(f => f.Split('/')[1])
        .OrderBy(g => g.Key);

    bool hayComparaciones = false;

    foreach (var año in años)
    {
        string[] listaMeses = año
            .OrderBy(f => DateTime.ParseExact(f, "MM/yyyy", null))
            .ToArray();

        if (listaMeses.Length < 2)
        {
            continue;
        }

        hayComparaciones = true;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nAño {año.Key}");
        Console.ResetColor();

        for (int i = 1; i < listaMeses.Length; i++)
        {
            int diferencia =
                meses[listaMeses[i]] -
                meses[listaMeses[i - 1]];

            Console.WriteLine(
                $"{listaMeses[i - 1]} -> {listaMeses[i]} = {diferencia} incidencias");
        }
    }

    if (!hayComparaciones)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("No hay años con suficientes meses para comparar.");
        Console.ResetColor();
    }

    Console.ReadKey(true);
}

void HistorialAnual()
{
    Console.Clear();
    Dictionary<int, int> anios = new Dictionary<int, int>();
    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');
        if (fecha.Length == 2)
        {
            int anio = int.Parse(fecha[1]);
            if (anios.ContainsKey(anio))
                anios[anio]++;
            else
                anios[anio] = 1;
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== HISTORIAL ANUAL =====");
    Console.ResetColor();
    foreach (var anio in anios.OrderBy(a => a.Key))
    {
        Console.WriteLine("Año " + anio.Key + ": " + anio.Value + " incidencias");
    }
    Console.ReadKey(true);
}

void ComparacionAnual()
{
    Console.Clear();

    Dictionary<int, int> anios = new Dictionary<int, int>();

    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');

        if (fecha.Length == 2)
        {
            int anio = int.Parse(fecha[1]);

            if (anios.ContainsKey(anio))
            {
                anios[anio]++;
            }
            else
            {
                anios[anio] = 1;
            }

        }
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("===== COMPARACIÓN ENTRE AÑOS =====");
    Console.ResetColor();

    int[] listaAnios = anios.Keys.OrderBy(a => a).ToArray();

    if (listaAnios.Length < 2)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("No hay suficientes años para comparar.");
        Console.ResetColor();
        Console.ReadKey(true);
        return;
    }

    for (int i = 1; i < listaAnios.Length; i++)
    {
        int anioAnterior = listaAnios[i - 1];
        int anioActual = listaAnios[i];

        int diferencia =
            anios[anioActual] -
            anios[anioAnterior];

        Console.WriteLine(
            "Año " + anioAnterior +
            " -> Año " + anioActual +
            " = " + diferencia + " incidencias");
    }

    Console.ReadKey(true);
}

//Guardar y Cargar Archivos
void GuardarIncidencias()
{
    StreamWriter archivo = new StreamWriter("incidencias.csv");

    archivo.WriteLine("Codigo,Reportante,TipoUsuario,Aula,Categoria,Descripcion,Fecha,Prioridad,Estado");

    for (int i = 0; i < cantidad; i++)
    {
        archivo.WriteLine(
            incidencias[i].Codigo + "," +
            incidencias[i].Reportante + "," +
            incidencias[i].TipoUsuario + "," +
            incidencias[i].Aula + "," +
            incidencias[i].Categoria + "," +
            incidencias[i].Descripcion + "," +
            incidencias[i].Fecha + "," +
            incidencias[i].Prioridad + "," +
            incidencias[i].Estado
        );
    }

    archivo.Close();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Incidencias guardadas correctamente.");
    Console.ResetColor();
}

void CargarIncidencias()
{
    if (!File.Exists("incidencias.csv"))
    {
        Console.WriteLine("No existe el archivo.");
        Console.ReadKey(true);
        return;
    }

    StreamReader archivo = new StreamReader("incidencias.csv");

    archivo.ReadLine();

    cantidad = 0;

    while (!archivo.EndOfStream)
    {
        string linea = archivo.ReadLine()!;

        string[] datos = linea.Split(',');

        incidencias[cantidad].Codigo = datos[0];
        incidencias[cantidad].Reportante = datos[1];
        incidencias[cantidad].TipoUsuario = datos[2];
        incidencias[cantidad].Aula = datos[3];
        incidencias[cantidad].Categoria = datos[4];
        incidencias[cantidad].Descripcion = datos[5];
        incidencias[cantidad].Fecha = datos[6];
        incidencias[cantidad].Prioridad = datos[7];
        incidencias[cantidad].Estado = datos[8];

        cantidad++;
    }

    archivo.Close();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Incidencias cargadas correctamente.");
    Console.ResetColor();
}

void GuardarTecnicos()
{
    StreamWriter archivo = new StreamWriter("tecnicos.csv");

    archivo.WriteLine("Id,Nombre,Especialidad,CasosAsignados,IncidenciaAsignada");

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        archivo.WriteLine(
            tecnicos[i].id + "," +
            tecnicos[i].nombre + "," +
            tecnicos[i].especialidad + "," +
            tecnicos[i].casos + "," +
            tecnicos[i].incidenciaAsignada
        );
    }

    archivo.Close();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Técnicos guardados correctamente.");
    Console.ResetColor();
    Console.ReadKey(true);
}

void CargarTecnicos()
{
    if (!File.Exists("tecnicos.csv"))
    {
        Console.WriteLine("No existe el archivo.");
        Console.ReadKey(true);
        return;
    }

    StreamReader archivo = new StreamReader("tecnicos.csv");

    archivo.ReadLine();

    cantidadTecnicos = 0;

    while (!archivo.EndOfStream)
    {
        string linea = archivo.ReadLine()!;

        string[] datos = linea.Split(',');

        tecnicos[cantidadTecnicos].id = datos[0];
        tecnicos[cantidadTecnicos].nombre = datos[1];
        tecnicos[cantidadTecnicos].especialidad = datos[2];
        tecnicos[cantidadTecnicos].casos = int.Parse(datos[3]);
        tecnicos[cantidadTecnicos].incidenciaAsignada = datos[4];

        cantidadTecnicos++;
    }

    archivo.Close();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Técnicos cargados correctamente.");
    Console.ResetColor();
    Console.ReadKey(true);
}

void Main()
{
    Console.Clear();
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
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            Console.ResetColor();
                            Console.ReadKey(true);
                            break;
                    }
                } while (opcionIncidencias != 0);
                break;
            case 2:
                int opcionTecnicos;
                do
                {
                    opcionTecnicos = MenuTecnicos();
                    switch (opcionTecnicos)
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
                            LiberarTecnico();
                            break;
                        case 5:
                            ModificarTecnico();
                            break;
                        case 6:
                            EliminarTecnico();
                            break;
                        case 0:
                            Console.WriteLine("Regresando al menú principal...");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            Console.ResetColor();
                            Console.ReadKey(true);
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
                            ReporteGeneral();
                            break;

                        case 2:
                            IncidenciasPorCategoria();
                            break;

                        case 3:
                            IncidenciasPorPrioridad();
                            break;

                        case 4:
                            IncidenciasPorEdificio();
                            break;

                        case 5:
                            IncidenciasPorPiso();
                            break;

                        case 6:
                            TecnicoMasOcupado();
                            break;

                        case 7:
                            TecnicoMenosOcupado();
                            break;

                        case 8:
                            AulaConMasReportes();
                            break;
                        case 9:
                            HistorialMensual();
                            break;
                        case 10:
                            ComparacionEntreMeses();
                            break;
                        case 11:
                            HistorialAnual();
                            break;
                        case 12:
                            ComparacionAnual();
                            break;
                        case 0:
                            Console.WriteLine("Regresando al menú principal...");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            Console.ResetColor();
                            Console.ReadKey(true);
                            break;
                    }

                } while (opcionReportes != 0);
                break;
            case 4:
                GuardarIncidencias();
                GuardarTecnicos();
                break;
            case 5:
                CargarIncidencias();
                CargarTecnicos();
                break;
            case 0:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Saliendo del sistema...");
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                Console.ResetColor();
                Console.ReadKey(true);
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
    public string id;
    public string nombre;
    public string especialidad;
    public bool disponible;
    public int casos;
    public string incidenciaAsignada;
}