# Random (using System;)

Genera números pseudoaleatorios. Es una Clase final, no estática, necesitarás crear una instancia de la misma.

Tiene más de un constructor, que permiten tener una semilla generada a raíz del tiempo del sistema o a raíz de un entero. La semilla se ha de hacer fuera del método en el que se vaya a usar de modo que no se genere siempre el mismo número.
Los máximos que se especifican en los parámetros de cada método suelen estar excluidos. Para obtener letras, hacer casting de Char.

Si tienes la misma semilla, obtendras el mismo resultado.
A pesar de lo pseudoaleatorio, se pueden usar para estadísticas reales. La semilla no es la generación, y es la filosofía de la aleatoriedad en cualquier lenguaje de programación.

## Métodos

* Next(): devuelve un entero aleatorio positivo
* Next(X): devuelve un entero aleatorio positivo menor y no igual al número especificado como parámetro
* Next(X, Y): devuelve un entero positivo entre los dos rangos, con el máximo excluido

[Clase Random (MSDN)](https://msdn.microsoft.com/es-es/library/system.random(v=vs.110).aspx)
