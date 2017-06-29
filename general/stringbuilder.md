# Stringbuilder

La Clase Stringbuilder se encuentra en el espacio de nombre System.Text, y está especializada en operaciones con string.

## Constructores

Tiene varios constructores, con diferentes usos.

Un constructor vacío, sin parámetros, sin especificaciones concretas.

```cs
StringBuilder strB_ = new StringBuilder();
```

Una instancia para especificar la capacidad de la cadena de texto:

```cs
StringBuilder strB_ = new StringBuilder(15);
```

Una instancia para especificar la capacidad de la cadena de texto y hasta qué longitud se puede ampliar.

```cs
StringBuilder strB_ = new StringBuilder(15, 50);
```

Construccion de la instancia a través de una cadena de texto, una variable de tipo `string`:

```cs
StringBuilder strB_ = new StringBuilder("texto");
```
Construccion de la instancia a través de una cadena de texto, una variable de tipo `string`, junto con la capacidad que tendrá:

```cs
StringBuilder strB_ = new StringBuilder("otro texto", 30);
```

## Propiedades

* Length
* Capacity
* MaxCapacity

## Métodos

* Append(). Fuertemente sobrecargado, para añadir al final de la instancia varios tipos de datos.
* AppendLine(). Sobrecargado. Añade una cadena de texto con salto de línea al final de la instancia. Esa cadena puede estar vacía o no, depende de la sobrecarga.
* Clear(). Limpia toda la instancia de texto.
* Insert(). Fuertemente sbrecargado, para incluir en posiciones determianadas en la instancia varios tipos de datos.
* Replace(). Sobrecargado para la sustitución de datos con otros posibles tipos de datos.
* Remove(). Elimina de la instancia el rango de posiciones especificadas como parámetros.

```cs
StringBuilder strB_Ejemplo = new StringBuilder("Saludos, devs");
strB_Ejemplo.Remove(2, 6);
```
