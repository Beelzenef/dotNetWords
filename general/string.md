# Clase String

Un string, una cadena de texto, es una colección, una lista estática de caracteres. No permite la inserción directa a través de sus índices, por ser estática, pues son de solo lectura.
Es posible insertar o reemplazar caracteres en la instancia de la Clase String a través de los métodos con los que cuenta.
Reúne caracteres de tipo UNICODE, con 16 bits por tanto.

Esta Clase tiene una serie de constructores, aunque podamos usar el alias ya conocido.

```cs
string s1 = new String(“Hola”);

string s2 = new String ();

char[] cadenaChars = ‘h’, ‘o’, ‘l’ , ‘a’;
string s3 = new String(cadenaChars);
```

Propiedades

* Length, que es la longitud de la cadena de texto en cuestión. Como cuenta el número de los caracteres, los espacios aunque sean al inicio y/o al final, también se cuentan.

Métodos de la Clase String, algunos de ellos estáticos y otros no, la documentación dará la información que necesitas.	

* Compare(): Comparando dos strings por su contenido, sobrecargado.
* CompareTo(): Compara la instancia actual con otra instancia. Sólo se pasa el string a comparar.
* EndsWith(): Comprueba si un string está contenido al final de un string
* StartWith(): Comprueba si un string está contenido al final de un string
* IndexOf(): Devuelve al index donde coincide la posición de primera ocurrencia del string que se da como parámetro.
* LastIndexOf(): Devuelve el index donde coincide por última vez el string()
* Concat(): Une el index donde coincide por última vez el string
* CopyTo(): Copia un substring. Sobrecargado.
* Insert(): Inserta un substring en otro string en la posición indicada. Crea un nuevo string con la inserción creada sin afectar al original.
* Join(): Construye un string basado en substrings y añadiendo un separador (que puede ser cualquier carácter)
* PadLeft(): Añade caracteres a la izquierda para llegar a una longitud especificada.
* PadRight(): Añade caracteres a la derecha para llegar a una longitud especificada.
* Remove(); Elimina caracteres de un string, sobrecargado.
* Replace(): Reemplaza caracteres o un substring en las posiciones indicadas de un string
* Split(): Devuelve un array de string obtenidas a partir de un array de char con todas las palabras. Es posible elegir el separador. Sobrecargado.
* Substring(): Extrae un string de otro string. Sobrecargado.
* ToLower(); Convierte en minúsculas
* ToUpper(): Convierte en mayúsculas
* Trim(): Elimina todos los caracteres que se le indican, al inicio del string y al final del mismo. Sobrecargado. Sin sobrecarga, elimina todos los espacios.
* TrimEnd(): Elimina espacios al final.
* TrimStart(): Elimina espacios al inicio.
* Format(): Aplica formatos a strings. Hay muchos formatos a conocer, y que ampliaremos en el futuro.

Usando un método no estático, de instancia:

```cs
string nombre = “Jupiter.   “;

nombre.TrimEnd();
```

Y se eliminarán los espacios que haya al final, mostrando:

> Jupiter.

Aunque usemos el alias de la Clase, sigue siendo una instancia de la misma.

Hay muchos otros miembros que aquí no se explican, incluso algunos de ellos que se señalan como sobrecargados. La Clase String es amplia, y el mejor modo para conocerla es acudir a la [documentación oficial](https://msdn.microsoft.com/es-es/library/system.string(v=vs.110).aspx).
