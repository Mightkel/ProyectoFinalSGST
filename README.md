# ProyectoFinalSGST
# SGST-UAM - Sistema de Gestión de Soporte Tecnológico

## Descripción

SGST-UAM (Sistema de Gestión de Soporte Tecnológico) es una aplicación de consola desarrollada en C# para administrar incidencias tecnológicas dentro de la Universidad Americana (UAM).

El sistema permite registrar, consultar, modificar y eliminar incidencias reportadas por estudiantes, docentes y personal administrativo. Además, incorpora la gestión de técnicos, 
asignación de casos, generación de reportes estadísticos y almacenamiento de información mediante archivos CSV.

Este proyecto fue desarrollado como Proyecto Final de la asignatura **Introducción a la Programación**, aplicando los principales conceptos vistos durante el curso, tales como 
estructuras, arreglos, matrices, funciones, validaciones, manejo de archivos y modularización del código.

---

## Objetivos

* Gestionar incidencias tecnológicas de forma eficiente.
* Administrar técnicos y asignar casos según su especialidad.
* Generar reportes y estadísticas sobre las incidencias registradas.
* Mantener la información almacenada mediante archivos CSV.
* Aplicar buenas prácticas de programación estructurada en C#.

---

## Funcionalidades

### Gestión de Incidencias

* Registrar incidencias.
* Buscar incidencias por código.
* Modificar incidencias.
* Eliminar incidencias.
* Mostrar incidencias registradas.
* Validación de códigos únicos.

### Gestión de Técnicos

* Registrar técnicos.
* Mostrar técnicos.
* Asignar técnicos.
* Liberar técnicos.
* Modificar técnicos.
* Eliminar técnicos.

### Reportes y Estadísticas

* Reporte general de incidencias.
* Incidencias por categoría.
* Incidencias por prioridad.
* Incidencias por edificio.
* Incidencias por piso.
* Aula con mayor cantidad de reportes.
* Técnico más ocupado.
* Técnico menos ocupado.
* Historial mensual.
* Comparacion mensual.
* Historial anual.
* Comparacion anual.

### Persistencia de Datos

* Guardar información en archivos CSV.
* Cargar información desde archivos CSV.
* Conservación de datos entre ejecuciones del programa.
* 
---

## Instalación y Ejecución

### Requisitos

Para ejecutar correctamente el proyecto se necesita:

* Visual Studio 2022 o superior.
* .NET SDK compatible con la versión utilizada en el proyecto.
* Git (opcional, en caso de clonar el repositorio).

### Instalación

1. Clonar el repositorio utilizando Git:

```bash
git clone https://github.com/Mightkel/ProyectoFinalSGST.git
```

2. Abrir el proyecto en Visual Studio.
3. Verificar que los archivos .csv estén correctamente instaladas.

```text
Datos/
├── incidencias.csv
└── tecnicos.csv
```

---

### Ejecución

Abrir el proyecto en Visual Studio.
Seleccionar el proyecto principal como proyecto de inicio.
Ejecutar la aplicación utilizando el botón Iniciar o presionando la tecla F5.

---


## Tecnologías Utilizadas

* Lenguaje: C#
* Paradigma: Programación estructurada
* Entorno de desarrollo: Visual Studio
* Almacenamiento: Archivos CSV
* Control de versiones: Git y GitHub

---

## Estructura General del Proyecto

```text
ProyectoFinalSGST/
│
├── Program.cs
├── Datos/
│   ├── incidencias.csv
│   └── tecnicos.csv
│
├── Modulos/
│   ├── Incidencias
│   ├── Tecnicos
│   ├── Reportes
│   └── Archivos
│
└── README.md
```

---

## Integrantes y Contribuciones

### Maykel Josué Cruz Zamora

* Líder del equipo.
* Desarrollo de la estructura base del proyecto.
* Desarrollo de los módulos de Reportes y Estadísticas.
* Implementación de validaciones generales.
* Integración y coordinación de los módulos.

### Shane Alejandro Rodríguez Vega

* Desarrollo completo del módulo de Gestión de Técnicos.
* Implementación de funciones de asignación y reasignación.
* Participación en la integración y pruebas del sistema.

### Gabriel Martín Núñez Orozco

* Desarrollo completo del módulo de Gestión de Incidencias.
* Implementación de operaciones CRUD para incidencias.
* Participación en la integración y validación de funcionalidades.

---

## Aprendizajes Obtenidos

Durante el desarrollo de este proyecto se aplicaron conceptos fundamentales de programación, entre ellos:

* Uso de estructuras (`struct`).
* Manejo de arreglos y matrices.
* Modularización mediante funciones.
* Validación de datos.
* Lectura y escritura de archivos.
* Control de versiones con Git y GitHub.
* Trabajo colaborativo en equipo.

---

## Estado del Proyecto

Proyecto académico desarrollado para la asignatura **Introducción a la Programación** de la Universidad Americana (UAM).