# Console (using System;)

La Clase Console es una Clase con todos sus miembros (propiedades y métodos) estáticos. Solo necesitas saber el nombre de la Clase para empezar a trabajar con ella. También necesitaremos el espacio de nombre System para poder invocarla, escrito en la primera sección del fichero CS.
La documentación de Microsoft es muchas veces tu aliada, las descripciones y explicaciones son geniales aunque a veces los ejemplos son demasiado complicados. Para lo que estamos, viene genial. Así que dejo el enlace:

[Console (MSDN)](https://msdn.microsoft.com/es-es/library/system.console(v=vs.110).aspx)

¿Cómo lanzar un mensaje por pantalla? Invocando al método WriteLine().

WriteLine() es un método que devuelve nada (void, por lo que no tiene return), es estático y puede recibir como parámetro una cadena de texto. Esta cadena de texto será nuestro mensaje por pantalla.

En tu programa, puedes empezar a escribir:

```cs
Console.WriteLine(“hey there”);
```

Cuando pulsas F5, se ejecutará pero ¡oh! Es apenas un flash. ¿Por qué? Porque la consola de Windows, a diferencia de la de GNULinux, necesita de un método para esperar un ENTER después de haber ejecutado cierto código.
Este método es ReadLine()

ReadLine() es un método estático que devuelve un string (cuyo uso veremos a la hora de tomar datos) y no recibe parámetros. Espera a que introduzcas un ENTER por teclado. Entonces:

```cs
Console.WriteLine(“hey there”);
Console.ReadLine();
```

Existe otro método, llamado Write(), que funciona de forma similar a WriteLine(), pero que a diferencia del anterior este no hace salto de línea, no “escribe línea” como deja ver su nombre. Devuelve void, es estático y puede recibir una cadena de texto como parámetro.

```cs
Console.WriteLine(“Escribiendo con salto de línea”);
Console.Write(“Escribiendo sin salto de línea”);
Console.ReadLine();
```

Y ahora podemos empezar a escribir líneas y líneas de código.
