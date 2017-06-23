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

### Métodos (a revisar)

|Método| Tipo de dato | Explicacion|
|----|:----:|----|
| Add(O) |void | Añade al final de la lista el elemento especificado como parámetro|
|Clear() | void | Limpia la lista, eliminando todos los elementos. |
|Contains(O)|bool|Busca la primera ocurrencia del elemento a buscar, que se especifica en el parámetro.|
|IndexOf(O)|int| Devuelve el índice, la posición, de la primera ocurrencia del elemento a buscar, que se especifica en el parámetro.|
|LastIndexOf(O)|int| Devuelve el índice, la posición, de la última ocurrencia del elemento a buscar, que se especifica en el parámetro.|
|Remove(O)|void| Elimina la primera ocurrencia o aparición del dato especificado como parámetro.|
|RemoveAt(int)|void| Que elimina el dato que se encuentra en la posición que se deterima en el parámetro.|
|RemoveRange(int, int) |void| Elimina todos los elementos en el rango especificado en los dos parámetros.|
|Reverse() |void| Invierte todos los elementos en la lista.|
|Sort() |void| Ordena todos los elementos bajo un criterio por defecto. Para listas con datos complejos, hay que especificar nuevos criterios.|
