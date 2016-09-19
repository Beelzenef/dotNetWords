# Tipos de datos

No todos los datos con los que vamos a trabajar en nuestras aplicaciones son iguales. No lo son porque el trato que reciben no va a ser el mismo. Tanto en Java como en C# y otros lenguajes de programación, estos datos son definidos estrictamente. ¿Qué quiere decir? Que una variable de un tipo determinado siempre será de ese tipo determinado.

¿Un ejemplo? Los números enteros:

```Java
int edad = 22;
```

Esa variable llamada "edad" y de valor 22 ahora puede ser tratada como un número entero.

En cambio, si declaramos otra variable, de texto o *string* como son conocidas, encontraremos algo parecido:

```Java
String nombre = "Elena";
```

Como un dato de tipo texto o *string*, no tiene sentido que hagamos un tratamiento como número entero, ¿no es cierto? Como por ejemplo, nunca multiplicarías un nombre, esa operación no tiene sentido en inicio. Esas limitaciones se hacen por seguridad y nos darán pistas sobre qué operaciones podemos hacer con esos datos con respecto a sus tipos.

Y aquí una lista de los tipos existentes, que se irán conociendo a lo largo del aprendizaje.

Datos por valor:

* Enteros
  - Byte (byte)
  - Sbyte (sbyte)
  - Short (short)
  - Ushort (ushort)
  - Integer (int)
  - Uinteger (uint)
  - Long (long)
* Char (char)
* Reales
* Flotantes (float)
* Dobles (double)
* Booleanos (bool)
* Enumeraciones (enum)
* Estructuras (struct)

Tipos por referencia:

* Cadenas de texto (string)
* Arrays (array)
* Clases
* Interfaces
* Punteros
* Null

Los tipos de datos por valor, trabajan con copias de esos datos.
Los tipos de datos por referencia, mantiene los cambios por métodos.

O mejor, para una [referencia visual](https://twitter.com/FrancescoC/status/738490412441145344/photo/1). 

Los datos por valor, al ser pasados a métodos, se utilizan copias de esos datos.
Los datos por referencia es como coger ese mismo dato para modificarlo, estás referenciando al dato para operar sobre él.

En C# tenemos un tipado fuerte y estático. Esto se traduce como que las variable, una vez declaradas, no pueden cambiar de tipo, además de que han de ser declaradas con un tipo desde el inicio. De lo contrario, no compilará.

Por ejemplo, declarando una cadena de texto:

```CS
string nombre = “Elena”;
```

Esta variable, nombre, siempre será un string y siempre será tratado como un string.

```CS
int edad = 22;
char = ‘X’;
```
