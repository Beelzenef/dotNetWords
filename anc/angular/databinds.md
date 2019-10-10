# Databinding, directivas y más

## _DataBinding_

### _Interpolation_

Es el modo más sencillo de hacer _dataBinding_ en nuestra aplicación. Se puede apreciar en nuestro componente inicial, al ver cómo nuestra variable `title`, que da nombre a la aplicación desde TS, se referencia y aplica en nuestro fichero HTML con `{{ title }}`. Es sencillo pero no permite mucha interactuación con el usuario.

La _interpolation_ puede acoger tanto variables como operaciones matemáticas sencillas. Pueden ser tanto el valor de una _tag_ en HTML como el valor de uno de sus atributos:

```html
<h1>{{ title }}</h1>
<h1 innerText='{{ title }}'></h1>
```

Como ejemplo de operacines sencillas, una muestra de código válido:

```html
<p>{{2 + 2}}</p>
<p>{{cantidad + 2 }}</p>
```

### Directivas estructurales

#### `ngIf`

Esta directiva oculta o muestra un elemento HTML dependiendo de una condición declarada en la Clase con la que opera. Es tan simple como imaginar que tenemos una variable `showImage` de tipo `bool` y que va a operar sobre un elemento `img`.

```html
<img src="rutaImagen" *ngIf='showImage'/>
```

Incluso condiciones complejas, como una tabla que se muestra o no dependiendo de los elementos de un _array_:

```html
<table *ngIf='items && items.lenght'>
  ...
</table>
```

#### `ngFor`

¿Qué ocurre si no es una variable con valor único, si es un _array_? Angular permite operar con datos que son listas en bucles que podemos declarar en nuestro código. Si declaramos un array en nuestro componente con TypeScript:

```ts
names : string[] = [
    "Name1", "Name2", "Name3"
  ]
```

... en nuestro fichero HTML podemos recorrerlo como si de un bucle FOREACH se tratase, para escribir el contenido de cada elemento en un nuevo _tag_ HTML. En el ejemplo que sigue, se añade un nuevo `<li>` para cada _item_ que hay en la lista de `names`:

```html
<ul>
    <li *ngFor="let item of names">
      {{item}}
    </li>
</ul>
```

Recuerda que hay diferencias entre bucles `FOR OF` y `FOR IN`, y [aquí puedes seguir leyendo sobre el tema](https://codeburst.io/javascript-the-difference-between-foreach-and-for-in-992db038e4c2).

### _Property binding_

No solo puedes _bindear_ o interpolar el valor de una _tag_ en HTML, si no que también puedes marcar la propiedad como _binding_, cambiando el modo en que añades código.

El método habitual, mediante interpolación:

```html
<img src='{{elemento.imagen}}'/>
```

Y ampliando con la interpolación hacia otro nivel de reutilizar código:

```html
<img src='https://ruta.lol/{{elemento.imagen}}'/>
```

_Bindeando_ la propiedad `img`, ¡e incluso `title`!, dándole el valor de un elemento que ya conoce la Clase en Typescript:

```html
<img [src]='elemento.imagen' [title]='elemento.nombre'/>
```

Como con esta propiedad sencilla, puedes modificar otras más complejas como por ejemplo el ancho o alto de un elemento:

```html
<img [style.width.x]='anchoImagen'/>
```

### _Template statements_

El código HTML que escribamos se puede _bindear_ a propiedades, pero también podemos añadir _handlers_ a determinados eventos, como pueden ser los _clicks_ sobre botones: los eventos `click()`. En nuestra lista de elementos en HTML, añadiremos una sentencia donde el evento `click()` será tratado en un método llamado `clickando()`, que recibirá el elemento de la lista que estemos pulsando.

Para denotar un _target_ que se _bindea_ desde Angular, añadimos `()` sobre el evento.

```html
<ul>
    <li *ngFor="let item of names" (click)="clickando(item)">
      {{item}}
    </li>
</ul>
```

En nuestro código del componente hemos declarado ese método, que recibe un `string`... ¡y solo queda mostrarlo por la consola!

```ts
clickando(sentence : string) {
    console.log("clicking: " + sentence)
  }
```

La declaración de estos métodos que funcionan como _handlers_ no requieren de _keywords_, por lo que solo necesitaremos añadir el nombre, los parámetros si es que los tiene y el código que va a ejecutar.

### _Data-binding two-way_

Es posible hacer _data binding_ de forma bidireccional. Para comprobar de forma sencilla, enlazaremos la variable del título de nuestra aplicación con una caja de texto, un `input` de tipo texto.

Para ello, modificaremos el módulo en el que reside el componente con el que trabajamos para añadir una dependiencia, `FormsModule`.

```ts
import { FormsModule } from '@angular/forms'

...

  imports: [
    BrowserModule,
    FormsModule
```

Una vez añadido, podemos añadir a nuestro fichero HTML la sintaxis para _bindear_ la variable `title` con la caja de texto. Si modificamos su contenido en la aplicación, comprobaremos que el título que se muestra en nuestra aplicación se cambia a tiempo real.

```html
<input type="text" [(ngModel)]="title"/>
```

---

Podemos entonces resumir el tema de _data binding_ en la siguiente imagen:

![Data binding](https://cdn-images-1.medium.com/max/1600/0*LNoIkhlqQBqvlDJk.)
