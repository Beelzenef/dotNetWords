# Servicios y _pipes_

## Creando un servicio

Un servicio es una Clase que tiene un propósito concreto, y que además: es independiente de cualquier componente, encapsula interacciones externas a los componentes y provee de una lógica o datos que se comparten por toda la aplicación.

Registrar servicios en Angular consiste en crear `Singletons`, es decir, instancias únicas que son accesibles desde cualquier parte de la aplicación. Y para ello los inyectamos.

Las dependencias de servicios, y las inyecciones para los mismos, se especifican en los constructores de los componentes que los vayan a utilizar.

Lo ideal es tener un directorio para los servicios que vayamos a crear en nuestro directorio de `app`, para organizar así nuestro código.

Las Clases que usemos como servicio llevan una notación en el nombre como convención, como ejemplo:

```ts
// Imports hasta el infinito y más allá

@Injectable()
export class NewService { }
```

Podemos ver en nuestro servicio `gameController` estará en el fichero `game-controller.service.ts`.

```ts
@Injectable()
export class GameControllerService {
    constructor(private router: Router) { }
}
```

Podemos inyectar servicios a nivel de componente, donde sólo será accesible desde el mismo, y teniendo que repetir el proceso cada vez que necesitemos ese servicio. Si seguimos este método, tendremos que añadir la dependencia en el módulo sobre el que estamos operando:

```ts
@NgModule({
  declarations: [
    ...
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [NewService],
  bootstrap: [AppComponent]
})
export class AppModule { }
```

... y después inyectar en el constructor del componente.

[Ejemplo en anAdventure](https://github.com/Beelzenef/anAdventure/commit/2d28271ea549b429c6ff2df3b38cab42b5f1e03b)

Este escenario no siempre es el ideal, por eso podemos crear, como recomendación desde Angular 6, un registro de servicio a nivel global. Para registrar a nivel global simplemente tendremos que:

```ts
@Injectable({ providedIn: 'root' })
export class NewService { }
```

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
<p>Me costó {{ price | currency:'USD':'symbol':'1.2-2' }}
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

No existen _pipes_ de filtrado o de ordenación, y [en la documentación de Angular nos explican el por qué. Debido a que ofrecen mala _performance_, no se proveen para desarrollar este tipo de componentes](https://angular.io/guide/pipes#appendix-no-filterpipe-or-orderbypipe).

---
