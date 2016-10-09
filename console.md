# Console (using System;)

La Clase Console es una Clase con todos sus miembros (propiedades y métodos) estáticos. Solo necesitas saber el nombre de la Clase para empezar a trabajar con ella. También necesitaremos el espacio de nombre System para poder invocarla, escrito en la primera sección del fichero CS.
La documentación de Microsoft es muchas veces tu aliada, las descripciones y explicaciones son geniales aunque a veces los ejemplos son demasiado complicados. Para lo que estamos, viene genial. Así que dejo el enlace:

[Console (MSDN)](https://msdn.microsoft.com/es-es/library/system.console(v=vs.110).aspx)

### Escribiendo en consola

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

### Posicionando un cursor

La consola es un sistema de entrada y salida en el sistema, más personalizable de lo que cabe esperar de la monócroma pantalla. Es posible.

En concreto, podemos decidir la posición en la que el cursor se posiciona, para que no todas las líneas se ajusten en el borde izquierdo, en la posición más alta posible. La consola es una cuadrícula, con coordenadas desde el borde superior y el izquierdo, que podemos seleccionar a nuestro antojo. En concreto, sus medidas son de 80 columnas por 24 filas, empezando desde 0.

¿Cómo se juega con las posiciones? Tenemos dos alternativas, mediante propiedades y métodos.

Mediante propiedades, podemos establecer y leer los dos valores de columnas y filas de forma separada, en forma de integers.

```cs
Console.CursorLeft = 10;
Console.CursorTop = 5;
```

Mediante método, podemos invocar el método estático que devuelve void que establece una posición concreta de filas y columnas:

```cs
Console.SetCursorPosition(10, 5);
```

### La vida está llena de color

La consola es, por lo general, monocroma. Blanco sobre negro de forma habitual cuando invocamos la CMD. Y aunque a veces se pueda configurar, no estamos limitados a la configuración que el usuario determine por defecto en su sistema.

Existe en la Clase Console unas propiedades que establecen el color de fondo y el color de letra en la consola. Son dos propiedades que reciben valores de la enumeración ConsoleColor. ¿Qué es una enumeración? Puedes consultarlo [en este enlace](enum.md).

Y la puesta en práctica:

```cs
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
```

Estas propiedades cambiadas establecen que lo siguiente que se escriba, detrás de estas líneas, tendrán el fondo azul y la letra de color negro. ¿Cómo hacer entonces para que se establezca desde el principio?

Podemos entonces invocar el método estático de la consola que limpia de todo contenido su interior, estableciendo estos colores desde el inicio de su uso.

```cs
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
```

### En conclusión

Las opciones, combinadas, permiten una combinación que les dará variedad a nuestras aplicaciones de consola.
