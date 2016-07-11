# TimeSpan

Una estructura que sirve para operar con instancias de DateTime. Sus diferentes constructores permiten la instancia de días, horas, minutos o segundos. Debemos atender bien a la ayuda que nos da el IDE para saber qué valor estamos dando a cada parámetro.

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

Operar con TimeSpans es relativamente sencillo:

```cs
DateTime primeraFecha = new DateTime(2013, 1, 13);
DateTime segundaFecha = new DateTime(2018, 4, 2);

TimeSpan suma = primeraFecha + segundaFecha;

TimeSpan resta = primeraFecha - segundaFecha;
```

Podemos realizar sumas, restas, comparaciones de mayor o menor qué... y obtener cifras de días totales, del día que ha quedado en resultado... cualquier información que podamos obtener con los diferentes miembros a nuestra disposición.
