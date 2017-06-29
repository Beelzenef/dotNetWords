# Sobrecarga de métodos

Cuando lees documentación de Clases, es posible que encontremos variantes sobre un determinado o varios métodos. ¿En qué sentido? Puede que exista método con un determinado nombre que en ocasiones reciba un entero… a veces recibe un entero además de una cadena de texto… ¿Cómo es posible esto?

Este sistema se conoce como sobrecarga de métodos. 
Los métodos tienen una firma. La firma es la primera línea de un método, que consiste en su identificador (nombre), sus parámetros y el tipo de valor que devuelve. El resto del código consiste en su declaración, el algoritmo que resuelve, pero no en su firma.

¿En qué consiste entonces la sobrecarga de métodos? La sobrecarga de métodos es el uso de un método con un determinado nombre y un mismo tipo de valor a devolver pero con diferentes parámetros.

Por ejemplo:

```cs
static string EsPar(int num) { ... }

static string EsPar(int num, string nombre) { ... }
```

Tenemos dos métodos con un mismo nombre, mismo valor de devolver, diferentes parámetros. Realizarán el mismo proceso o parecido, dependiendo de lo que se especifique en su codificación.
Según tus necesidades a la hora de invocar métodos varios de Clases ya generadas, te ofrecerán usar las sobrecargas disponibles.
Si vas a escribir tus propios métodos, recuerda que **si tiene el mismo nombre pero devuelve otro tipo de dato, no se trata de una sobrecarga**, simplemente son métodos diferentes.

La documentación es genial a la hora de saber qué necesitas o qué puedes usar.
