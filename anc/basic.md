# Conocimientos básicos de ASP.NET Core

Una aplicación ASP.NET Core es una aplicación de consola que crea un servidor web al ejecutar su método `Main`.

Los controladores manejan acciones, elementos que formarán URLs que nos facilitarán la navegación por la aplicación web.

Las vistas se basan en ficheros `*.cshtml`, que combinan código C# con marcado en HTML.

* Raíz web

Directorio donde se almacenan los recursos públicos y estáticos (imágenes, CSS, Javascript...). Es un directorio de la solución llamado `wwwroot`, con el icono de globo, donde todo el contenido está organizado ya por carpetas. También es conocido como _webroot_.

* Raíz del contenido

Directorio o ruta de acceso a contenido de la aplicación, como sus Razor Pages, recursos estáticos o vistas del MVC. Es la misma ubicación que el archivo ejecutable.

* Clase Program

Program.cs es la Clase donde se define el _webhost_. También se define cuál será la Clase a utilizar como _startup_, como punto de arranque.

```cs
UseStartup<Startup>();
```

* Clase Startup

La Clase Startup es donde se definen los servicios a utilizar por la aplicación así como el _middleware_. 

El constructor recibe una instancia de `IConfiguration`. Interactuará con las fuentes de configuración, sustituye a _webconfig_ de forma opcional.

El método `Configure()` es el que determina la configuración del _middleware_, el modo en que ASP.NET responde ante las peticiones HTTP. Aquí se determina cómo la aplicación responde ante errores, excepciones, también que la aplicación usa MCV, incluso el mapa de rutas

* EntityFramework

Es un ORM que facilita a _developers_ el manejo y acceso a bases de datos en sus aplicaciones en .NET.

[Información sobre EntityFramework en Microsoft.com](https://docs.microsoft.com/es-es/dotnet/framework/data/adonet/ef/overview)

* `appsetings.json`

Es un fichero con pares de clave-valor para la configuración del servidor. Es ahí donde se encuentra, por ejemplo, la cadena de conexión a la base de datos.

* Servicios

Código reutilizable, preparando código como inyección de dependencias. Se declaran `interface`s que implementan las Clases que funcionarán como servicios, y estas `interface`s serán las que reciban los constructores de las Clases que usen esos serivicios.

Ejemplo de servicio: Clase Repositorio, que accedería a la base de datos, abstrayendo esa lógica para usar desde cualquier Clase de la aplicación.

En la Clase `Startup`, para declarar un servicio, será en C#:

```cs
services.AddScoped<IServicio, ClaseServicio>();
```

---
#### [Volver a inicio](../README.md)
#### ← [Inicio ASP.NET Core](intro.md)