void ReporteGeneral()
{
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
    int piso1 = 0;
    int piso2 = 0;
    int piso3 = 0;

    for (int i = 0; i < cantidad; i++)
    {
        int piso = int.Parse(incidencias[i].Aula[2].ToString());

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
        }
    }

    Console.WriteLine("===== INCIDENCIAS POR PISO =====");
    Console.WriteLine($"Piso 1: {piso1}");
    Console.WriteLine($"Piso 2: {piso2}");
    Console.WriteLine($"Piso 3: {piso3}");

    Console.ReadKey();
}

void TecnicoMasOcupado()
{
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