int MainMenu()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("=== SISTEMA DE SOPORTE TECNOLOGIA UAM ===");
    Console.ResetColor();
    Console.WriteLine("1. Gestión de incidencias");
    Console.WriteLine("2. Gestión de Técnicos");
    Console.WriteLine("3. Reportes y estadísticas");
    Console.WriteLine("4. Guardar información");
    Console.WriteLine("5. Cargar información");
    Console.WriteLine("0. Salir");
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
    Console.WriteLine("1. Incidencias por categoria");
    Console.WriteLine("1. Incidencias por prioridad");
    Console.WriteLine("1. Incidencias por edificio");
    Console.WriteLine("1. Incidencias por piso");
    Console.WriteLine("1. Técnico mas ocupado");
    Console.WriteLine("1. Técnico menos ocupado");
    Console.WriteLine("1. Aula con mas reportes");
    Console.WriteLine("0. Regresar");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Digite su opción: ");
    Console.ResetColor();
    return int.Parse(Console.ReadLine()!);
}

 