# Estructuras

Las estructuras, o structs como se conocen en C# y como las llamaremos a partir de ahora, son las hermanas pequeñas de las Clases. Parecidas pero diferentes entre sí.
Conociendo las estructuras, conoceremos más sobre las Clases para un futuro muy próximo.

Es una estructura de datos, una ficha, una hoja a rellenar que, a diferencia de las Clases, no permite la herencia y otras características de la OOP. Si no necesitamos usar la herencia en nuestros proyectos y los datos que manejamos son pocos, podemos instanciar estructuras.

¿Cómo se declara?

```cs
struct Libro
{
  int nPaginasTotales;
  int nPaginasRestantes;
  string titulo;

  string LeerPaginas(int paginasLeidas)
  {
    int nPaginasRestantes = nPaginasTotales - paginasLeidas;
    return “Te quedan “ + nPaginasRestantes + “ por leer...“;
  }

  public Libro(string titulillo, int paginas)
  {
  	nPaginasTotales = paginas;
  	titulo = titulillo;
  }
}
```

¿Qué puede tener?

Campos, métodos, constructores sobrecargados…

¿Cómo usar ese constructor sobrecargado, que asigna un título y un número de páginas a la par?

```cs
Libro librete = new Libro(“La mitad oscura”, 100);
```

A partir de ahora, podemos usar nuestra instancia de Libro, “librete”, para cambiar el título o el número de páginas, e incluso notificar nuestro progreso en la lectura.

¿Queremos cambiar el autor, para hacer el ejemplo? Entonces:

```cs
librete.titulo = "Cementerio de animales";
```

Necesitamos tener en cuenta, a la hora de crear una Estructura o Struct (y veremos que también para las Clases), también creas un constructor vacío. Un constructor que no recibe parámetros, que puedes usar libremente. Cuando creas un nuevo constructor, con parámetros, el constructor vacío se destruye. Entonces, si lo sigues necesitando a pesar de tener el que recibe parámetros, has de escribir el constructor vacío, sin parámetros, para poder usarlo.
