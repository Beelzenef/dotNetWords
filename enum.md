# Clase Enum

Una enumeración es un set de datos, como vimos en lecciones anteriores. Son constantes aunadas bajo un mismo nombre.

Pensemos en los días de la semana, que podrían ser un conjunto de valores inalterable, constante. Podrían ser un buen ejemplo para las enumeraciones.

¿Cómo crear una enumeración? Pues ya que nos gusta el cine, vamos a categorizarlo en sus géneros de ficción.

```cs
enum GenerosFiccion {
  CienciaFiccion, Aventura, Terror, Romance
}
```

Para acceder a ellos y almacenarnos en, por ejemplo, una variable, tenemos que comprender que lo que hemos creado con una enumeración es un tipo de dato.
Nuestro tipo de dato es GenerosFiccion, como pudiera ser un string o un integer. Entonces, para crear una variable:

```cs
GenerosFiccion unGenero;
```

Y con nuestra variable creada, podemos darle un valor:

```cs
unGenero = GenerosFiccion.Terror
```

Como otros tipos de datos como los arrays (que entraremos en breve en ellos), tienen un índice que comienza en cero… y que resulta accesible de la siguiente forma.

Según nuestro tipo de dato GenerosFiccion, accederemos al índice del género CienciaFicción.

```cs
GenerosFiccion cifi = GenerosFiccion.CienciaFiccion;
int numCiFi = (int)cifi;

Console.WriteLine(numCifi + “ es el genero “ + cifi);
```

Lo que mostrará:

> “0 es el género CienciaFiccion”

Eso no significa que esos valores sean inamovibles, todo lo contrario. Mientras que los nombres son constantes, los valores pueden cambiarse.

```cs
enum GenerosFiccion {
  CienciaFiccion,
  Aventura = 5,
  Terror,
  Romance
}
```

Este cambio tiene usos varios en los métodos de la Clase Enum, que veremos a continuación:

### Métodos

Format()
Convierte el valor especificado, el valor pasado como parámetro, en la cadena equivalente en el formato que se le pida.

GetName()
Recupera el nombre del identificador indicado a un tipo indicado, devolviendo un string con el nombre del valor que corresponda.

Su sintaxis es:

```cs
Enum.GetName(TypeOf(nombreEnumeracion), nIndice);
```

GetNames()
Devuelve un array con todos los nombres de todos los miembros de una enumeración, porque no siempre conocemos los valores asociados a sus miembros.

GetValues()
Devuelve un array de enteros, pues obtiene todos los valores de los miembros de la enumaración,
