# CLASES Y HERENCIA

¿Qué es una Clase? ¿Qué es la Programación Orientada a Objetos? ¿OOP, qué es eso, se come? Es fácil imaginarlo cuando piensas en un juego de rol. Tu personaje en un JdR tendrá unas características, habilidades… que se pueden expresar como en una Clase.

Personaje:

Nombre: Abraxas

* Fuerza: 13
* Velocidad: 10

Habilidades:

* Ataque con espada
* Invocación animal

En programación:

```cs
class Personaje {

// Propiedades
Nombre = Abraxas;
Fuerza = 13;
Velocidad = 10;

// Métodos
AtacarConEspada();
InvocarAnimal(3);
}
```

En el ejemplo, tenemos los datos de un personaje además de dos habilidades, en el que puedes atacar con la espada e invocar a tres animales (para este caso particular).

## Herencia

Tu personaje puede ser un guerrero, un mago o cualquier otra clase típica en un juego tipo D&D. Pero además, puede ser un humano o un elfo o un tiflin. Es una raza antes que cualquier oficio que haya escogido a lo largo de su vida. Por lo tanto, podemos decir que nuestro personaje puede ser un Humano Mago, antes Humano que Mago. Por lo tanto, nuestro Mago hereda de Humano, teniendo todo lo que le hace ser Humano.

```cs
class Criatura { }

class Personaje : Criatura  { }

class Druida : Personaje  { }

Druida miNuevoDruida = new Druida();

```

Todas las propiedades y métodos (características y habilidades) que tenga el Humano, ahora las tendrá este Mago que estamos creando.
Hemos creado la herencia, porque la Clase Mago hereda todo lo que tiene el Humano.

## Polimorfismo

```cs

Personaje otroPersonaje = new Druida();

```

## Instancias

Vamos a crear entonces a un Mago, nuestro Mago, para empezar a jugar. Esto es crear un objeto o crear una instancia, instanciar un Mago.

```cs
Mago personajePrincipal = new Mago();
```

Ahora tenemos nuestro Mago, que recibe el nombre de variable personajePrincipal. Este mago ahora podrá atacar…

```cs
personajePrincipal.Atacar();
```

… invocar a fieras…

```cs
personajePrincipal.InvocacionAnimal(10);
```

… e incluso ser renombrado:

```cs
personajePrincipal.Nombre = “Balem”;
```

## Miembros estáticos

Los miembros estáticos son aquellos que no requieren de instancia para ser invocados. No necesitas crear un nuevo mago para invocar a un método estático, solo necesitas el nombre de la Clase para ello.
Por ejemplo, como algo general, queremos saber qué hace un mago y por qué es buena opción como clase de nuestro personaje (aunque ya sabemos que los magos lo petan, y los nigromantes más todavía).

```cs
Mago.Descripcion();
```

Esta línea de código te devuelve esa información de los magos, y estamos usando el nombre de la Clase en sí, no una instancia del mago, no un mago en concreto.
¿Son importantes? Sí. Los métodos y propiedades estáticos son poco recomendables en la programación contemporánea, pero serán importantes para iniciarnos en la primera Clase que vamos a conocer: CONSOLE.

## ¿Puede haber más herencia?

Podemos pensar que una Clase puede heredar de varias, pero en C# existe el concepto de Herencia Única. Este concepto determina que una Clase solo puede heredar de una única Clase... el resto son Interfaces.

¿Qué es una Interfaz? Una Interfaz es una Clase que sirve únicamente para dejar su herencia y dictaminar un "comportamiento" a una Clase. Por lo que una Clase puede tener herencia y muchas interfaces, o tener solo una interfaz sin herencia, o varias interfaces sin herencia...

Por consenso, los nombres de las Interfaces se nombran con I + NombreInterfaz.

```cs
class Helicoptero : Vehiculo, IObjetoVolador {
Velocidad = 10;
}

Interface IObjetoVolador {
Volar();
}
```

Si quieres ampliar, puedes acudir al blog de Al Sweigart [(InventWithPython)](http://inventwithpython.com/blog/2014/12/02/why-is-object-oriented-programming-useful-with-an-role-playing-game-example/) o al blog de Elena Guzmán [(Geekstorming!)](https://geekstorming.wordpress.com/2016/06/06/por-que-es-util-la-programacion-orientada-a-objetos-con-rpgs/), donde la OOP se explica de forma dinámica y con ejemplos basados en RPGs contemporáneos.
