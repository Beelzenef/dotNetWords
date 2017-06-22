# Clase Dictionary

La Clase Dictionary representa a una colección compuesta por un par de clave y valor, sin un comportamiento específico pero dinámica en cuanto a espacio. Se usa la convención `T`, para indicar los tipos que se usarán tanto en la clave como en el valor.

## Constructores

Una lista sin longitud especificada y que contiene una clave de números y valores como cadenas de texto:

```cs
Dictionary<int, string> listaPersonas = new Dictionary<int, string>();
```

Un diccionario para contener números, como clave y como valor, de longitud 10:

```cs
Dictionary<int, int> dicNumeros = new Dictionary<int, string>(10);
```

Un diccionario para contener libros, donde tenemos números para claves y libros, de la Clase Libro, como valores, de longitu 20:

```cs
Dictionary<int, Libro> biblioteca = new Dictionary<int, string>(20);
```

## Propiedades

## Métodos
