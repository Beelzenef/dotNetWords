# Angular

Es un _framework_ para el desarrollo de aplicaciones web y de escritorio. Encuentra más información en [su sitio web](https://angular.io/). Encuentra ejemplos commit a commit en [mi GitHub](https://github.com/Beelzenef/anAdventure).

## Instalación de NodeJS

Descarga versión LTS desde [la web](https://nodejs.org/es/).

Comprueba su funcionamiento desde la terminal:

Comprueba la instalación de NodeJS con:

`> node -v`

Comprueba la instalación de NPM con:

`> npm -v`

## Instalación de AngularCLI

Desde la terminal, para instalar:

`> npm install -g @angular/cli`

Creando una nueva aplicación con Angular:

`> ng new myFancyApp`

"Sirviendo" la app, haciendo que cualquier cambio se aplique en "caliente", sin necesidad de recargar el navegador:

`> cd myFancyApp`

`> ng serve`

Por defecto, necesitarás acceder a la aplicación desde [http://localhost:4200](http://localhost:4200), aunque también puedes elegir servir la aplicación desde otro puerto:

`> ng serve --port 4201`

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

En el proyecto creado, puedes encontrar módulos, como `src/app/app.module.ts`.

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

Son los fragmentos o páginas en nuestra aplicación.

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
* `templateUrl`: ¿dónde se va a insertar la lógica que escribamos para este componente?
* `styleUrls`: una lista o _array_ donde se buscarán los estilos a aplicar para el componente. Los estilos que se listan en este decorador solo se añaden a la aplicación cuando el componente está renderizado, por lo que no tiene por qué interferir con otros estilos de otros componentes.

También podemos añadir:

* `providers`: un _array_ de servicios e inyecciones que solo estarán disponibles para componentes específicos, y no para todo el módulo.

En el cuerpo de la Clase que tenemos, añadiremos variables, propiedades, funciones... todo lo que necesitemos para nuestra aplicación.

## _DataBinding_

### _Interpollation_

Es el modo más sencillo de hacer _dataBinding_ en nuestra aplicación. Se puede apreciar en nuestro componente inicial, al ver cómo nuestra variable `title`, que da nombre a la aplicación desde TS, se referencia y aplica en nuestro fichero HTML con `{{ title }}`. Es sencillo pero no permite mucha interactuación con el usuario.

#### _Expression context_

¿Qué ocurre si no es una variable con valor único, si es un _array_? Angular permite operar con datos que son listas en bucles que podemos declarar en nuestro código. Si declaramos un array en nuestro componente con TypeScript:

```ts
names : string[] = [
    "Name1", "Name2", "Name3"
  ]
```

... en nuestro fichero HTML podemos recorrerlo como si de un bucle FOREACH se tratase:

```html
<ul>
    <li *ngFor="let item of names">
      {{item}}
    </li>
</ul>
```

### _Template statements_

Esos elementos no solo se pueden listar, si no que podemos asociarles eventos como el `click()`. En nuestra lista de elementos en HTML, añadiremos una sentencia donde el evento `click()` será tratado en un método llamado `clickando()`, que recibirá el elemento de la lista que estemos pulsando.

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

### _Data-binding two-way_

Es posible hacer _data binding_ de forma bidireccional. Para comprobar de forma sencilla, enlazaremos la variable del título de nuestra aplicación con una caja de texto, un `input` de tipo texto.

Para ello, modificaremos el módulo del componente con el que trabajamos para añadir una dependiencia, `FormsModule`.

```ts
import { FormsModule } from '@angular/forms'

...

  imports: [
    BrowserModule,
    FormsModule
```

Una vez añadido, podemos añadir a nuestro fichero HTML la sintaxis para _bindear_ la variable `title` con la caja de texto. Si modificamos su contenido en la aplicación, comprobaremos que el títuloque se muestra en nuestra aplicación se cambia a tiempo real.

```ts
<input type="text" [(ngModel)]="title"/>
```

## _Angular routing_

Es el modo para viajar entre páginas web para hacer de nuestra aplicación un sitio interactivo y dinámico. Para enrutar, necesitaremos seguir unos cuantos pasos, empezando por crear componentes a los que viajaremos. La estructura básica de un componente es de tres ficheros: HTML, CSS y TypeScript. Todo esto podemos organizarlo en la estructura de directorios por componentes, y así localizar fácilmente nuestro código.

Para un _Component_ llamado _Start_ escribiríamos en nuestro fichero Typescript:

```ts
import { Component } from '@angular/core';

@Component({

})
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

### Enlaces útiles

* [Arquitectura de Angular](https://angular.io/guide/architecture)
* [Hammer.js, _gestures_ en nuestras aplicaciones](https://github.com/hammerjs/hammer.js/)
* [Angular + Electron](https://alligator.io/angular/electron/)
* [¿Cómo hacer _deploy_ de nuestra app Angular en GitHub Pages?](https://alligator.io/angular/deploying-angular-app-github-pages/)
* [Angular + ASP.NET Core](https://medium.com/@levifuller/building-an-angular-application-with-asp-net-core-in-visual-studio-2017-visualized-f4b163830eaa)

---
#### [Volver a inicio](../README.md)
#### ← [Inicio ASP.NET Core](intro.md)