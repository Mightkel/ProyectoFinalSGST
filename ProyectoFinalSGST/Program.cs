using System.IO;

Incidencia[] incidencias = new Incidencia[100];
int cantidad = 0;

Tecnico[] tecnicos = new Tecnico[50];
int cantidadTecnicos = 0;

int MainMenu()
{
    Console.Clear();
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
    try
    {
        return int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
        return -1;
    }
}

// GESTION DE INCIDENCIAS
void CodigoIncidencia()
{
    string codigo;
    bool repetido;

    do
    {
        repetido = false;

        Console.Write("Código de incidencia: ");
        codigo = Console.ReadLine()!;

        for (int i = 0; i < cantidad; i++)
        {
            if (incidencias[i].Codigo.ToUpper() == codigo.ToUpper())
            {
                repetido = true;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: El código ya existe.");
                Console.ResetColor();

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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
        return -1;
    }
}

string LeerFecha()
{
    string fecha;

    do
    {
        Console.Write("Fecha (dd/MM/yyyy): ");
        fecha = Console.ReadLine()!;

        if (DateTime.TryParseExact(
            fecha,
            "dd/MM/yyyy",
            null,
            System.Globalization.DateTimeStyles.None,
            out _))
        {
            return fecha;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Fecha inválida. Use el formato dd/MM/yyyy.");
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        Console.ResetColor();
        Console.ReadKey();
        return -1;
    }
}
void RegistrarIncidencia()
{
    Console.Clear();

    CodigoIncidencia();

    Console.Write("Nombre del reportante: ");
    incidencias[cantidad].Reportante = Console.ReadLine()!;

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
            Console.WriteLine("Opción no válida. Se asignará 'Otro' por defecto.");
            incidencias[cantidad].TipoUsuario = "Otro";
            Console.ReadKey();
            break;
    }

    while (true)
    {
        int aulaResultado = AulaIncidencia();
        if (aulaResultado == 1)
        {
            break;
        }
    }

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
            Console.WriteLine("Opción no válida. Se asignará 'Otro' por defecto.");
            incidencias[cantidad].Categoria = "Otro";
            Console.ReadKey();
            break;
    }

    Console.Write("Descripcion: ");
    incidencias[cantidad].Descripcion = Console.ReadLine()!;

    incidencias[cantidad].Fecha = LeerFecha();

    switch(PrioridadIncidencia())
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
            Console.WriteLine("Opción no válida. Se asignará 'Baja' por defecto.");
            incidencias[cantidad].Prioridad = "Baja";
            Console.ReadKey();
            break;
    }


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
            Console.WriteLine("Opción no válida. Se asignará 'Abierta' por defecto.");
            incidencias[cantidad].Estado = "Abierta";
            Console.ReadKey();
            break;
    }
 
    cantidad++;

    Console.ForegroundColor= ConsoleColor.DarkGreen;
    Console.WriteLine("\nIncidencia registrada correctamente.");
    Console.ResetColor();
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

    Console.ReadKey();
    Console.WriteLine();
}

void ModificarIncidencia()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Codigo a modificar: ");
    string buscar = Console.ReadLine()!;
    Console.ResetColor();

    bool encontrado = false;

    for (int i = 0; i < cantidad; i++)
    {
        if (incidencias[i].Codigo == buscar)
        {
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
                    Console.WriteLine("Opción no válida. Se asignará 'Abierta' por defecto.");
                    incidencias[cantidad].Estado = "Abierta";
                    Console.ReadKey();
                    break;
            }

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
                    Console.WriteLine("Opción no válida. Se asignará 'Baja' por defecto.");
                    incidencias[cantidad].Prioridad = "Baja";
                    Console.ReadKey();
                    break;
            }

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

void LiberarTecnico()
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

    Console.WriteLine("===== REPORTE GENERAL =====");
    Console.WriteLine($"Total incidencias: {cantidad}");
    Console.WriteLine($"Abiertas: {abiertas}");
    Console.WriteLine($"En proceso: {proceso}");
    Console.WriteLine($"Cerradas: {cerradas}");

    Console.ReadKey();
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

    Console.WriteLine("===== INCIDENCIAS POR CATEGORÍA =====");
    Console.WriteLine($"Hardware: {hardware}");
    Console.WriteLine($"Software: {software}");
    Console.WriteLine($"Red: {red}");
    Console.WriteLine($"Impresoras: {impresoras}");
    Console.WriteLine($"Otros: {otros}");

    Console.ReadKey();
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

    Console.WriteLine("===== INCIDENCIAS POR PRIORIDAD =====");
    Console.WriteLine($"Baja: {baja}");
    Console.WriteLine($"Media: {media}");
    Console.WriteLine($"Alta: {alta}");
    Console.WriteLine($"Crítica: {critica}");

    Console.ReadKey();
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

    Console.WriteLine("===== INCIDENCIAS POR EDIFICIO =====");
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

    Console.ReadKey();
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

    Console.WriteLine("===== INCIDENCIAS POR PISO =====");
    Console.WriteLine($"Piso 1: {piso1}");
    Console.WriteLine($"Piso 2: {piso2}");
    Console.WriteLine($"Piso 3: {piso3}");
    Console.WriteLine($"Piso 4: {piso4}");

    Console.ReadKey();
}

void TecnicoMasOcupado()
{
    Console.Clear();
    if (cantidadTecnicos == 0)
    {
        Console.WriteLine("No hay técnicos registrados.");
        Console.ReadKey();
        return;
    }

    int mayor = 0;

    for (int i = 1; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].casos > tecnicos[mayor].casos)
            mayor = i;
    }

    Console.WriteLine("===== TÉCNICO MÁS OCUPADO =====");
    Console.WriteLine($"Nombre: {tecnicos[mayor].nombre}");
    Console.WriteLine($"Casos: {tecnicos[mayor].casos}");

    Console.ReadKey();
}

void TecnicoMenosOcupado()
{
    Console.Clear();
    if (cantidadTecnicos == 0)
    {
        Console.WriteLine("No hay técnicos registrados.");
        Console.ReadKey();
        return;
    }

    int menor = 0;

    for (int i = 1; i < cantidadTecnicos; i++)
    {
        if (tecnicos[i].casos < tecnicos[menor].casos)
            menor = i;
    }

    Console.WriteLine("===== TÉCNICO MENOS OCUPADO =====");
    Console.WriteLine($"Nombre: {tecnicos[menor].nombre}");
    Console.WriteLine($"Casos: {tecnicos[menor].casos}");

    Console.ReadKey();
}

void AulaConMasReportes()
{
    Console.Clear();
    if (cantidad == 0)
    {
        Console.WriteLine("No hay incidencias.");
        Console.ReadKey();
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
                contador++;
        }

        if (contador > maximo)
        {
            maximo = contador;
            aulaMayor = incidencias[i].Aula;
        }
    }

    Console.WriteLine("===== AULA CON MÁS REPORTES =====");
    Console.WriteLine($"Aula: {aulaMayor}");
    Console.WriteLine($"Cantidad de incidencias: {maximo}");

    Console.ReadKey();
}

void HistorialMensual()
{
    Console.Clear();

    int[] meses = new int[12];
    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');

        if (fecha.Length == 3)
        {
            int mes = int.Parse(fecha[1]);
            meses[mes - 1]++;
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("===== HISTORIAL MENSUAL =====");
    Console.ResetColor();
    
    for (int i = 0; i < 12; i++)
    {
        Console.WriteLine("Mes " + (i + 1) + ": " + meses[i] + " incidencias");
    }

    Console.ReadKey();
}

void ComparacionEntreMeses()
{
    Console.Clear();

    int[] meses = new int[12];
    for (int i = 0; i < cantidad; i++)
    {
        string[] fecha = incidencias[i].Fecha.Split('/');
        if (fecha.Length == 3)
        {
            int mes = int.Parse(fecha[1]);
            meses[mes - 1]++;
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("===== COMPARACIÓN ENTRE MESES =====");
    Console.ResetColor();

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

    Console.WriteLine("Incidencias guardadas correctamente.");
}

void CargarIncidencias()
{
    if (!File.Exists("incidencias.csv"))
    {
        Console.WriteLine("No existe el archivo.");
        Console.ReadKey();
        return;
    }

    StreamReader archivo = new StreamReader("incidencias.csv");

    archivo.ReadLine(); // Salta encabezado

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

    Console.WriteLine("Incidencias cargadas correctamente.");
}

void GuardarTecnicos()
{
    StreamWriter archivo = new StreamWriter("tecnicos.csv");

    archivo.WriteLine("Id,Nombre,Especialidad,CasosAsignados");

    for (int i = 0; i < cantidadTecnicos; i++)
    {
        archivo.WriteLine(
            tecnicos[i].id + "," +
            tecnicos[i].nombre + "," +
            tecnicos[i].especialidad + "," +
            tecnicos[i].casos
        );
    }

    archivo.Close();

    Console.WriteLine("Técnicos guardados correctamente.");
    Console.ReadKey();
}

void CargarTecnicos()
{
    if (!File.Exists("tecnicos.csv"))
    {
        Console.WriteLine("No existe el archivo.");
        Console.ReadKey();
        return;
    }

    StreamReader archivo = new StreamReader("tecnicos.csv");

    archivo.ReadLine();

    cantidadTecnicos = 0;

    while (!archivo.EndOfStream)
    {
        string linea = archivo.ReadLine()!;

        string[] datos = linea.Split(',');

        tecnicos[cantidadTecnicos].id = int.Parse(datos[0]);
        tecnicos[cantidadTecnicos].nombre = datos[1];
        tecnicos[cantidadTecnicos].especialidad = datos[2];
        tecnicos[cantidadTecnicos].casos = int.Parse(datos[3]);

        cantidadTecnicos++;
    }

    archivo.Close();

    Console.WriteLine("Técnicos cargados correctamente.");
    Console.ReadKey();
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
                            LiberarTecnico();
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
                        case 0:
                            Console.WriteLine("Regresando al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
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