
# Sistema de Gestión de Biblioteca

## 1. Descripción del proyecto

Sistema de gestión de biblioteca desarrollado como proyecto final de la asignatura Programación Avanzada. La aplicación permite al 100% administrar libros, autores, editoriales y usuarios, gestionar préstamos y devoluciones, asi mismo permite ingresar nuevos usuarios, editar datos, eliminarlos y generar reportes mediante una interfaz gráfica conectada a SQL Server.

## 2. Tecnologías utilizadas
En mi trabajo se realizo uso de las herramientas, tal como lo solicito nuestra profesora. 

- **Lenguaje:** C#
- **Entorno de desarrollo:** Visual Studio
- **Interfaz gráfica:** Windows Forms
- **Base de datos:** Microsoft SQL Server 2022
- **Conexión a base de datos:** Microsoft.Data.SqlClient
- **Control de versiones:** Git y GitHub

## 3. Funcionalidades principales

El sistema cuenta con los siguientes módulos:

- **Inicio:** navegación principal de la aplicación. 6 modulos totalmente funcionales y navegables. 
- **Libros:** registro, consulta, actualización y eliminación de libros.
- **Autores:** administración de autores.
- **Editoriales:** administración de editoriales.
- **Usuarios:** registro y administración de usuarios.
- **Préstamos:** gestión y consulta de préstamos.
- **Devoluciones:** registro de devolución y actualización del estado del préstamo.
- **Reportes:** generación de consultas e informes sobre la información almacenada.

## 4. Arquitectura del proyecto

El proyecto está organizado en las siguientes carpetas por capas : 

- `Presentacion`: formularios e interfaz gráfica.
- `Negocio`: lógica y validaciones del sistema.
- `Datos`: conexión y operaciones con SQL Server.
- `Properties`: propiedades y configuración del proyecto.

## 5. Base de datos

El sistema utiliza una base de datos SQL Server denominada `appbiblioteca`.

Tablas principales:

- Editoriales
- Autores
- Libros
- LibroAutor
- Usuarios
- Prestamos

La base de datos hace uso de claves primarias, claves foráneas y restricciones para mantener la integridad de la información.

## 6. Requisitos para ejecutar el proyecto

- Windows.
- Visual Studio con el componente de desarrollo de escritorio .NET.
- SQL Server 2022 o compatible.
- Base de datos `appbiblioteca` creada y configurada.

## 7. Configuración de conexión

La aplicación utiliza autenticación de Windows para conectarse a SQL Server.

Cadena de conexión utilizada:

`Server=localhost;Database=appbiblioteca;Trusted_Connection=True;TrustServerCertificate=True;`

Si SQL Server está instalado en otra instancia o equipo, será necesario ajustar la cadena de conexión.

## 8. Ejecución

1. Instalar los requisitos indicados.
2. Crear la base de datos `appbiblioteca` utilizando el script SQL incluido en el repositorio.
3. Abrir `BibliotecaApp.slnx` desde Visual Studio.
4. Verificar la cadena de conexión.
5. Compilar y ejecutar la aplicación.

## 9. Autor

**Johan Santiago Peña Garcia**

Estudiante de Ingeniería de Sistemas.

Corporación Unificada Nacional de Educación Superior (CUN).

Asignatura: Programación Avanzada.

Proyecto académico: Sistema de Gestión de Biblioteca.

numero de ficha 54465 

Docente Veronica Castro 