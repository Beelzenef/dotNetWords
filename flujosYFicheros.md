# Flujos y ficheros

Un fichero es una zona de memoria que contiene información no volátil en el disco duro, generalmente con un nombre y una extensión que le da formato.

Hay pocas pero algunas limitaciones asociadas al sistema operativo en el cual se produce la gestión de ficheros, pero basta con conocer el entorno en el que nos novemos.

Debido a la gran cantidad de operaciones que se pueden realizar con ficheros, directorios y flujos... C# tiene un espacio de nombre propio para ellos, que debemos invocar para tratar con las Clases apropiadas.

```cs
using System.IO;
```

## Herencia
### Clases complementarias

#### Path

Es una clase estática, y por tanto con miembros estáticos, que basa en instancias de strings para representar rutas a ficheros o directorios.

Esta Clase NO trabaja con ficheros, solo establece rutas en el sistema de ficheros del sistema operativo. Y dependiendo de con cual trabajes, tiene algunos miembros para adaptar el código al sistema operativo. También es importante recordar que las rutas a ficheros o directorios dentro de strings pueden tener carácteres interpretables que podrían hacer fallar la gestión de directorios concretos... es por ello que podemos manifestar que un string no sea interpretado, que solo sea un literal de texto. ¿Cómo? Con esta pequeña modificación:

String normal:
```cs
string ruta1 = "dir2/dir3/dir4";
```

String literal:
```cs
string literal = @"/dir1/dir2";
```

Propiedades:

DirectorySeparatorChar, que obtiene y aplica el separador del directorio, sea cual sea el sistema operativo, a un string para construir una ruta.

```cs
string ruta;
char separadorRutas = Path.DirectorySeparatorChar;
ruta = separador + "datos" + separador + "ficherito.dat";
```
PathSeparator, un caracter que separa rutas entre ellas, por lo general el semicolon ';'.

VolumeSeparatorChar, que es el separador de unidades lógicas, que dependerá de la raíz del sistema operativo.

## Clases para ficheros
## Clases para directorios
## Flujos
