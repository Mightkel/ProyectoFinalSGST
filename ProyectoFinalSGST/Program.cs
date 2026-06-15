Incidencia[] incidencias = new Incidencia[100];
int cantidad = 0;

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
    Console.WriteLine("0. Regresar");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    return int.Parse(Console.ReadLine()!);
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
                } while (opcionIncidencias != 0);
                break;
            case 2:
                int opcionTecnicos;
                do
                {
                    opcionTecnicos = MenuTecnicos();
                } while (opcionTecnicos != 0);
                break;
            case 3:
                int opcionReportes;
                do
                {
                    opcionReportes = MenuReportes();
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