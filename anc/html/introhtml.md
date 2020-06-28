# HTML

## Lenguajes de marcado

Los lenguajes de marcas o de marcado son lenguajes de programación no tan potentes como otros (Java, por ejemplo) y cuya representación gráfica se efectúa con marcas. Las marcas son los caracteres < y >, conteniendo en su interior un título o código., obedeciendo a la sintaxis del lenguaje en cuestión.

La herramienta para utilizar estos lenguajes de marcas son editores de texto plano. El fichero creado es interpretado por un determinado software (como un navegador que interpreta un fichero HTML).

Este tipo de lenguajes suelen terminar en una estructura de árbol, que se difiere a través de indentaciones, espaciados y slashing al final.
Necesitamos un software que funcione bien siempre, no dependiendo del lugar en que se use.

El código necesita un resultado óptimo.

El contenido dentro del fichero es la información que vamos a gestionar gracias a los lenguajes de marcas.

### Qué es HTML

HTML (lenguaje de marcado de hipertexto) que contiene la información y gestiona las páginas web. Es el fundamento de la WWW, lenguaje que viralizó los contenidos en la red.

Como lenguaje, tiene sintaxis y reglas. Es una variedad de lenguajes amplio y flexible, permitiendo gran capacidad apra compartir información, es un estándar al que todo el mundo puede acceder.

Tipos de lenguajes de marcas:

* Orientados a presentaciones. Los más comunes, ya que muestran info. WYSIWYG.
* Procedurales (presentan y realizan procedimientos (Tex, LaTex, Postscript)
* Descriptivos (HTML, XML…)

Se iniciaron en los años 60  con tal de compartir información en formato electrónico. SGML intentó establecerse como un estándar, aún con el padre de estos lenguajes, GML, creado por IBM. Se abrió el sistema de gestión de información con otras empresas. SGML era muy complejo, por ello se simplificó a HTML, que mostraba información pero no multimedia. De SGML también nació XML.

Para definir y establecer estándar,es, en los 90 se creó un consorcio, llamado W3C (World Wide Web Consortium), para software y lenguajes. En el 98, se publica el estándar del XML (eXtended Markup Language), siendo más estricto a la vez que amplio.

Las ventajas de XML son varias. Es un lenguaje extensible, es estricto pero abierto. El compilador es un estándar, que evita los bugs. Es sencillo de entender y de procesar. Mejora la compatibilidad para gestionar información entre organizaciones y sus aplicaciones.

### Qué es HTML5

HTML 5 es como su nombre indica, la versión 5 de su desarrollo.

## Escribiendo HTML5

Ahora que sabemos qué es HTML (y su quinta versión) y para qué sirve, podemos empezar a usarlo para crear nuestras páginas web.

¿Cómo lo haremos? El código HTML se escribe a través de etiquetas o *tags*. Las etiquetas tienen una funcionalidad específica.

Las etiquetas tienen una apertura y un cierre, y el texto que hay dentro es el que recibe el comportamiento definido por las etiquetas.

Hay etiquetas para:

* Escribir párrafos
* Escribir texto en negrita, itálica o subrayada
* Añadir imágenes
* Añadir enlaces

### Etiquetas

Las etiquetas tienen una apertura y un cierre, y el texto que hay dentro es el que recibe el comportamiento definido por las etiquetas.

Hay etiquetas para:

* Escribir párrafos
* Escribir texto en negrita, itálica o subrayada
* Añadir imágenes
* Añadir enlaces

Y muchas más.

### Atributos

Los atributos hacen que las etiquetas tengan funcionalidades adicionales.

Hay etiquetas que no necesitan atributos, no los usan, por lo que son opcionales. Los veremos en la práctica.

### Contenido

Es el texto que está bajo la influencia de la etiqueta y sus atributos.

El contenido de las etiquetas (en su mayoría) las hace visibles. Si añades una etiqueta sin contenido no será visible.

#### Etiquetas con autocierre

Hay etiquetas que no necesitan contenido, se abren y cierran.

## Herramientas necesarias

* Un navegador instalado en nuestro equipo
* Un editor de texto o IDE

Preferiblemente necesitaremos un IDE. Es un editor de texto con facilidades

### Primeros pasos

* Instalar nuestro IDE: Visual Studio Code
* Crear una carpeta para nuestros ejercicios
* Crear un fichero HTML

Los formatos son importantes, definen cómo va a ser y cómo se va a comportar su contenido.

Un fichero `txt` simplemente muestra texto plano, eficaz para tomar notas.

Un fichero ``html` será el formato que necesiten nuestras páginas web. Sin ese formato, no funcionarán como páginas web.

Crearemos entonces nuestro fichero `primeraweb.html`.

* Crear fichero HTML
* Abrir fichero en un navegador

No se ve nada, ¿verdad? Si lo abrimos con Visual Studio Code, tampoco veremos nada en el fichero. Ahora es cuando escribiremos nuestro código HTML para empezar a visualizar la información que queremos mostrar en web.

## Estructura mínima

```html
<!DOCTYPE html>
    <html lang="es">
        <head>
            <meta charset="UTF-8">
            <meta name="viewport" content="width=device-width, initial-scale=1.0">
            <title>Mi primera página web</title>
        </head>
        <body></body>
    </html>
```

Ahora, ¡vuelve a abrir tu fichero HTML en el navegador!

## Texto

```html
<p>Esto es un párrafo</p>
```

```html
<p>Esto es un párrafo con <b>texto bold</b></p>
```

### *Headers*

Cuando necesitamos destacar contenido, anidando por categorías, solemos usar los *headers* o titulares. También se pueden escribir en HTML.

Hay varios niveles de *headers*, igual que en un documento de texto rico:

```html
<h1>Nivel 1</h1>
<h2>Nivel 2</h2>
<h3>Nivel 3</h3>
<h4>Nivel 4</h4>
<h5>Nivel 5</h5>
<h6>Nivel 6</h6>
```

### Enlaces

Podemos añadir enlaces a nuestros:

```html
  <a href="https://reddit.com"><p>Este enlace te dirige a Reddit</p></a>
```

Estos enlaces se abrirán en la misma pestaña en la que estamos, por lo que si queremos hacer que este enlace se abra en otra pestaña, podemos añadir un nuevo atributo:

```html
  <a href="https://reddit.com" target="_blank"><p>Este enlace te dirige a Reddit</p></a>
```

## Listas

### Listas ordenadas

```html
```

### Listas desordenadas

```html
```

### Saltos de línea

```html
<br/>
```

## Contenedores generales

```html
<div></div>
```

```html
<span></span>
```

### Secciones especiales

```html
<header></header>
```

```html
<main></main>
```

```html
<footer></footer>
```

```html
<nav></nav>
```

```html
<aside></aside>
```

```html
<article></article>
```

### Tablas

```html
```

### Formularios

```html
```

### Imágenes

```html
```

### Vídeo

```html
```

## Más herramientas

### Accesibilidad

```html
```

### SEO

```html
```

## *Developer tools*

Las herramientas de *developers* son las que están accesibles desde un navegador y nos permite visualizar y editar el código HTML y CSS que ejecutamos.

Cada navegador tiene sus propias herramientas de *developer*, pero tienen un funcionamiento común que es muy útil.

El contenido que editamos en las *dev tools* no es permanente.
