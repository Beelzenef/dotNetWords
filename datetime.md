# DateTime

Una estructura que representa una fecha y una hora. Es por tipo de dato por valor.
Representa una fecha y una hora.

Se utiliza con frecuencia en interfaces gráficos, formularios,etc.

Propiedades (tanto estáticas como de instancia).

* Date: Propiedad que contiene el DateTime asingado.
* Day:  Un tipo entero que contiene el día del mes en el que se llama.
* DayOfWeek: Un tipo entero que contiene el día de la semana en el que se llama.
* DayOfYear: Un tipo entero que contiene el día del año en el que se llama.
* Hour: La hora de la instancia
* Minute: El minuto de la instancia
* Millisecond: El milisegundo de la instancia
* Month: El mes de la instancia
* Today: La fecha actual en la que se llama a la propiedad
* Now: Lectura de la hora del sistema.

Podemos usar sus constructores para crear una fecha determinada, tiene varios que podemos ir explorando.

El más sencillo, que nos permite especificar año, mes y día en ese orden:

```cs
DateTime fechaClave = new DateTime(1993, 5, 5);
```

Y si probamos algunos miembros de instancia para, por ejemplo, obtener el día de esa fecha:

```cs
fechaClave.Day;
```

En cambio, miembros estáticos, para obtener la fecha del día actual:

```cs
DateTime.Today;
```

Los diferentes métodos existentes sirven para alterar esa fecha de instancia o comparar dos fechas… la documentación ofrece mucha ayuda.

Esta estructura está íntimamente relacionada con TimeSpan, una estructura que hace de complemento y que ahora vamos a conocer.
