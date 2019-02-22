# Flujos y ficheros

Un fichero es una zona de memoria que contiene información no volátil en el disco duro, generalmente con un nombre y una extensión que le da formato.

Hay pocas pero algunas limitaciones asociadas al sistema operativo en el cual se produce la gestión de ficheros, pero basta con conocer el entorno en el que nos novemos.

Debido a la gran cantidad de operaciones que se pueden realizar con ficheros, directorios y flujos... C# tiene un espacio de nombre propio para ellos, que debemos invocar para tratar con las Clases apropiadas.

```cs
using System.IO;
```

## Pero antes de empezar... los flujos

Un flujo es el modo en que C#, o la plataforma .NET, gestionan los ficheros. Son zonas de memoria de diferentes tipos, porque pueden ser texto en forma de cadenas de texto o contenido binario, que permiten entrada y salida.

Imagina abrir un cuaderno para leer, escribir o borrar de su contenido. Eso sería abrir un flujo. Cuando termines tu tarea, necesitarás cerrar el cuaderno para que otro pueda operar con él, o simplemente el sistema operativo recupere el control del mismo. Como particularidad que no debes olvidar, es que diferentes propósitos con un fichero, o nuestro cuaderno, requerirá de abrir un flujo diferente.

Si quieres leer de un fichero, debes abrir un flujo para efectuar una lectura, y después cerrar.
Si quieres escribir de ese mismo fichero, debes abrir un nuevo flujo para escribir en ese fichero, y cerrar el flujo.

Puede parecer restrictivo e incómodo, pero a más control, menos oportunidades para fallar y corromper ficheros.

## Herencia

Imagen de herencia de System.IO

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

Metodos:

GetExtension(), un método que recibe la ruta a un fichero y devuelve una cadena de texto que será la extensión del fichero en cuestión. Incluso es posible compararlo con una cadena explícita para comprobar si es de una extensión concreta:

```cs
string rutaFichero = @"C:\imagenes\unaImagen.jpg";

if (System.IO.Path.GetExtension(rutaFichero) == ".jpg")
{
    Console.WriteLine("¡El fichero es una imagen!");
}
```

GetFullPath(), recibe una ruta a un fichero o directorio y devuelve la ruta completa de un fichero o directorio, que puede ser usada como ruta absoluta para operaciones varias.

ChangeExtension(), recibe una ruta a un fichero y la extensión a la que quieres cambiar, devolviendo una cadena con la extension cambiada en el fichero.

GetDirectoryName(), recibe una ruta a un fichero o directorio y devuelve el nombre del directorio en el cual este elemento que recibe está contenido.

### Clases para ficheros

#### File

La Clase File es una Clase estática que nos brinda operaciones como copiar, renombrar, eliminar... ficheros. También podemos obtener información sobre los atributos de un fichero, que se gestionan a través de la enumeración FileAttributes.

No es la más especializada en gestión de ficheros, pero tiene miembros muy importantes com, por ejemplo, la comprobación de si un determinado fichero existe.

Colabora fuertemente con la Clase Path, mencionada anteriormente.

Propiedades

Exists

Métodos

AppendAllText
AppendText
CreateText

### Clases para directorios

### Flujos
