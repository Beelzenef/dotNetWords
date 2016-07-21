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
