# Navegando por la aplicación

## _Angular routing_

Es el modo para viajar entre páginas web para hacer de nuestra aplicación un sitio interactivo y dinámico. Para enrutar, necesitaremos seguir unos cuantos pasos, empezando por crear componentes a los que viajaremos. La estructura básica de un componente es de tres ficheros: HTML, CSS y TypeScript. Todo esto podemos organizarlo en la estructura de directorios por componentes, y así localizar fácilmente nuestro código.

El _routing_ se basa en componentes, pues identificamos los componentes como _targets_ u objetivos del enrutamiento.

Para hacer _routing_, necesitaremos añadir `RouterModule` al _array_ de importaciones de nuestro módulo.

```ts
import { Routes, RouterModule } from '@angular/router';
```

Para un _Component_ llamado _Start_ escribiríamos en nuestro fichero Typescript:

```ts
import { Component } from '@angular/core';

@Component({ })
export class OneComponent { }
```

Una vez hayamos creado la estructura de navegación (hacia dónde y desde dónde navegamos), es el momento de crear el mapa de navegación. Crearemos un array de `routes` o rutas, con el que redireccionaremos a diferentes componentes dependiendo de la URL que especifiquemos en nuestro navegador.

El orden en el que especifiquemos estas rutas a las que navegar importa, pues se busca la primera coincidencia en la que encaje nuestra ruta para navegar a ella.

Una vez listo, volvemos al módulo que estamos editando, importando también los componentes que vayamos a usar.

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

También podemos especificarlo como:

```ts
RouterModule.forRoot([
    { path: "", component: StartComponent },
    { path: "story", component: StoryComponent },
    { path: "character/:id", component: CharacterComponent },
    { path: "**", redirectTo: "" }
], { useHash: true });
```

La sección de useHash es opcional, si se especifica es para asignarlo a `true`, su valor es `false` por defecto. La parte de la URL que vaya detrás del `#` es ignorada, nunca se envía al servidor, y sirve para localizar secciones de la página web, como marcadores o _headers_ de secciones a destacar de la página.

Solo nos falta implementar la parte de UI, ¿cómo hacemos que un elemento, como un botón, redireccione a un componente?

Editaremos el elemento HTML que se encuentre en el componente y contendrá el siguiente código:

```html
<a [routerLink]="['/story']">
  <button>
    Take me to the story!
  </button>
</a>
```

¿Dónde se van a mostrar los componentes a los que routeamos? La etiqueta `<router-outlet></router-outlet>`, sitúa el componente invocado en su lugar.

### En resumen, proceso de _routing_

* Se activa el link de router en la UI
* Se actualiza la URL en el _browser_
* Se busca el primer _match_ en el mapa de _routes_ que hemos creado en el módulo
* Se instancia el componente asociado a esa ruta
* Se inyecta el componente en el `<router-outlet>`

### La elección: _routing_ o _nesting_

Características de _nesting_:

* Necesita de un selector
* Aninado dentro de otro componente
* No necesita _routing_

Características de _routing_:

* No necesita de un selector
* Se navega con rutas
* Asociadas a una acción

## Rutas con parámetros

Es posible que en tu mapa de _routes_ exista una con parámetros, quizás para navegar a un elemento concreto, para visualizar al detalle sus datos. ¿Cómo accedemos a ese elemento desde la aplicación?

La declaración de una _route_ con parámetro se determina de la siguiente forma:

```ts
...
{ path: "character/:id", component: CharacterComponent }
...
```

Y para determinar qué elemento HTML será el encargado de redirigirnos al componente en cuestión:

```html
<a [routerLink="['/character', character.id]">
  {{ character.name }}
</a>
```

Ahora solo nos queda obtener su id desde la ruta, en la vista donde vamos a detallar toda la instancia.

```ts
import { ActivatedRoute } from '@angular/router';

// Declaración de clase

constructor (private route: ActivatedRoute) {
  let id = +this.route.snapshot.paramMap.get('id');
}
```

Usamos `let` para definir el `scope` privado de la variable, y el operador `+this` para convertir el `string` que es el ID a la hora de recogerlo de la URL en un número con el que buscaremos los datos de la fuente de datos que estemos utilizando.

Podemos usar ActivatedRoute, si solamente consultamos una vez por este id en la ruta, u Observables, si consultamos numerosas veces con relativa frecuencia, como ocurriría si paginásemos entre los `character`s, con botones de `Next` o `Previous`.

## Añadiendo un _back button_

Para navegar hacia páginas anteriores, añadiremos un botón al componente sobre el que estamos trabajando. Operaremos sobre un evento llamado `onBack()`, al que llamaremos para activar la navegación inversa.

```ts
import { Router } from '@angular/router';

// Declaración de clase

constructor (private router: Route) { }

onBack(): void {
  this.router.navigate(['/rutaParaRetroceder']);
}
```

Y en HTML, con nuestro botón, la única diferencia será:

```html
<button (click)='onBack()'>
  Go back!
</button>
```

## _Guards_

Limitando el acceso a rutas, creando criterios de seguridad.

Existen los siguientes tipos de `Guards`:

* CanActivate
* CanActivateChild
* CanDeactivate
* CanLoad
* Resolve

Necesitaremos crear una Clase que implemente esta `Guard`. Añadirá un método que puede devolver un `boolean` según el caso, permitiendo o no el acceso a esa ruta.

Creando la `Guard`:

```ts
import { CanActivate } from '@angular/router';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class SomeComponentGuard  implements CanActivate {
  constructor (private router: Route) { }

  canActivate(): boolean {
    //
  }
}
```

¿Cómo se implementa? Volveremos a las rutas que hemos declarado en nuestra aplicación para limitar el acceso a aquella que necesitemos

```ts
RouterModule.forRoot([
    // Primeras rutas
    { path: "story", component: StoryComponent },
    { path:
      "character/:id",
      canActivate: [SomeComponentGuard]
      component: CharacterComponent },
    // Otras rutas
], { useHash: true });
```