# OBTENER UN ENTERO

El método ReadLine() de Console toma lo que se escriba desde teclado hasta pulsar ENTER. Como devuelve un string, podemos almacenar ese contenido hasta pulsar ENTER en una variable de tipo string para mostrarla, operar con ella…
Pero no es el único tipo de dato que podemos obtener.

¿Qué pasa cuando queremos obtener un integer, un número? Vamos a usar el método ReadLine(), pero ¿no devuelve una cadena? ¿Cómo convertirlo para tomar un dato?
Tenemos que convertir esa cadena de texto que tomamos con el método en un int, en un double… o cualquier otro tipo que nos interese. ¿Cómo hacerlo?

```CS
int num;
num = int.Parse(Console.ReadLine());
```

En estas dos líneas hemos declarado una variable entera y después va a almacenar lo que se tome por ReadLine() y después convertido (Parse) a entero (int.).
Si lo que hemos escrito es un entero, es un “2”, será convertido sin problema a 2, un valor entero.

Pero… ¿y si no es un entero? ¿Y si intentamos convertir a entero el string recibido que contiene “CSharp como mola se merece una ola”?
Si lo intentas, sucederá que el programa fallará hasta el punto de que este se cierre y se te notificará que se ha lanzado una excepción no controlada (en cuyo caso, necesitarás detener el programa usando el botón STOP situado en el lugar donde debería aparecer el botón de RUN antes de ejecutar):

![getInt](http://i.stack.imgur.com/HLU2J.png)

## Excepciones

Una excepción es un error que el programa no puede gestionar, elevandolo hasta… que alguien lo trate, lo controle. Como nadie lo ha controlado, el programa se cierra, peta, y notifica que no se ha podido convertir esa cadena a un entero.

¿Cómo hacemos que no explote el programa? Vamos a introducirnos ligeramente en el tratamiento de excepciones para evitar estas situaciones tan repentinas y molestas.

Los bloques TRY-CATCH son los que nos ayudarán a controlar esos errores y que las excepciones sean tratadas.

Tenemos, en inicio, dos zonas diferenciadas. La zona TRY es la que almacena el código susceptible a errores, sensible a excepciones. Si se encuentra ahí, la excepción posible podrá comenzar a ser tratada.
Pero necesita de la segunda parte, la zona CATCH. Este bloque es la que almacena el código que se ejecutará cuando se produzca una excepción. Puede estar vacío, siendo un CATCH mudo para que no de problemas (no recomendado), pero el programa no se detendrá como acostumbraba a hacer cuando no conocíamos estos bloques.

```CS
try {
num = int.Parse(Console.ReadLine());
}
catch {
Console.WriteLine(“Se ha producido un error al convertir”);
}
```

El programa continuará con las instrucciones que queden o volverá al estado inicial si es que está en un bucle que hayamos codificado.
Advertencia: las excepciones no controladas no están permitidas, son la situación a evitar a toda costa dentro de lo posible, por eso las tratamos tan pronto. Probando y testeando encontraremos zonas susceptibles a excepciones y las controlaremos.
