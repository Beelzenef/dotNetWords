# EntityFramework

Operando con datos desde bases de datos

Crear un proyecto desde terminal...

`> dotnet new mvc --auth Individual -o NombreProyecto`

... pone a nuestro alcance muchas herramientas de gestión de base de datos. Con la creación, ya tenemos una base de datos, `app.db`, y también instalado [EntityFramework Core](https://docs.microsoft.com/es-es/ef/core/index). También hay una Clase que hará de contexto para nuestra base de datos, `ApplicationDbContext.cs`, y la configuración para acceder a la misma en `appsettings.json`.

En la Clase de contexto es donde escribiremos el código que nos permitirá acceder a las tablas.

# Más que leer

[Code first migrations in team environements](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/teams). Si vas a leer esto, prepárate un café porque es largo (recomendación de Microsoft).

---

## [Volver a inicio](../README.md)

## ← [Inicio ASP.NET Core](intro.md)
