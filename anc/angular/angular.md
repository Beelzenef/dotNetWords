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

## Sigue leyendo

* [Módulos y componentes](components.md)
* [_Databinds_ directivas y más](databinds.md)
* [Servicios y _pipes_](services.md)
* [_Routing_ y navegación por la aplicación](routing.md)
* [Mejorando la aplicación](hooks.md)

### Enlaces útiles

* [Arquitectura de Angular](https://angular.io/guide/architecture)
* [Hammer.js, _gestures_ en nuestras aplicaciones](https://github.com/hammerjs/hammer.js/)
* [Angular + Electron](https://alligator.io/angular/electron/)
* [¿Cómo hacer _deploy_ de nuestra app Angular en GitHub Pages?](https://alligator.io/angular/deploying-angular-app-github-pages/)
* [Angular + ASP.NET Core](https://medium.com/@levifuller/building-an-angular-application-with-asp-net-core-in-visual-studio-2017-visualized-f4b163830eaa)

---

#### [Volver a inicio](../../README.md)

#### ← [Inicio ASP.NET Core](../intro.md)
