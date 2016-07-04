# Conversion de valores

A veces, para tratar con diferentes Clases u operar con los datos que mejor convengan para una determinada ocasión, necesitas convertir valores a otros tipos de datos.

Tenemos cuatro métodos para convertir, y vamos a usar una variable integer llamada “num” y otra de tipo double llamada “resultado”.

```cs
int num = 3;
double resultado = 0;
```

Clase Convert:

```cs
resultado = Convert.ToDouble(num);
```

Casting:

```cs
resultado = (double)num;
```

Método Parse:

```cs
resultado = double.Parse(num);
```

Método ToString(), ya explicado en la herencia de la Clase Object:

```cs
string texto;

texto = num.ToString();
```

Excepto el método ToString() que es evidentemente exclusivo para strings, los otros métodos se dan para todos los tipos de datos que existen, o sus alias (como es “int” para Int32 o “double” para Double)
