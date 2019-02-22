# Creando ListView

## Estructura MVC

Crearemos directorios para:

* Views
* Data
* Models
* ViewModels

### Modelo y fuente de datos

En Models, creamos la Clase con la que vamos a operar de base:

```cs
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}
```

En Data, crea una lista de este `Model` que has creado:

```cs
using XSM.Models;

namespace XSM.Data
{
    class BookData
    {
        public List<Book> Books = new List<Book>
        {
            new Book { Title = "Eragon", Author = "C. Paolini" },
            new Book { Title = "La sombra del viento", Author = "C. Ruiz Zafón" },
            new Book { Title = "Sesión nocturna", Author = "M. Connelly" },
            new Book { Title = "La maldición del nigromante", Author = "M. Wells" }
        };
    }
}
```

En `ViewModels`, crea el `ViewModel`, desde donde accederás a los datos:

```cs
class BookViewModel
{
        private ObservableCollection<Book> _books;

         public ObservableCollection<Book> Books
        {
            get { return _books; }
            set
            {
                if (value != _books)
                {
                    _books = value;
                }
            }
        }

         public BookViewModel()
        {
            Books = new ObservableCollection<Book>();

             BookData _context = new BookData();
            _context.Books.ToList().ForEach(Books.Add);
        }

    }
```

### Creando vistas

En Views, crea una nueva View que reciba el nombre con la convención de _Page_. Si operamos con Book, será `BookPage`.

Añade el código que inserta una `ListView`, especifica una fuente de datos en `ItemSource`. Después, en `ItemTemplate`, tratamos cada elemento de la lista de datos de forma específica. ¿Cómo mostraremos y donde (si es que lo hacemos) cada campo de esa Clase que es nuestro modelo?

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="XSM.Views.BookPage"
             Title="Your dream book list">
    <ContentPage.Content>
        <ListView ItemsSource="{Binding Books}"
                  BackgroundColor="White"
                  SeparatorVisibility="Default"
                  HorizontalOptions="FillAndExpand"
                  VerticalOptions="FillAndExpand"
                  HasUnevenRows="True">

             <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <StackLayout Margin="6,4"
                                     BackgroundColor="GhostWhite">
                            <Label Text="{Binding Title}"
                                   Margin="8"
                                   FontAttributes="Bold"
                                   FontSize="Medium"/>
                            <Label Text="{Binding Author}"
                                   Margin="8, 2, 8, 4"
                                   FontSize="Small"/>
                        </StackLayout>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>

         </ListView>
    </ContentPage.Content>
</ContentPage>
```

Con la `View` que has creado, se añadirá la Clase parcial en C#, y es aquí donde espeificas el `BindingContext`, el origen de los datos que hemos creado en `ViewModel`:

```cs
public partial class BookPage : ContentPage
{
        public BookPage()
        {
            InitializeComponent();
            BindingContext = new BookViewModel();
        }
}
```

### Mostrando Page

No te olvides de cambiar, si es tu primera página, la _page_ que se va a mostrar en la Clase `App.`

```cs
public App()
{
    InitializeComponent();

    MainPage = new BookPage();
}

```

---

Puedes ver este código, en un solo _commit_, en [mi proyecto en XSM](https://github.com/Beelzenef/XSM/commit/1a27b92bdbf1b6ce7c7ff7fe3856656d43f9fe2e).

---

#### [Volver a inicio](../README.md)

#### ← [Introducción Xamarin](intro.md)