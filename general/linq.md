# LINQ

Language Integrated Query (Lenguaje integrado para consultas) define un rango de operadores estándar para consultas que recibir exactamente los datos que pides de una forma declarativa. Puedes pedir información de bases de datos SQL Server, ficheros XML, data sets de ADO.NET…

Puedes pedir datos de cualquier fuente que implemente la interfaz IEnumerable.

La sintaxis de cualquier consulta es:

```cs
from <variable names> in <data source> select <variable names>
```

Con LINQ, puedes consultar datos usando métodos anónimos y forzar la ejecución de la consulta para sobreescribir el comportamiento por defecto de las consultas.

Ejemplo:

```cs
IQueryable<Employee> emps = from e in Employeesselect e;
```

El tipo de dato que se devuelve, en este caso, es un `IQueryable<Employee>`, por lo que te permite iterar a través de los datos que has recibido.

## Filtrando datos por filas

El siguiente código te muestra como se usan los filtros para obtener resultados más específicos, como en el caso de un apellido concreto entre los empleados.

```cs
// Using a where Clause
string _LastName = "Prescott";
IQueryable<Employee> emps = from e in Employeeswhere e.LastName == _LastName
select e;
```

Leyendo datos desde una base de datos usando LINQ, siguiendo el ejemplo de [Picazo en YouTube](https://www.youtube.com/watch?v=tQpWByvqT0Y), podemos leer y obtener datos de una lista de usuarios:

```cs
using (context db = new NewAppContext)) {
    var userList = db.Users.Where(u => u.Email == "anemail@aserver.net").toList();

    foreach (var user in userList) {
        Console.WriteLine(user.Name);
    }
}
```

## Filtrando datos por columnas

Se pueden seleccionar datos concretos de un elemento a consultar.

```cs
// Using a New Class to Return a Subset of Columns
private class FullName
{
    public string Forename { get; set; }
    public string Surname { get; set; }
}
private void FilteringDataByColumn()
{
    IQueryable<FullName> names = from e in Employees
        select new FullName { Forename = e.FirstName, Surname = e.LastName };
}
```

Jugando con los resultados, que se pueden recorrer mediante un bucle FOREACH

```cs
// Accessing the Returned Data
foreach (var emp in emps)
{
    Console.WriteLine("{0} {1}", emp.FirstName, emp.LastName);
}
```

## Agrupando datos por un campo concreto

Agregando datos, mediante una función que cuenta los elementos en la consulta mediante la selección realizada

```cs
// Using a group Clause with an Aggregate Function
var emps = from e in Employees
    group e by e.JobTitle into eGroup
    select new { Job = eGroup.Key, CountOfEmployees = eGroup.Count() };
```

## Navegando por los datos

```cs
// Using Dot Notation to Navigate Related Entities
var emps = from e in Employees
select new
{
    FirstName = e.FirstName, LastName = e.LastName, Job = e.JobTitle1.Job
};
```

## Joining

Puedes usar las consultas JOIN para obtener datos de diferentes fuentes. Existen tres tipos de JOIN: inner, group y left outer.

Las fuentes de datos que van a unirse necesitan un elemento en común para que puedan ser comparadas. Al plantearse de forma semejante a las bases de datos relacionales, ese elemento común bien puede ser el elemento ID.

### Inner JOIN

```cs
var innerJoinQuery =
    from order in orders
    join prod in products on category.ID equals prod.CategoryID
    select new { ProductName = prod.Name, Category = category.Name };
```

### Group JOIN

```cs
var innerGroupJoinQuery =
    from category in categories
    join prod in products on category.ID equals prod.CategoryID into prodGroup
    select new { CategoryName = category.Name, Products = prodGroup };
```

Esta consulta produce un resultado jerárquico de asociación de los elementos de la segunda tabla, con uno o más elementos coincidentes a la derecha.
Devuelve un array. Si no se encuentran coincidencias, producirá un array vacío.

### Left Outer JOIN

Todos los eleentos de la izquierda se devuelven, incluso si no tiene elementos coincidentes con la tabla de la derecha.

```cs
var leftOuterJoinQuery =
    from category in categories
    join prod in products on category.ID equals prod.CategoryID into prodGroup
    from item in prodGroup.DefaultIf Empty(new Product { Name = String.Empty, CategoryID = 0 })
    select new { CatName = category.Name, ProdName = item.Name };
```

## Enlaces útiles

* [Aplicando LINQ a `DbSets<Type>`](https://www.learnentityframeworkcore.com/dbset/querying-data)

---

### [Volver a inicio](../README.md)
