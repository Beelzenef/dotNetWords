# Angular

Es un _framework_ para el desarrollo de aplicaciones web y de escritorio. Encuentra más información en [su sitio web](https://angular.io/). Encuentra ejemplos _commit_ a _commit_ en [anAdventure](https://github.com/Beelzenef/anAdventure), una aventura RPG alojada en GitHub.

## Instalación de NodeJS

Descarga versión LTS desde [la web](https://nodejs.org/es/).

Comprueba su funcionamiento desde la terminal:

Comprueba la instalación de NodeJS con:

`> node -v`

Comprueba la instalación de NPM con:

`> npm -v`

## Instalación de AngularCLI

Desde una terminal y no desde el cliente de NodeJS escribe:

`> npm install -g @angular/cli`

Creando una nueva aplicación con Angular:

`> ng new myFancyApp`

"Sirviendo" la app, haciendo que cualquier cambio se aplique en "caliente", sin necesidad de recargar el navegador:

`> cd myFancyApp`

`> ng serve`

Por defecto, necesitarás acceder a la aplicación desde [http://localhost:4200](http://localhost:4200), aunque también puedes elegir servir la aplicación desde otro puerto:

`> ng serve --port 4201`

Si quieres "servir" la aplicación y abrir directamente el navegador, puedes escribir:

`> ng serve --open`

o

`> ng serve -o`


Cuando clonas un proyecto ya iniciado, en tu copia local necesitarás instalar la aplicación, así que una vez dentro del directorio de la misma, ejecuta:

`> npm install`

## Eligiendo formato de estilos

Al momento de crear una aplicación con Angular, se te da a elegir el formato de estilo que puedes utilizar en las aplicaciones, a saber:

* CSS
* SCSS
* SASS
* LESS
* Stylus

## Módulos en Angular

En el proyecto creado, puedes encontrar módulos, como `src/app/app.module.ts`. Es la forma en la que se organiza la aplicación, de forma modular en unidades lógicas.

![](https://pbs.twimg.com/media/CvGgsTAWAAIfvNA.jpg)

Algunas Clases se pueden importar, asigándoles nombre que podemos usar en nuestra aplicación.

`import { NombreClase } from '@angular/core'`

Otras clases tienen otros orígenes:

`import { OtraClase } from './otraClase'`

Los módulos tienen decoradores que dan información a la aplicación sobre lo que este contiene. ¿Cómo se llama la Clase? ¿Qué Clases importa? ¿Qué servicios tiene inyectados? ¿Cuál es su _bootstrap_? Todas esas preguntas tienen que ser resueltas en el decorador de la Clase que tiene el módulo. En `app.module.ts`encontramos:

```ts
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
```

## Componentes

Son los fragmentos o páginas en nuestra aplicación. Pueden incluso anidarse, un componente que invoca a otro componente. Independientes o anidados, todos los que sean invocados deben estar declarados en el módulo, concretamente en el _array_ de `declarations` del fichero

Un componente puede estar formado por tres ficheros. Si nos vamos a AppComponent encontraremos:

* `app.component.ts`, donde se encuentra el código TypeScript y Javascript para la lógica de nuestra aplicación en uno de sus componentes.
* `app.component.html`, donde se almacena todo el código HTML que se va a mostrar para el componente.
* `app.component.css`, o quizás otra extensión dependiendo del formato de estilos que hayamos elegido. Al iniciar la aplicación, estará vacío.

Este es el contenido de `app.component.ts`:

```ts
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'anAdventure';
}
```

Del decorador de la Clase podemos destacar:

* `selector`: que define en qué etiqueta se va a insertar el código que definamos en combinación con `app.component.ts` y `app.component.html`. Si buscamos en el fichero `index.html`, encontraremos la etiqueta `<app-root>`.
* `templateUrl` || `template`: ¿dónde se va a insertar la lógica que escribamos para este componente?
  * Puede ser en un `template`, donde se va a dar todo el código HTML que necesitemos. Puede ser tan sencillo como una línea `<h1>{{title}}</h1>`, o más complejo con múltiples líneas. En este último caso, usaremos _backticks_ para englobar ese código:


  ```html
    `<div>
        <h1>{{title}}</h1>
    </div>
    `
  ```

  * En caso de que necesitemos un fichero completo HTML, se especificará el `templateUrl` con la ruta relativa a ese fichero.
* `styleUrls`: una lista o _array_ donde se buscarán los estilos a aplicar para el componente. Los estilos que se listan en este decorador solo se añaden a la aplicación cuando el componente está renderizado, por lo que no tiene por qué interferir con otros estilos de otros componentes.

También podemos añadir:

* `providers`: un _array_ de servicios e inyecciones que solo estarán disponibles para componentes específicos, y no para todo el módulo.

En el cuerpo de la Clase que tenemos, añadiremos variables, propiedades, funciones... todo lo que necesitemos para nuestra aplicación.

### Componentes anidados

Un componente anidado es un componente que se renderiza dentro de otro. Para lograrlo, picamos nuestro primer componente, el que estará anidado:


```ts
import { Component } from '@angular/core';

@Component({
  selector: 'app-nestedC',
  template: '<p>Im a nested component!</p>',
  styleUrls: ['./app.component.css']
})
export class NestedComponent { }
}
```

Y de la siguiente forma, el componente que lo recoge o anida. Por simplicidad, utilizaremos `template` en lugar de `templateUrl`. Es tan simple como añadir a su código HTML el selector del componente que queramos añadir, como puede verse en el ejemplo:

```ts
import { Component } from '@angular/core';

@Component({
  selector: 'app-first',
  template: `<div>
                <h1>First component</h1>
                <app-nestedC></app-nestedC>
            </div>`,
  styleUrls: ['./app.component.css']
})
export class FirstComponent { }
```

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

![](https://cdn-images-1.medium.com/max/1600/0*LNoIkhlqQBqvlDJk.)

## Mejorando la aplicación

* Tipado fuerte mediante interfaces
* Encapsulación de estilos
* _Lifecycle hooks_
* _Custom pipes_
* _Nested components_

### Tipado fuerte mediante interfaces

### Hooks

### Encapsulación de estilos

## _Angular routing_

Es el modo para viajar entre páginas web para hacer de nuestra aplicación un sitio interactivo y dinámico. Para enrutar, necesitaremos seguir unos cuantos pasos, empezando por crear componentes a los que viajaremos. La estructura básica de un componente es de tres ficheros: HTML, CSS y TypeScript. Todo esto podemos organizarlo en la estructura de directorios por componentes, y así localizar fácilmente nuestro código.

Para un _Component_ llamado _Start_ escribiríamos en nuestro fichero Typescript:

```ts
import { Component } from '@angular/core';

@Component({ })
export class OneComponent { }
```

Crearíamos esta estructura para cada componente que vayamos a añadir en nuestra aplicación, y ahora es momento de viajar hacia `app.module.ts`.  Allí vamos a importar algunos módulos, para comenzar el enrutamiento.

```ts
import { Routes, RouterModule } from '@angular/router';
```

Crearemos un array de `Routes`, con el que redireccionaremos a diferentes componentes dependiendo de la URL que especifiquemos en nuestro navegador. Para ello, debemos importar también los componentes que vyaamos a usar.

```ts
// Importamos los componentes que vayamos a usar
import { AppComponent } from './components/app.component';
import { StartComponent } from './components/start/start.component';
import { CharacterComponent } from './components/character/character.component';

// Creamos un array de Routes, enlazando una URL con un componente que se va a mostrar
const routes : Routes = [
    { path: "", component: StartComponent },
    { path: "story", component: StoryComponent },
    { path: "character", component: CharacterComponent },
    { path: "**", redirectTo: "" }
];

@NgModule({
  declarations: [
    AppComponent,
    StartComponent,
    CharacterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    // Añadimos esta declaración de import, además de especificar que el objeto de rounting será el array creado
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
```

Por último, modificaremos nuestro fichero `index.html` para eliminar todo el código que se haya generado automáticamente para dejar únicamente las _tags_ `<app-root>`. Después añadiremos código sobre ese fichero para complementar nuestra aplicación junto con los componentes que se irán situando sobre esa _tag_.

## Creando un servicio

Lo ideal es tener un directorio para los servicios que vayamos a crear en nuestro directorio de `app`, para organizar así nuestro código.

Las Clases que usemos como servicio llevan una notación en el nombre como convención, como ejemplo: nuestro servicio `gameController` estará en el fichero `game-controller.service.ts`.

```ts
// Imports hasta el infinito y más allá

@Injectable()
export class GameControllerService {
    constructor(private router: Router) { }
}
```

Es entonces cuando añadimos esta dependencia en el módulo sobre el que estamos operando:

```ts
@NgModule({
  declarations: [
    AppComponent,
    StartComponent,
    CharacterComponent,
    FightComponent,
    InventoryComponent,
    StoryComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [GameControllerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
```

[Ejemplo en anAdventure](https://github.com/Beelzenef/anAdventure/commit/2d28271ea549b429c6ff2df3b38cab42b5f1e03b)

## _Pipes_

Las _pipes_ son mecanismos para formatear datos, valores de variables, en nuestra aplicación. Incluso de forma dinámica.

Para nuestra clase Libro, queremos mostrar su fecha de publicación en nuestra . Las fechas son un buen ejemplo para mostrar el funcionamiento de las _pipes_, así que originalmente escribiríamos, para nuestra Clase:

```ts
pubDate = new Date(1988, 3, 15); 
```

Y en nuestro fichero HTML:

```html
<p>Esta novela se publicó en {{ pubDate }}</p>
```

El formato de la fecha es muy largo, poco legible y nada _friendly_. Usando las _pipes_ les vamos a dar un formato mucho más limpio y legible.

```html
<p>Esta novela se publicó en {{ pubDate | date }}</p>
```

Las _pipes_ pueden concatenarse, existen de varios tipos e incluso pueden parametrizarse:

```html
<p>Esta novela se publicó en {{ pubDate | date:"MM/dd/yy" }}</p>
<p>Me costó {{ price | currency:'USD':'symbol':'1.2-2'}
```

Hay muchos tipos de _pipes_, algunas definidas por el sistema y otras que podemos definir en nuestro código. Las _built-in_ son, entre otras, _lowercase_, _uppercase_, _date_, _currency_, _json_ (muy útil para _debugging_), _slice_...

También es posible crear nuestras propias _pipes_. En un nuevo fichero, que seguirá la convención de `nombrePipe.pipe.ts`, escribiremos:

```ts
import { Pipe } from '@angular/core';

@Pipe({ name: 'nombrePipe' })

explort class nombrePipe implements PipeTransform { 
  // Implementación del código de la interfaz
  transform(value: string, character: string) : string {
    return;
  }
}
```

Escribiendo este código también añadiremos en el camino el `import` que es necesario. Para poder compartir esta _pipe_, crearemos este fichero TS en el directorio `shared`, y lo añadiremos en nuestro módulo, dentro del array de `declarations`:

```ts
import { NombrePipe } from './shared/nombre-pipe.pipe'

@NgModule({
  declarations: [
    AppComponent,
    ...
    NombrePipe 
  ],
...
```


[Sigue leyendo en Angular.io](https://angular.io/guide/pipes)

No existen _pipes_ de filtrado o de ordenación, y [en la documentación de Angular nos explican el por qué. Debido a que ofrecen mala _performance_, no se proveen para desarrollar](https://angular.io/guide/pipes#appendix-no-filterpipe-or-orderbypipe).

### Enlaces útiles

* [Arquitectura de Angular](https://angular.io/guide/architecture)
* [Hammer.js, _gestures_ en nuestras aplicaciones](https://github.com/hammerjs/hammer.js/)
* [Angular + Electron](https://alligator.io/angular/electron/)
* [¿Cómo hacer _deploy_ de nuestra app Angular en GitHub Pages?](https://alligator.io/angular/deploying-angular-app-github-pages/)
* [Angular + ASP.NET Core](https://medium.com/@levifuller/building-an-angular-application-with-asp-net-core-in-visual-studio-2017-visualized-f4b163830eaa)

---
#### [Volver a inicio](../README.md)
#### ← [Inicio ASP.NET Core](intro.md)
