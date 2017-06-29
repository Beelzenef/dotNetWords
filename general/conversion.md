# Conversion de valores

A veces, para tratar con diferentes Clases u operar con los datos que mejor convengan para una determinada ocasión, necesitas convertir valores a otros tipos de datos. En el pasado hemos visto qué [tipos de datos existen](tiposDatos.md), y pueden darse situaciones en las que necesitamos cambiar el tipo de un dato a otro tipo.

Estas operaciones no están permitidas con TODOS los tipos, pero hay muchas operaciones que sí lo están y que te facilitarán el camino.

Tenemos cuatro métodos para convertir, y vamos a usar una variable integer llamada “num” y otra de tipo double llamada “resultado”.

```cs
int num = 3;
double resultado = 0;
```

### Clase Convert, cogiendo la variable "num" y convirtiendo a tipo *double*:

En CSharp:

```cs
int num = 3;
resultado = Convert.ToDouble(num);
```

### Casting o casteo, casteando la variable "num" a tipo *double*:

En CSharp:

```cs
int num = 3;
resultado = (double)num;
```

En Java:

```Java
int num = 3;
resultado = (double)num;
```

### Método Parse, parseando de la variable "num" a tipo *double*:

En CSharp:

```cs
int num = 3;
resultado = double.Parse(num);
```

En Java:

```Java
int num = 3;
resultado = Double.ParseDouble(num);
```

### Método ToString(), tomando la variable "num" y convirtiendo a tipo *string*, siendo solo texto:

En CSharp:
```cs
int num = 3;
string texto;

texto = num.ToString();

// Referencias en la explicación de la [Clase Object](object.md)
```

En Java:

```Java
int num = 3;
String texto;

texto = num.ToString();
```

Excepto el método ToString() que es evidentemente exclusivo para strings, los otros métodos se dan para todos los tipos de datos que existen, o sus alias (como es “int” para Int32 o “double” para Double)
