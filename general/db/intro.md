Bases de datos
==============

Un sistema gestor de base de datos (SGDB o DBMS) es uun programa que gestiona una colección de datos relacionados y programas que acceden a los datos.

La colección de datos en cuestión es una base de datos.

Un SGBD resuelve y presta los siguientes servicios:

*   Creación y definición de bases de datos
    
*   Manipulación de datos
    
*   Acceso controlado a los datos
    
*   Integridad y consistencia de datos
    
*   Acceso compartido a la base de datos
    
*   Mecanismo de respaldo y recuperación de datos
    
*   Mantener el catálogo
    
*   Permitir actualizaciones
    

Niveles de abstracción:

|Nivel||
|---|---|
|Usuarios   | Nivel de vista  |
|Nivel externo o de visión|Nivel lógico|
|Nivel conceptual (tablas) |   |
|Nivel interno o físico|Nivel físico|

Con sistemas gestores de datos se evita:

*   Redundancia de información sin saber cuál es válida
    
*   Inconsistencia o ambigüedad de los datos
    
*   Dependencia físico lógica de los datos
    
*   Dificultad para acceder a los datos (de forma concurrente)
    
*   Separación y aislamiento de los datos
    
*   Problemas con seguridad de los datos
    
*   Problemas en la integridad de los datos
    
*   Dependencia de ficheros con lenguaje de programación
    

Modelo relacional
=================

La esencia de este modelo son las tablas, en contraposición de las conexiones entre entidades que se daban en el modelo entidad-relación. Toda relación tiene un nombre, atributos en lugar de propiedades y tuplas como filas de datos, registros.

Se representa por una tabla bidimensional, para buscar celdas en la especificación de atributos y tuplas.

Los atributos de las relaciones se definen sobre dominios de valores homogéneos y atómicos.

Restricciones inherentes del sistema relacional:

*   En una relación, no puede haber dos tuplas idénticas. Obligatoriedad de clave primaria.
    
*   El orden de las tuplas es irrelevante, dada la teoría de conjuntos.
    
*   Cada atributo puede tomar un único valor sobre el dominio en el que está definido. Unicidad del valor de atributo.
    
*   Ningún atributo que forma parte de la clave puede tomar valor nulo. Integridad de entidad.
    

Restricciones semánticas del sistema relacional:

*   Clave primaria (PK): Declara atributo o conjunto de ellos para identificar de forma unívoca cada tupla. Garantiza el orden físico de tuplas.
    
*   Unicidad (UNIQUE): define la posibilidad de tener claves alternativas.
    
*   Obligatoriedad (NOT NULL): Permite definiir si un atributo debe tener siempre o no un valor.
    
*   Clave ajena (FK): Define el concepto de integridad referencial, y define un atributo o conjunto de ellos en una relación que deben corresponder a los valores de la clave primaria con el que tiene conexión en una entidad. Admite valores nulos.
    

Las claves ajenas afectan a más de una tabla, por lo que sus modificaciones o eliminaciones tendrán consecuencias. Para controlarlas, existen especificaciones.

Siempre se observa de cardinalidad 1 a N:

*   En CASCADA, los cambios se propagan en todas las ocurrencias.Las eliminaciones en CASCADA son peligrosas, pues también se propagan. En las dependencias de entidades, en cualquiera de sus formas, es aceptable usar la eliminación o borrado en cascada. De lo contrario, su uso requiere de un estudio y planificación.
    
*   En RESTRICT es imposible modificar la clave de la tabla referenciada siempre que haya tuplas en la tabla que hace referencia. Las modificaciones restringidas son útiles cuando una tabla está probada, más que establecida y no necesita cambio alguno. Para borrar en RESTRICT es necesario borrar todos los registros de la tabla que referencia.
    
*   En SET NULL, con modificacione sy borrados, todos los atributos referencia pasan a ser NULL.
    
*   En SET DEFAULT, con modificaciones y borrados, todos los atributos referencia pasan a ser el valor especificado por defecto. Esos valores pueden dar más información.
    
*   Verificación (CHECK): Sirve para establecer una condición que deben cumplir uno o más atributos o más atributos en la relación (por ejemplo, rango de fechas)
    
*   Aserciones (ASSERTION): Sirve como CHECKs, para establecer condiciones que afectan a atributos en diferentes tablas. Es difícil encontrar esa utilidad en los SGBD actuales, y en ocasiones habrá que picar código para controlarlas.
    
*   Disparadores (TRIGGERS): Es código ejecutable cuando se cumple una determinada condición sobre un determinado evento en una determinada tabla. Pueden ser BEFORE o AFTER sobre las acciones de INSERT, UPDATE o DELETE.
    

Transformación de elementos al modelo relacional

*   Entidades, atributos y dominios
    
*   Atributos multivaluados
    
*   Relaciones
    
*   Jerarquías
    
*   Dependencias
    
*   Exclusión y exclusividad
    
*   Entidades reflexivas
    

Normalización
-------------

Es el proceso de eliminar inconsistencias y redundancias, persiguiendo el principio ACID, reduciendo las tablas al mínimo.

ACID: Atomiticy, Consistency, Isolation, Durability

Existen hasta 5 formas normales, que se engloban hasta la última de ellas. Por lo general, solo se llega hasta la Forma Normal de Boyce Codd (FNBC). Con un buen modelo entidad-relación, bien migrado a modelo relacional, nos encontramos directamente en 2FN.

Es más eficiente trabajar con menos columnas, a menos columnas mucho mejor.

La normalización está pensada para organizar información ya existente pero caótica o no organizada. Se debe conservar TODA la información, así como los atributos, las dependencias, los registros en forma de tuplas… con un orden optimizado.

**1FN**: Cada columna, cada casilla, de las tablas ha de ser atómica.

Hemos de descubrir los atributos multivaluados ocultos, que se esconden a simple vista. Pueden ser los autores de un libro, pueden ser las múltiples páginas web de una empresa… y deberán ser tratados como elementos para una nueva tabla. En ocasiones también será interesante separar campos que normalmente irían unidos. Es necesario detectar y atomizar los atributos que serán claros filtros de búsqueda.

### Dependencias funcionales

Son las dependencias entre atributos. Es la detección de qué atributo depende de qué atributo, elementos que no siempre son claros y que las casualidades nos llevan a error. El concepto a modelar nos dará claridad para detectar las dependencias funcionales.

Representaremos X e Y, donde Y tiene dependencia funcional de X, X determina Y, X implica Y, teniendo un valor de X siempre encontraremos el mismo valor de Y.

Ahora es donde entra en juego el análisis de dependencias, en la que se han de buscar qué atributos determinan otros atributos. Es decir, para un mismo valor de un atributo, encontraré siempre los mismos resultados en los que son determinados por el primero.

La dependencia funcional completa es cuando X como determinante es un conjunto de atributos y la dependencia se da con la totalidad de los atributos, y no con un subconjunto de ellos.

**2FN**: todos los atributos dependen de la clave, tienen una dependencia funcional completa con la clave.

Dependencia funcional transitiva:

**3FN**: se da cuando todos los atributos no claves dependen de la totalidad de la clave de forma no transitiva.

**FNBC**: se da cuando está en 3FN y cada dependencia funcional tiene a la clave como determinante, siendo la clave único determinante en la relación. Está en FNBC cuando tiene varias claves y ninguna de ellas es compuesta, o cuando tiene varias claves y no están solapadas.

4FN:

5FN:

Anomalías

*   Anomalía de actualización: cambiar ID de cliente en un mismo pedido, ahora, ¿cual es el válido?
    
*   Anomalía de inserción: insertar datos arbitrarios sin ningún control, rompiendo la coherencia de datos.
    
*   Anomalía de borrado: perder información válida que además es la única referencia existente de un valor concreto.
    

SQL, mySQL, mariaDB...
======================

¿Qué es SQL?
------------

SQL es el estándar, pero hay diversos forks (MySQL, Oracle) que se adaptan y siguen sus reglas. Con este lenguaje lanzamos consultas a las bases de datos usando el sistema gestor de bases de datos como intermediarios.

SQL: Structured Query Language

Las bases de datos relacionales son el origen de SQL. Años 70. System R, un sistema gestor de base de datos creado por IBM, no comercial, que trajo consigo la creación de un lenguaje llamado SEQUEL. Este lenguaje es el antecesor de SQL. Pero no fue IBM quien explotó comercialmente este lenguaje, si no Oracle, en 1979, presenta la primera implementación comercial de SQL.

SQL pasa a ser de uso común para la gestión de bases de datos cuando ANSI, en 1986, lo estandariza. Nace SQL-86, o SQL1. Y después, estandarizado a nivel internacional por ISO.

Pero el mercado se fue propagando, desde la creación de mySQL hasta la creación de mariaDB, que usaremos actualmente.

Desde el cliente, accedemos a la base en mySQL o mariaDB a través de la nube con un cliente de mySQL, que en el caso de hostGator es libmysql 5.1 (algunas versiones por detrás de la versión estable más reciente). Conexiones remotas a mySQL no recomendadas a menos que sea un túnel seguro como una VPN.

CPanel es la joya de la corona a la hora de gestionar servicios web: bases de datos, seguridad, sistemas gestores de contenido… con unos pocos clics.

phpMyAdmin es el cliente estrella a la hora de gestionar bases de datos a través de la web.

¿Por qué usar mariaDB?
----------------------

*   Open source, colaboración constante y directa
    
*   Creado por los padres de mySQL
    
*   El servidor de base de datos relacionales más popular
    
*   Es rápido, escalable y robusto
    
*   Un ecosistema rápido para almacenar engines, con plugins y otras muchas herramientas que hacen de este sistema muy versátil para múltiples casos de uso.
    

Ver las versión de tu sistema en Linux Mint:

\> cat /etc/linuxmit/info

Directorios de utilidad en GNU/Linux:

*   bin, ejecutables generales
    
*   sbin, ejecutables exclusivos del superuser
    
*   etc, archivos de configuración
    
*   home, directorios de usuarios
    
*   mnt, puntos de montaje para acceder a sistemas de ficheros añadidos
    
*   boot, arranque del sistema, hogar del kernel
    
*   dev, dispositivos enganchados, hardware
    
*   usr, programas de usuario instalados
    

En /etc/apt/sources.list encontramos la lista de localizaciones donde el sistema encuentra los paquetes para su actualización, y en el directorio sources.list.d encontraremos más direcciones más específicas para programas varios.

La combinación de teclas ALT + F2 ejecuta un lanzador de aplicaciones en tu sistema.

mySQL y mariaDB son productos del mismo creador, Monty, que recibieron nombre por sus dos hijas. Después de vender mySQL y ver cómo se iba a privatizar, decidió crear mariaDB para que fuera libre, completo y con pocas compatibilidades con mySQL. 

Nos desvinculamos de la UI porque es más profesional, es más cercano al mundo real, porque la UI es un valioso recurso innecesario en la realidad.

Es clave el paradigma cliente-servidor.

El puerto 3306 es un socket, un lugar de conexión, un puerto para recibir conexiones. WKP son los que los servicios usuales que se promocionan y los que usan los usuarios normalmente. Se han de establecer para acceder a servicios remotos. Necesitaremos una IP y un socket para poder acceder a una conexión remota. Si no se especifica y aún así llegamos, es porque se ha especificado por defecto el puerto 80. Google en concreo, utiliza el puerto 8080, al que redirecciona automáticamente a cada búsqueda para garantizar la privacidad de las búsquedas que se realizan desde su engine de búsquedas.

Para instalar un paquete DEB descargado y fuera de los repositorios:

\> sudo dpkg -i (nombrePaquete)

No son paquetes seguros aquellos que no están en repositorios, nadie garantiza la integridad del paquete descargado. Por eso, la instalación de software está restringida en ámbitos de empresa, por motivos de localización de errores y control.

Instalando el servidor de mariadB:

\> sudo apt-cache show mariadb-

Nos mostrará los paquetes disponibles si tabulamos. Ahí encontraremos tanto el cliente como el servidor, incluso las versiones de test. Cuando no se especifican versiones, es posible que sea un alias con el que encontramos la versión más actual.

Para comprobar la legitimidad de un paquete descargado, podemos descargar un paquete de una página oficial y nos ofrecerá una firma md5. Una vez descargado, ejecutamos:

\> md5sum (nombrePaquete)

… y ambas firmas deberían coincidir, mostrando que es auténtico, que la información coincide y nuestra descarga es segura (si confiamos en el origen de la descarga, no así con Google, que es el MAL).

mySQL por parte del cliente necesitará un socket en el puerto 3306.

Para comprobar si el servidor mySQL está corriendo:

\> ps ax | grep mysql

Comprobando que el equipo funciona como punto de red, para actuar como servidor:

\> ifconfig> ping localhost

Comprobar la red en cuanto a servicios:

\> netstat -ant

Si no aparece el puerto 3306, no hay un socket habilitado, por lo que no se puede acceder a la base de datos. En empresa, se habilitan en IPTables reglas para que solo ciertas IPs se pueden conectar a la base de datos.

Puerto 53 es DNS por defecto.

Si todo sigue fallando, es cuestión de permisos. ¿Tengo la contraseña adecuada? ¿He configurado adecuadamente el sistema?

En mySQL siempre se determina el usuario y la máquina desde la que llega o intenta conectarse.

\> mysql -u root -p -h localhost -P3306

El comando -p obliga a pedir la contraseña después de pulsar ENTER, por motivos de seguridad.

De cambiar la contraseña de un usuario sin invocar a la función password() a la hora de especificar la contraseña, fallará cualquier intento de logueo con esa contraseña en claro. ¿Por qué? Porque al introducir la contraseña en un logeo, esta se encripta y se compara con la contraseña ya encriptada que se encuentra en el diccionario de datos.

La función password() no utiliza el mejor algoritmo de encriptación para contraseñas, pero los administradores profesionales de mySQL no le dan mucha importancia. El motivo es que, si el invasor ha llegado al diccionario de datos como para descubrir la encriptación usada, ya es demasiado tarde, pues ya tiene toda la información de TODA la base de datos.