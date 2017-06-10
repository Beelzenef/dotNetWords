// Listas

List<int> listaNumeros = new List<int>();

listaNumeros.Add(1);
listaNumeros.Add(2);
listaNumeros.Add(10);

Console.WriteLine(listaNumeros.Count);
// Devolverá 3

listaNumeros.Remove(2);
// Se eliminará el número 2

listaNumeros.RemoveAt(1);
// Se eliminará el número 10

Console.WriteLine(listaNumeros.Count);
// Devolverá 1

listaNumeros.Clear();
Console.WriteLine(listaNumeros.Count);
// Devolverá 0

// List de tipo complejo

List<Personaje> listaPersonajes = new List<Personaje>();

listaPersonajes.Add(new Personaje("Ethan Thross", 14));
listaPersonajes.Add(new Personaje("Tirsa Ventar", 11));

Console.WriteLine(listaPersonajes[1].Nombre);
// Se escribirá el nombre "Tirsa Ventar"
