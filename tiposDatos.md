# Tipos de datos

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
