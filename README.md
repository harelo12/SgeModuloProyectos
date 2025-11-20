# SgeModuloProyectos

## Descripción
SgeModuloProyectos es un módulo para gestionar proyectos y tareas, pensado para organizar y administrar proyectos de forma eficiente.

## Clonación del Repositorio
Clona el repositorio con el comando:

```bash
git clone https://github.com/harelo12/SgeModuloProyectos
````

## Configuración de la Base de Datos

1. Ejecuta el archivo `db.sql` que está en la raíz del proyecto para crear la base de datos.
2. Ve a la carpeta `Project/ProjectManagement.Core/`.
3. Crea un archivo `.env` y añade la variable con tu cadena de conexión:

```env
CONN_STRING=tu_cadena_de_conexion_aqui
```

## Ejecución del Proyecto

Con la base de datos y el `.env` configurados, ejecuta el proyecto desde Visual Studio. Asegúrate de tener todas las dependencias instaladas.

## Requisitos

* .NET Framework 4.7.2 o superior.
* SQL Server (o la base de datos que uses en `CONN_STRING`).
