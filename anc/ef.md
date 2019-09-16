# EntityFramework

Un ORM para ecosistema .NET.

Crear un proyecto desde terminal...

`> dotnet new mvc --auth Individual -o NombreProyecto`

... pone a nuestro alcance muchas herramientas de gestión de base de datos. Con la creación, ya tenemos una base de datos, `app.db`, y también instalado [EntityFramework Core](https://docs.microsoft.com/es-es/ef/core/index). También hay una Clase que hará de contexto para nuestra base de datos, `ApplicationDbContext.cs`, y la configuración para acceder a la misma en `appsettings.json`.

En la Clase de contexto es donde escribiremos el código que nos permitirá acceder a las tablas.

## _Code First_ y _Database First_

Son dos acercamientos, _approaches_ diferentes con sus propias ventajas y desventajas, dependiendo de las necesidades del proyecto se elegirá uno u otro.

## Declaración de entidades

### `DataAnnotations`

Declaración de una entidad con `DataAnnotations`:

```cs
class Rulebook : Entity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name  { get; set; }
        public int Pages  { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
```

### `FluentAPI`

Declaración de dos entidades, en una relación OneToOne:

```cs
    class Rulebook : Entity
    {
        public int Id {get; set; }
        public string Name  { get; set; }
        public int Pages  { get; set; }

        public int DiceId { get; set; }
        public Dice Dice { get; set; }
    }

    class Dice : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sides { get; set; }

        public int RulebookId { get; set; }
        public Rulebook { get; set; }
    }

```

¿Cómo se crean sus relaciones en FluentAPI?

```cs
    modelBuilder.Entity<Rulebook>()

        .HasKey(rb => rb.Id)
        .Property(rb => rb.Name).IsRequired()

        .HasOne<Dice>(rb => rb.Dice)
        .WithOne(dice => dice.Rulebook)
        .HasForeignKey<Dice>(dice => dice.RulebookId);
```

Declaración de dos entidades, en una relación OneToMany:

```cs
    class Rulebook : Entity
    {
        public int Id {get; set; }
        public string Name  { get; set; }
        public int Pages  { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }

    class Author : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Rulebook> Rulebooks { get; set; }
    }
```

¿Cómo se crean sus relaciones en FluentAPI?

```cs
    modelBuilder.Entity<Rulebook>()

        .HasKey(rb => rb.Id)
        .Property(rb => rb.Name).IsRequired()

        .HasRequired<Author>(rb => rb.Author)
        .WithMany(a => a.Rulebooks)
        .HasForeignKey<int>(rb => rb.AuthorId);
```


### Más que leer

[Code first migrations in team environements](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/migrations/teams). Si vas a leer esto, prepárate un café porque es largo (recomendación de Microsoft).

---

## [Volver a inicio](../README.md)

## ← [Inicio ASP.NET Core](intro.md)
