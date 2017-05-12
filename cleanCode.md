
# Clean Code, por Uncle Bob

Existen muchos consejos para el desarrollo y programación de aplicaciones… y el tío Bob reúne muchos de ellos en su libro, en una lectura muy recomendable.

He aquí las lecciones más destacables y que podrían servir en el día a día cuando picamos código.

## Sobre formato

* En líneas verticales, lo ideal que los ficheros tengan entre 200 y 800 líneas.
* Usa el formato que encontramos en el periódico: título simple y explicativo. 
* Información al inicio, ¿sabe el programador al leer si está en el módulo o Clase correcto?

Lo ideal es organizar el código de esta forma:

* Inicio: conceptos y algoritmos de alto nivel
* Mitad: más detalles
* Final: código de menor nivel.

## Sobre distancia vertical

La declaración de variables debe estar orientada a estar cerca de sus funciones y usos. Las variables de instancia deben ser declaradas al inicio de la Clase.

Las funciones dependientes en invocación, declaradas cerca de sus invocadoras.

Según la afinidad conceptual, los grupos de funciones que operan de forma similar y otras regiones de código que operen conjuntamente… deben ser bloques de código cercanos.

Las líneas deben tener un máximo hasta 120 caracteres. Sin espacios innecesarios, sin finales de líneas ocultos (;), con indentación lógica de bloques y optimizada para obtener menos líneas posibles.

Si se establecen reglas de equipo, necesitamos seguir esas reglas. La integridad del código, de la  duplicación, y su legibilidad, prima sobre las afinidades personales de cada programador.

## Sobre comentarios

El código evoluciona, crece, pero los comentarios no. Si necesitas comentar, puedes limpiar código. Explícate en código, no en los comentarios.

#### ¿Comentas?

![](https://img.memesuper.com/8a1d5692ce5e8d53e6ea75e660a55b73_mulan-dishonor-meme-memesuper-dishonor-on-you-meme_336-200.gif)

Hay "escuelas" que defienden con firmeza que comentar el código es algo malo... mientras que otras optan por un punto medio. 

Para alcanzar ese punto medio, podemos diferenciar los buenos y malos comentarios.

### Sobre buenos comentarios:

* Legales, sobre las condiciones de uso
* Informativos (por ejemplo en métodos abstractos)
* Explicación del método (e.g. criterios de comparación)
* Clarificación
* Advertencia de consecuencias
* Comentarios de TO-DO
* Ampliaciones posibles

### Sobre malos comentarios:

* Desvariar, volcar tus pensamientos sobre el código.
* Comentarios redundantes (porque el código deber ser autoexplicativo).
* Comentarios ruidosos, que manchen con exceso de líneas.
* Comentarios de informadores,
* Diarios en comentarios, para cada modificación realizada,
* No usar *query-function*.
* Donde puedes usar una función o una variable, no uses un comentario.
* Marcadores de posición (propiedades, funciones…) El código se (o al menos debería) autodescribe.
* Comentarios de cierre de bloques, los nuevos IDE ya te ayudan a crear comentarios para esos bloques.
* Para ignorar código. Si ese código no sirve, ha dejado de ser útil, bórralo. No volverá para perseguirte.
* Comentarios HTML o algún otro lenguaje de marcado… si no se requiere
* Demasiada información.
* Explicaciones que resultan obvias.
* Cabeceros de funciones.
* Información sobre código no local, no presente. Un comentario debería aparecer cerca del código sobre el que informa.

## Sobre funciones

Debemos utilizar nombres descriptivos.

También deben ser pequeñas, que permitan la lectura de arriba hacia abajo, realizando una sola tarea. Trabajan en un solo nivel de abstracción

Descripción: “para (conseguir RETURN) se hace (funcion)”

A fin de simplificar la función, puedes utilizar el polimorfismo para simplificar en *switches*.

### Sobre argumentos o parámetros

Tenemos varios números mágicos a tener en cuenta:

* 0 como número ideal
* 3 como algo a evitar
* 3+ es mala señal

¿Pueden agruparse los argumentos en instancias de una Clase? Hazlo, es una señal para refactorizar y reorganizar los datos.

Sin efectos secundarios, sin acciones secundarias. La función *does one thing*. El nombre de la función podría incluso sugerir el orden de los parámetros.

Si una función…
… soluciona algo, es un command.
… responde a algo, es un query

Pero no las dos cosas, establece bien la separación entre *command* y *query*.

Es mejor lanzar excepciones que códigos de error.

Extrae los bloques de manejo de errores en una función:

```cs
try { 
	funcion(); 
	}
catch { 
	funcionManejoErroes();
	}
```

## Cuando tienes prisa...

Cosas que debes a tener en cuenta ante las emergencias o código urgente:

* Ejecuta todas las pruebas.
* Refactoriza.
* No dupliques código.
* Sé expresivo.
* Utiliza el número mínimo de Clases y de funciones.
* Define un flujo normal.
* Planea y escribe, *test-first coding*.
* No pases ni devuelvas NULL.

Las reglas para tests son:

* Fast
* Independent
* Repeatable
* Self Validating
* Timely

## Sobre cambios en el código…

No hay cambios triviales. Debes entender los riesgos de un mal código, pues de ello depende tu oficio.

El código limpio es *focused*, concreto, especializado, legible para los humanos. El código sucio tiende a crecer, es puro caos. El código no testeado también se considera sucio.

La tendencia suele ser de a más pequeño, más limpio. La probabilidad de que exista algún fallo decrece con la menor cantidad de código.

> El único código que no falla es el que no existe - Eliseo Moreno

Debe ser fácil de leer y fácil de cambiar. Cuida tu código. 

La simplicidad es tu objetivo, evita la duplicación. El código cumple con las expectativas, y sin dar sorpresas. Los giros argumentales inesperados se quedan en las novelas. El programador es responsable de que el código parezca hecho para el problema que intenta solucionar. Minimiza los bloques de código.

No hay debate posible: para cumplir *deadlines*, es necesario hacer código limpio.

Practica, practica, practica, siempre, cada día.

## Nombrando código

Nombres explicativos, métodos para evitar números mágicos.

Las diferencias entre nombres deben contar, hay que hacerlas notables. Busca nombres fácilmente pronunciables. Nombres fácilmente localizables, pues las referencias deben ser lógicas. Evita palabras reservadas por el sistema o el lenguaje, también las bromas privadas o el humor oculto. **(NdT: Eso va por ti, Python)**

*Say what you mean. Mean what you say.*

Los programadores profesionales declaran, aseguran que la claridad es la reina en el código.

* Utiliza una palabra por concepto.
* Evita el *slang* o la jerga propia.
* Buenos nombres de instancias pueden ser malos nombres de Clases
* Refactorizar nombres es buena práctica, no temas hacerlo.
* El contexto de los nombres es necesario, pero no en exceso.

El nombrar un fragmento de código debe resolver tres preguntas:

* ¿Por qué existe?
* ¿Para qué existe?
* ¿Cómo se usa?

## Sobre Clases

Orden de elementos:

* Variables
* Constantes públicas estáticas
* Variables estáticas privadas
* Variables privadas de instancia
* Funciones públicas
* Funciones privadas y otras lógicas

Pequeñas, con la responsabilidad adecuada, con cohesión.
 
A más cohesión, más pequeñas serán y mejor mantenimiento tendrán.

## Malos olores

Sobre comentarios

* Información inapropiada.
* Comentarios obsoletos.
* Comentarios redundantes.
* Código comentado.

Sobre nombres

* Nombres no descriptivos.
* Nombres con niveles de abstracción.
* Nombres con estándares mientras sea posible.
* Nombres ambiguos.
* Evita *encodings*.
* Nombres que describen efectos secundarios.

Sobre funciones

* Demasiados parámetros.
* Parámetros de salida.
* Parámetros *flag*.
* Funciones muertas, código *zombie*. Los zombies solo te persiguen en la ficción.

# this is, my friend, the end

Y hasta aquí las lecciones más notables del tío Bob. Espero que sea útil en vuestro día a día como desarrolladorxs.
