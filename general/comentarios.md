# Comentarios

Documentar el código es importante. Puedes hacerlo en forma de comentarios, donde se explica qué tiene un método, que realiza y qué devuelve. Puedes usar en línea o multilínea, depende de ti.

```cs
// Comentarios de una línea

/*
Comentarios multilinea
Porque YOLO
*/
```

En la programación existen corrientes de pensamiento que predican que usar comentarios está MAL, es FEO, te hace MALA PERSONA. ¿Por qué? Porque el código se tiene que autodocumentar, los nombres de variables, propiedades métodos y Clases se han de autodescribir.

Autodocumentar el código es una práctica ideal, es lo que se espera de un programador que quiere o en un futuro podrá trabajar en equipo. Pero eso no significa que los comentarios están prohibidos.

## Documentando elementos

Una foma de comentar el código eficientemente es añadir un documentación en código a un método o en una Clase. No es como comentar una sola línea, si no añadir información para que, cuando importemos nuestra Clase a otro proyecto, cargue consigo esos valiosos datos sobre nuestra creación.
¿Cómo hacerlo?

En Visual Studio, una vez creado el método o la Clase en cuestión, escribir tres *slashes* seguidos (///) en la línea directamente superior a la declaración del elemento.
Instantáneamente se creará esta estructura.

```cs
/// <summary>
///
/// </summary>
static void Probando() {
  ...
}
```

Dentro de las etiquetas XML ```<summary>``` debe ir el resumen, la explicación del método Probando(). Si creamos nuevas líneas de estos comentarios de documentación, y abrimos una nueva etiqueta (escribiendo <) podemos añadir otras etiquetas, como por ejemplo ```<returns>```, para explicar qué devuelve el método.
