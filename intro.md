#Conceptos básicos e introducción a CSharp

C# es un lenguaje de Programación Orientado a Objetos de forma total, además de ser compilado/interpretado. Podemos decir con esta información que, salvo muy contadas excepciones, todo es una Clase.
Programar es resolver un problema, ofrecer una herramienta con la que poder automatizar una tarea, simplificarla para el usuario… en definitiva, hacer feliz a las personas o a otros programas. Un algoritmo, lo que podía ser la unidad básica de la programación, debe ser finitio, preciso, eficaz, eficiente, con datos de entrada y datos de salida.
Representar los programas por escrito, ya sea mediante diagramas de flujo o pseudocódigo, es vital para abstraernos del problema, del código en sí, y encontrar la solución. Agobiarse no sirve de nada, a veces el papel es nuestro mejor amigo.
Hago incapié en esto por experiencia propia. Hay que aprender a pensar antes de picar código.

Tanto el pseudocódigo como los diagramas de flujo son herramientas en nuestras manos, aunque existan estándares recomendados, seguimos teniendo libertad para usarlos según nos convenga mejor.

Un ejemplo de DFD:

![](http://4.bp.blogspot.com/-515O6ynwUok/VXQNVA_La0I/AAAAAAAAAz4/6alsXOu3XDw/s1600/Ejemplo%2Bordinograma.JPG)

Y un ejemplo de Pseudocódigo:

![](http://3.bp.blogspot.com/-uCEFCkIVhFU/VkXv31Vdy3I/AAAAAAAAABM/nLu2fvc5a0A/s640/pic2.png)

También llamados ordinogramas. Es una forma gráfica de representar un algoritmo, utilizando símbolos, desde principio a fin con instrucciones y recursos. Se utilizan símbolos estandarizados.
Todos los elementos de un ordinograma están unidos por flechas que indican la dirección del flujo. No puede haber una fecha que no apunte a ninguna parte. Todas las flechas siguen ángulos rectos y nunca hacen conexiones laterales.
Se inicia en el Inicio y todo ha de acabar en el Fin. No puede haber un flujo perdido, todo ha de acabar en el flujo principal.

![](http://image.slidesharecdn.com/l1-flowsandpseudo-121016053535-phpapp01/95/flow-charts-and-pseudo-code-4-638.jpg?cb=1350365785)

Cosas para recordar

* Los DFD se escriben de arriba hacia abajo, de izquierda a derecha.
* Sólo existe un símbolo de Inicio y sólo uno de Fin, en la cabeza y el pie del ordinograma respectivamente.
* El flujo de datos se une por líneas que hacen giros de 90º, terminadas en flecha y siempre perpendiculares para horizontal y vertical.
* Hay que evitar el cruce de líneas o cualquier representación confusa.
* No puede haber ninguna línea que no desemboque en flujo.
* Todo texto escrito dentro de un símbolo debe ser legible, conciso y no demasiado extenso.
* Todos los símbolos pueden tener más de una entrada a la misma línea.
* Los símbolos tienen una salida única, salvo los símbolos de decisión, que dividen su flujo.

## Visual Studio 

![](http://i.imgur.com/UprlL46.png)

La sección azul es la sección donde podrás abrir proyectos, guardar todos los ficheros, compilar y ejecutar.
Algunos comandos rápidos:

CTRL + S - Guardar elementos
F5 - Compilar y ejecutar
F6 - Compilar sin ejecutar, para comprobar si todo va bien sin necesidad de ejecutar

La sección amarilla es donde se encuentra nuestro código, con el contador de líneas activado (aunque se puede desactivar).

La sección verde es el output de la compilación, donde marcará si la ejecucicón ha tenido éxito o no. También está la pestaña de lista de errores, que te marcará la línea donde se encuentran los errores en tu código. Visual Studio detecta los errores antes de compilar, las incoherencias o el código no accesible.

La sección roja es el proyecto. Tu programa será un proyecto, también llamada Solución. Ahí existen los ficheros de configuración de Visual Studio para el proyecto, los ficheros CS en C#, carpetas para recursos gráficos o de sonido… y es ahí donde navegarás para encontrar todo tu proyecto. Desde clic derecho en la Solución con la que trabajas, podrás añadir ficheros existentes, nuevos ficheros CS… y lo que se te ocurra. Se recomienda, ya que estamos aquí, tener un fichero CS por cada Clase que vayas creando.

La sección rosa, dentro de la roja, es pequeña pero no menos importante a la hora de trabajar con Visual Studio. Te ayudará a anclar la pestaña abierta aunque salgas de la zona, para seguir programando. Si la desanclas, se replegará para abrir más espacio al editor de código.

Adapta el IDE a tu gusto para trabajar más cómodamente.

## Tu primer proyecto en Visual Studio

![](http://i.imgur.com/L70DwU9.gif)

Cuando creas tu primer proyecto, es lo primero que encontrarás. Tenemos un proyecto de consola con el que vamos a empezar a jugar.

Tenemos varias secciones con las que operar.

En naranja, tenemos varias líneas que no reconoceremos al inicio pero que son esenciales. Cada instrucción de using y los diferentes elementos separados por puntos son namespaces o espacios de nombre. En resumidas cuentas, son bibliotecas que nos darán acceso a las diferentes Clases. Si te falta una determinada biblioteca, no podrás usar sus Clases.

En la sección verde tenemos una declaración de namespace propio, que podemos (y es recomendable) modificar. Para modificar un nombre de variable, Clase o espacio de nombre puedes usar CTRL+R+R sobre el nombre que quieras cambiar y escribir el nuevo nombre. Si nos llevamos este código a otro programa, podemos invocar nuestro código declarando:

```cs
using miPropioNamespace;
```

En la sección azul, tenemos una Clase ya declarada llamada Program. Dentro de Program estará nuestro primer código. Podemos y se aconseja cambiar ese nombre, es el estándar y da mala imagen usar los nombres por defecto que te da el IDE.  Para modificar un nombre de variable, Clase o espacio de nombre puedes usar CTRL+R+R sobre el nombre que quieras cambiar y escribir el nuevo nombre.

Y en la sección púrpura, tenemos el Main. Este es un método estático (static) que no devuelve nada (void), que se llama Main (Main) y recibe como parámetros un array de string llamado args (string[] args)
Por ahora no vamos a operar con ese array pero vamos a dejarlo tal cual.

Por lo pronto, es importante saber qué es estático y que no devuelve nada (void), por lo que tal y cual está el código, compilará. (Si devolviera otro dato, como un entero, podríamos especificar un “return 0;”, pero no es el caso).
El Main no necesita ser renombrado ni modificarse en los parámetros que recibe (por ahora).

Y es en Main donde se escribirá el código que vamos a ejecutar en inicio.

¿Cómo empezar? Con tu amiga y vecina la Clase Console.

