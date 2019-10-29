# Módulos y componentes

## Módulos en Angular

En el proyecto creado, puedes encontrar módulos, como `src/app/app.module.ts`. Es la forma en la que se organiza la aplicación, de forma modular en unidades lógicas.

![Modules](https://pbs.twimg.com/media/CvGgsTAWAAIfvNA.jpg)

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

Todos los componentes tienen un selector, una etiqueta en un fichero HTML en la cual se van a inyectar. El primer componente de nuestra aplicación, por defecto es `<app-root>`. La aplicación que se genera por defecto en Angular, 'Tour of Heros', incluye más código además del selector de este componente. Podemos eliminarlo y dejar únicamente el selector, para comenzar la aventura en Angular.

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

Un componente solo se puede anidar si:

* su _template_ solo maneja un fragmento de una vista mayor.
* tiene un selector
* se comunica con su contenedor

### Comunicación entre componentes anidados: `Input` y `Output`

Para comunicar dos componentes que forman una estructura contenedor-anidado, usamos el decorador `@Input`, con el que podremos recibir en un componente datos de su contenedor.

Para utilizar este decorador, modifica una propiedad en el componente anidado para especificar:

```ts
@Input() propiedadComunicada: string;
```

Y en el contenedor haremos referencia a esta propiedad que acabamos de modificar, desde el mismo punto donde añadimos el selector del componente anidado:

```html
<div>
  <h1>First component</h1>
  <app-nestedC [propiedadComunicada]='modelo.cualquierValor'>
    </app-nestedC>
</div>
```

Para que el componente anidado responda a los valores que se le asignan en cada llamada, es necesario acudir al ciclo de vida de la aplicación, y añadir el evento de `onChanges()`:

```ts
export class NestedComponent implements OnChanges {
  
  @Component({
    // elementos de un componente
  })
  ngOnChanges(): void {
    // código a ejecutar cuando
    // se perciben cambios
  }
}
```
