# TimeSpan

Una estructura que sirve para operar con instancias de [DateTime](datetime.md). Sus diferentes constructores permiten la instancia de días, horas, minutos o segundos. Debemos atender bien a la ayuda que nos da el IDE para saber qué valor estamos dando a cada parámetro.

Conozcamos sus miembros:

* Days
* Hours
* Minutes
* Seconds
* Miliseconds
* TotalDays
* TotalHours
* TotalMinutes
* TotalSeconds

Como almacena operaciones de fechas, tiene sentido que algunas propiedades tomen las horas, minutos… que quedan en la fecha, y otras propiedades almacenen el total de esas operaciones.

Tiene varios métodos, pero dos de ellos destacan, dos métodos de instancia:

* Addition() Recibe un TimeSpan y lo suma a la instancia que llama al método.
* Substraction() Recibe un TimeSpan y lo resta a la instancia que llama al método.

Operar con TimeSpans es relativamente sencillo. Para ello necesitamos dos instancias de la Clase DateTime, y hacer una operación como la suma o la resta entre ellas. Pero el primer paso será tomar dos fechas. En el ejemplo, 13/1/2013 y 2/4/2018 son nuestras fechas.

```cs
DateTime primeraFecha = new DateTime(2013, 1, 13);
DateTime segundaFecha = new DateTime(2018, 4, 2);
```

Y ahora, podemos operar. Por ejemplo, restar la segunda fecha menos la primera.

```cs
TimeSpan resta = segundaFecha - primeraFecha;
```

El objeto resta del tipo TimeSpan ahora contiene ese cálculo. Con los miembros de TimeSpan podemos interrogar a *resta* sobre cuantos días han pasado, cuantas horas...

```cs
resta.TotalDays;
resta.TotalHours;
```

Podemos realizar sumas, restas, comparaciones de mayor o menor qué... y obtener cifras de días totales, del día que ha quedado en resultado... cualquier información que podamos obtener con los diferentes miembros a nuestra disposición.
