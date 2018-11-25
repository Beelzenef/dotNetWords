# Angular

Es un _framework_ para el desarrollo de aplicaciones web y de escritorio. Encuentra más información en [su sitio web](https://angular.io/).

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

## Angular routing

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

### Interpellation

Es el modo más sencillo de hacer _dataBinding_ en nuestra aplicación. Se puede apreciar en nuestro componente inicial, al ver cómo nuestra variable `title`, que da nombre a la aplicación desde TS, se referencia y aplica en nuestro fichero HTML con `{{ title }}`. Es sencillo pero no permite mucha interactuación con el usuario.

¿Qué ocurre si no es una variable con valor único, si es un _array_? Angular permite interactuar con datos en forma de lista. En nuestro fichero HTML, una vez 

En TypeScript:

```ts
names : string[] = [
    "Name1", "Name2", "Name3"
  ]
```

En HTML:

```html
<ul>
    <li *ngFor="let item of names">
      {{item}}
    </li>
</ul>
```