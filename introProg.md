# ¿Qué es programar?

Programar es [resolver un problema](https://youtu.be/mvK0UzFNw1Q). Programar es simplificar una tarea, automatizarla. ¿Cómo?

Hablaremos con la máquina en un idioma que esta entiende y que resulta intermediario entre los dos. La máquina es idiota, eso es una realidad. Hará aquello que tú le especifiques, y si encuentra errores, es porque algún error humano ha encontrado en su camino. Por eso, usamos el PICNIC (Problem Is In Char Not In Computer).
La forma más fácil de quebrar un sistema es plantearle a la máquina una situación que no sepa resolver.

Así pues, un programa son instrucciones, línea a línea, que la máquina recibirá, interpretará y ejecutará. Estas instrucciones se pueden dar en diferentes lenguajes, más nuevos o más antiguos, más ágiles o más “verbosos” (requieren de más palabreo para ejecutar órdenes). Al final, todo depende de la empresa con la que trabajes, las preferencias personajes o aquello con lo que te hayan instruido.

Esas instrucciones que serán un programa pueden ser algo tan sencillo como mostrar algo por pantalla, o transformar datos. El programa te pide un número, y si este es par, te mostrará por pantalla si es par. De lo contrario, te mostrará que es impar.
Es un ejemplo sencillo de lo que se puede llegar a hacer.

Hay soluciones en más líneas o menos líneas. Las hay más o menos sencillas.
Lo importante es que te expreses mediante el código, tanto para el programa como para cualquiera que te lea y quiera entender qué pretendes hacer.

Empecemos con conceptos básicos:

Variables. Una variable es un almacén de datos, es el nombre con el que vamos a usar un número y a trabajar con él. Por ejemplo:

Tengo 23 años.

Y en programación:

```cs
edad = 23
```

Si te fijas, la asignación del número 23 a esa variable llamada edad se hace de derecha a izquierda, y esto es un concepto básico.

Mientras tu programa viva o se esté ejecutando, puedes usar la variable *edad*. La creas, le has asignado un valor, y puede tener otro valor sustituyendo al anterior. Tanto el pseudocódigo como los diagramas de flujo son herramientas en nuestras manos, aunque existan estándares recomendados, seguimos teniendo libertad para usarlos según nos convenga mejor.

Podríamos hacer:

```cs
edad = 23
edad = 24
```

Al principio valía 23 y ahora vale 24. El valor anterior se ha perdido, pero podemos operar con el valor nuevo.

Para expresarnos en la programación, existen diferentes representaciones que no dependen de ningun lenguaje. No necesitas saber ningun lenguaje de programación concreto para expresarte, para plantear, la solucion a un determinado problema.

Existe el pseudocódigo o el diagrama de flujo de datos. Tanto el pseudocódigo como los diagramas de flujo son herramientas en nuestras manos, aunque existan estándares recomendados, seguimos teniendo libertad para usarlos según nos convenga mejor.

Representar los programas por escrito, ya sea mediante diagramas de flujo o pseudocódigo, es vital para abstraernos del problema, del código en sí, y encontrar la solución. Agobiarse no sirve de nada, a veces el papel es nuestro mejor amigo. Hago incapié en esto por experiencia propia. Hay que aprender a pensar antes de picar código.

Un ejemplo de diagrama de flujo de datos, también llamados ordinogramas:

![](http://4.bp.blogspot.com/-515O6ynwUok/VXQNVA_La0I/AAAAAAAAAz4/6alsXOu3XDw/s1600/Ejemplo%2Bordinograma.JPG)

Es una forma gráfica de representar un algoritmo, utilizando símbolos, desde principio a fin con instrucciones y recursos. Se utilizan símbolos estandarizados.

Todos los elementos de un ordinograma están unidos por flechas que indican la dirección del flujo. No puede haber una fecha que no apunte a ninguna parte. Todas las flechas siguen ángulos rectos y nunca hacen conexiones laterales. Se inicia en el Inicio y todo ha de acabar en el Fin. No puede haber un flujo perdido, todo ha de acabar en el flujo principal.

Representar en pseudocódigo el ordinograma que tenemos arriba podría ser:

```cs
Programa: Calculo_AreaTriangulo
Recursos:
  altura
  base
  area
Algoritmo:
Escribir “Introduzca base”
Leer base
Escribir “Introduzca altura”
Leer altura
Calcular: area <- base * altura / 2
Escribir “El area de triangulo es “ area
```

## Caminos diferentes

A veces, necesitamos tomar caminos diferentes dependiendo de como son nuestros datos. Estos son los condicionales.

Representando en pseudocodigo:

```cs
Programa: Determinar_MayoriaEdad
Recursos:
  edad
Algoritmo:
Escribir  “Introduce tu edad”
Leer edad
Si (edad > 18) entonces
Escribir “Eres mayor de edad”
```

Existen condicionales más complejos, como los condicionales de dos caminos:

```cs
Programa: Determinar_MayoriaEdad
Recursos:
  edad
Algoritmo:
Escribir “Introduce tu edad”
Leer edad
Si (edad > 18) entonces
Escribir “Eres mayor de edad”
Si no
Escribir “No eres mayor de edad”
```

Al final, en ordinogramas bien te puede recordar a [algo así](http://1.bp.blogspot.com/-1lcuJh_tH88/VTu6R9u2oaI/AAAAAAAAABk/OS5w0W6mUZY/s1600/Caracter%C3%ADsticas-del-Ejemplo-de-diagrama-de-flujo.jpg), muy recurrentes en el humor.

Muy pronto, ¡más y mejor!

Y así, con estructuras más complejas, donde por ejemplo, juegan más condicionales. Estos bloques son llamados SWITCHES o bloques CASO (por ser “en caso de... “), y te ofrecen alternativas para caminos varios.

```cs
Programa: ElegirOpcion
Recursos:
	opcion
Algortimo:
Leer opcion
Caso (opcion)
	caso 1:
		Escribir “Has elegido opcion 1“
caso 2:
		Escribir “Has elegido opcion 2“ 
caso 3:
		Escribir “Has elegido opcion 3“
Fin CASO
Fin ElegirOpcion
```

Y representado en [ordinogramas](http://image.slidesharecdn.com/diagramasdeflujo2-140108193258-phpapp01/95/diagramas-de-flujo-estructuras-de-control-for-while-do-whille-y-switch-case-16-638.jpg?cb=1390379460)...

## Bucles

Y entramos en los bucles. Los bucles son instrucciones que se repiten hasta que algo ocurre. Lo normal es que eso que ocurra es que una condicion se rompa. Por ejemplo, podemos programar que se ejecuten unas instrucciones tres veces. Cuando se ejecute tres veces, el bucle se rompe. Esas tres veces de ejecución es la condición rota.

De una forma similar a la programación podemos decir: mientras que no hayas dado tres vueltas, ejecuta este código.

Si no hay ruptura del bucle, si no hay una condición de salida del bucle, estamos frente a un bucle infinito. Y estos bucles son, salvo excepciones, indeseables. Se rompen cerrando el programa, y es el usuario el que decide cuando cerrar el programa, no necesiaramente porque lo necesite ante una situación no controlada.

Existen tres bucles principales, comunes a la programación, aunque en el futuro puedes encontrar otros que se irán conociendo cuando sea oportuno.

### Bucle While

El bucle WHILE o MIENTRAS se ejecuta mientras una condición sea cierta.

```cs
...
MIENTRAS (suspenso)
	Estudiar
Fin MIENTRAS
...
```

Mientras estoy suspenso, tengo que estudiar. Cuando dejes de estar suspenso, dejarás de estudiar para disfrutar de tus vacaciones.

Y representado en [ordinogramas](http://image.slidesharecdn.com/diagramasdeflujo-090805231936-phpapp01/95/diagramas-de-flujo-15-728.jpg?cb=1249514389)...

### Bucle DOWHILE

El bucle HACER o DOWHILE es un bucle inverso al WHILE o MIENTRAS.

```cs
...
HACER
	Estudiar
MIENTRAS (suspenso)
Fin HACER
...
```

¿Por qué es inverso? Habrá ocasiones, dependiendo de lo que necesites programar, en que necesitarás ejecutar un código antes que evaluar esa condición que mantiene al bucle vivo.

Así que, primero estudias, y después compruebas si sigues suspenso. Pero lo primero es estudiar. Cuando dejes de estar suspenso, dejarás de estudiar para disfrutar de tus vacaciones.

Y representado en [ordinogramas](http://image.slidesharecdn.com/diagramasdeflujo-090805231936-phpapp01/95/diagramas-de-flujo-15-728.jpg?cb=1249514389)...

### Bucle FOR

El bucle FOR o PARA es más complejo. Consta de tres partes que te ayudarán a que el código dentro del bucle se ejecute y salga cuando se cumpla una condición.
Está pensado para un número de repeticiones o iteraciones determinadas.

```cs
...
PARA:
	numeroVeces = 0
	Si numeroVeces < 10
	numeroVeces se incrementa
estudiar
Fin PARA
...
```

¿Como funciona, después de haber visto este pseudocódigo? Lo primero es ver que tenemos un número de veces, que está puesto a 0. Esto es un contador, nuestro contador de veces que se ejecuta el código dentro del bucle.

Este bucle se ejecutará siempre y cuando el número de veces que se ha ejecutado sea menor que 10. ¿Cómo lo sabemos? Porque a cada vez que se ejecuta el bucle, la variable numeroVeces se incrementa en uno.

Y esos son, en esencia, las tres líneas que definen el funcionamiento de un bucle PARA o FOR. Determina un contador a cero, establece cuantas veces se va a ejecutar y cambia ese contador para un correcto funcionamiento.
Al final, el buen estudiante estudiará diez veces al día. Que locura, ¿no?

Y representado en [ordinogramas](http://image.slidesharecdn.com/diagramasdeflujo-090805231936-phpapp01/95/diagramas-de-flujo-16-728.jpg?cb=1249514389)...

## Tipos de datos

No todos los datos con los que trabajaremos son iguales, aunque hasta ahora no hayamos hecho diferenciación. A veces podemos trabajar con texto. A veces, con números. Otras, con números con parte decimal. Otras veces, con valores de Verdadero/Falso.

Todos esos tipos tienen nombre, englobados en tipos de datos, y conviene conocerlos aunque sea para movernos en la terminología del desarrollo y la programación.

* Cadenas de texto, texto, strings. Son
* Números, enteros.
* Números con decimales, floats.
* Booleanos. Según el Teorema de Bool, se genera la dicotomía perfecta: el verdadero o falso, el conmigo o contra mí, el blanco o negro. Y en la programación hay muchos absolutos.

## Operadores

Suma
+

Resta -

Multiplicación
*

División
/

Módulo, que será el resto de una división entre dos números:
%

Mayor que, gene
>

Menor que
<

Mayor o igual que >=

Menor o igual que <=

Igualdad, que puede variar dependiendo del lenguaje: ==

Desigualdad, que puede variar dependiendo del lenguaje:
!=, <>

## Puertas lógicas

Con los operadores que comparan datos (igual o no, mayor o menor que…), obtenemos valores booleanos. ¿Es mayor 3 que 1? Sí, verdadero, TRUE. ¿Es 4 diferente de 4? No, falso, FALSE.

Con estas comparaciones se pueden establecer condicionales, para bloques de código IF o bucles cualesquiera que necesitan condiciones de salida.

Estas comparaciones se pueden agrupar. ¿Cómo? Mediante el uso de paréntesis. En matemáticas, los operadores de multiplicación y división se evalúan antes que sumas y restas, y las operaciones entre paréntesis se evalúan antes que las que están en paréntesis exteriores o directamente sin ellos… En operaciones de comparación o booleanas, ocurre de forma similar. Es la lógica que veíamos en filosofía, con las tablas de verdad.

Evaluemos esta expresión:

(4 > 3) y (5 > 2), que puede ser simplificada a TRUE y TRUE. Son independientes, son dos valores independientes, pero agrupandolas usaremos dos nuevos operadores, operadores booleanos.

Conjuntor, disyuntor y negador, que aquí negaremos operador AND, operador OR y negador.

* El operador AND determina que es cierto, TRUE, siempre que los dos operandos con los que juega sean verdad, TRUE.
* El operador OR determina que es cierto, TRUE, cuando al menos uno de los dos operandos con los que juega sean verdad, TRUE.
* El negador, NOT, simplemente convierte un TRUE en FALSE y a la inversa.

En estas tablas se puede apreciar gráficamente, contando con que A y B son los operandos o inputs y C el resultado u output, también siendo 0 FALSE y 1 TRUE. Son llamadas tablas de verdad o puertas lógicas (logic gates) por si es necesario investigar otras fuentes,

![](http://newstudent.groups.et.byu.net/Labs/Logic%20Gates/TruthTables.GIF)

Entonces…

```cs
TRUE AND TRUE = TRUE
TRUE AND FALSE = FALSE

TRUE OR TRUE = TRUE
TRUE OR FALSE = TRUE
FALSE OR FALSE = FALSE

NOT FALSE AND TRUE = TRUE
```

Estas expresiones se pueden encadenar hasta donde queramos, pero es aconsejable no superar las dos o tres condiciones encadenadas.

# Conclusiones

Estas van a ser algunas de las herramientas con las que resolverás los algoritmos más sencillos, para iniciarte. Puedes crearlos mediante pseudocódigo o mediante ordinogramas, y una vez lo tengas resuelto, lo traducirás al lenguaje de programación de tu elección.

Ahora que hemos entendido conceptos básicos y comunes para la programación, es hora de empezar a ponerlo en práctica con un lenguaje de programación.
La red está literalmente inundada sobre qué lenguaje elegir, dependiendo de lo que quieras o lo que pretendas hacer. Ejemplos en [Hipertextual](https://hipertextual.com/2015/02/elegir-lenguaje-de-programacion) o [bestprogramminglanguageforme](http://www.bestprogramminglanguagefor.me/).

Puede que estos portales te ofrezcan una alternativa maravillosa, mágica. Cuando yo empecé, Python estaba de moda e iba a revolucionar el mundo de la programación. Con el tiempo he aprendido otros y detesto Python por… motivos varios.
La experiencia te dirá cual te gusta más o con cual te manejas mejor. Es hora de elegir. 
