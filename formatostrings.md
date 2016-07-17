# Jugando con strings

Creando una variable de tipo string vacía:

```cs
string v1 = “”;
string v2 = string.Empty;
```

Transformar datos en forma de texto es posible y necesario. No todos los datos tienen que ser modificados en esencia para ser mostrados al usuario. Aquí entramos en los formatos.
Podemos, una vez conozcamos como formatear un string, prescindir de la concatenación. Utilizaremos los índices, conocidos en la programación, con el orden natural que empiezan por 0.

Existe una notación con la que poder formatear esos datos, y que podemos tener como referencia una vez profundicemos:

```cs
{0:c} - Formato moneda, €/$ dependiendo del sistema operativo
{0:dX} - Formato decimal, siendo X el número de dígitos decimales
{0:E} - Formato en notación científica
{0:FX} - Formato flotante con X dígitos flotantes
{0:G} - Formato general, por defecto
{0:N} - Formano numérico, separando entre miles
{0:X} - Conversión a hexadecimal
```

¿Ejemplos?

Vamos a mostrar una cadena de texto que relacione un nombre y una edad.

```cs
string nombre = "Júpiter";
string origen = "planeta Tierra";

Console.WriteLine("Mi nombre es {0} y procedo del {1}", nombre, origen);
```

Mostrará:

> Mi nombres es Júpiter y procedo del planeta Tierra

Hemos usado los índices para asignar variables y así formar un string consistente y fácilmente reutilizable.

Estos formatos están íntimamente relacionados con el método Format de la Clase String. Sus diferentes sobrecargas permiten pasar diferentes elementos para dar formato a un string.

```cs
string txt = “Mi nombre es {0}”;
string nombre = “Elena”;

Console.WriteLine(string.Format(txt, nombre));
```

Mostrará:

> Mi nombre es Elena

Este código toma el string txt como primer parámetro, que será el objeto a examinar, y le pasa los siguientes parámetros. Podemos usar varios strings, incluso un array de string para introducir tantas coincidencias como index existan entre corchetes.

Otro ejemplo, esta vez con cifras:

```cs
double nota = 5.345432;
Console.WriteLine(string.Format(“Solo dos decimales {0:f2}”, nota.ToString()));
```

Al escribir esa línea, solo mostrará este texto:

> Solo dos decimales 5,34

Otro ejemplo, para acceder a la fecha actual:

```cs
string.Format(“Hoy es {0}”, DateTime.Now.Date);
```

Y ya que conocemos los formatos a aplicar en cadenas de texto sobre datos varios, saber que podemos aplicar esta nueva forma de crear strings al método ToString() de la Clase Object.
Si observamos las sobrecargas del método ToString(), podemos observar que admite formatos aplicados.

```cs
double num = 2.234;
Console.WriteLine(num.ToString("00.000"));
```

Mostrará:

> 02,234

```cs
double num = 0.234;
Console.WriteLine(num.ToString(".000"));
```

Mostrará:

> ,234

Hemos aplicado un formato a esos números, rellenando los ceros existentes, es el espacio que cedemos a los datos con los que jugamos.
