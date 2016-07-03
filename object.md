# Todo hereda de Object

En C#, todo (o casi todo) es una Clase. La herencia es fundamental, es vital para conocer las Clases y lo que podemos hacer con ellas.

“Y los hijos de Rubén fueron Hanok y Palú.
Y los hijos de Hanok fueron Simeón y Ohad.
Y los hijos de Simeón fueron Hebrón y Uziel”

Nos hemos ido a la Biblia (o algo parecido) para ver una jerarquía de padres e hijos, y podemos adivinar que al final de esa línea, el último de todos esos hijos tendría un gran patrimonio y una buena herencia a causa de todo lo que tuvieron sus antepasados, ¿no? En C#, pasa algo parecido.

Mientras que el primero tendría apenas unas pocas pertenencias, el último es poseedor de grandes y múltiples cosas.

La Clase Object es la Clase madre, es LA CLASE. Todas las Clases creadas y que vayas a crear, heredarán de Object.

### ¿Qué tiene la Clase Object?

Unos pocos miembros que es importante conocer:

* ToString()
* GetType()
* Equals()

A medida que vamos descendiendo en jerarquía de herencia, las Clases que quedan más abajo tienen más y más miembros, más herencia que dejar a otras Clases, por lo que las funcionalidades se expanden. Y siempre, siempre vas a tener estos pocos miembros disponibles porque son los básicos, y a menudo muy útiles.

Durante mi experiencia, la Clase ToString() ha sido especialmente útil, pues te permite convertir tipos en una cadena de texto para mostrar por consola o cualquier otro uso.
