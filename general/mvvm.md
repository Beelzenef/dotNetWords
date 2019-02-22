# _MVVM (Model View ViewModel)_

Es el patrón recomendado para todas las plataformas que usan XAML. Consta de tres partes:

* Vistas
* Modelos
* _ViewModels_ o Modelos de la Vista

![MVC](https://cdn-images-1.medium.com/max/1600/1*BpxMFh7DdX0_hqX6ABkDgw.png)

Estos tres elementos pueden definirse como:

* La Vista es la interfaz del usuario en nuestra aplicación.
* Los Modelos son Clases que representan el dominio de la aplicación.
* El _ViewModel_ es una abstracción de la Vista, exponiendo propiedes o Comandos para comunicarse con la Vista, adapta un Modelo para que lo use la Vista.

## Ventajas

* Desacoplamiento
* Facilidades para _unit tests_
* Mejora para mantenimiento de código
* Aplicaciones más consistentes
* Reutilización del código

Podemos crear, si estamos convirtiendo nuestro proyecto a MVVM, la siguiente estructura de directorios:

* Models
* ViewModels
* Views
* Converters

En nuestra aplicación ficticia `Bookis`, donde puedes listar todos esos libros que quieres leer pero nunca tendrás oportunidad para hacerlo, empezamos a modelar

ViewModel para la Clase `Book`, donde tenemos como propiedades un título, una fecha de publicación, un género... de entre varios géneros a elegir.

Añadiremos las propiedades adecuadas además de la lista de géneros a elegir.

```cs
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Bookis.Core.ViewModel {
    public class BookDetailViewModel : NotificationObject {

        private string title;
        public string Title {
            get { return title; }
            set {
                if (title == value) return;
                title = value;
                OnPropertyChanged();
            }
        }

        private DateTime pubDate;
        public DateTime PubDate {
            get { return pubDate; }
            set {
                if (pubDate == value) return;
                pubDate = value;
                OnPropertyChanged();
            }
        }

        private string genre;
        public string Genre {
            get { return genre; }
            set {
                if (genre == value) return;
                genre = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<string> genres;
        public ObservableCollection<string> Genres {
            get { return genres; }
            set {
                if (genres == value) return;
                genres = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectGenreCommand { get; set; }
        public ICommand AddBookCommand { get; set; }

        public BookDetailViewModel() {
            Genres = new ObservableCollection<string>(new[] {
                "Terror", "Fantasía", "YA", "Ciencia ficción"
            });
        }
    }
}
```

La Vista, junto a `commands`, se detallaría así:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:viewModel="clr-namespace:Bookis.Core.ViewModel;assembly=Bookis.Core"
             x:Class="Bookis.Core.BookDetailView"
             Title="Nuevo libro">
<ContentPage.Resources>
    <ResourceDictionary>
        <viewModels:BookDetailViewModel x:Key="BookDetailViewModel"/>
  </ResourceDictionary>
</ContentPage.Resources>
  
  <Grid Margin="10" BindingContext="{Bindig Source={StaticResource BookDetailViewModel}}">
    <Grid.RowDefinitions>
        <RowDefinition/>
      <RowDefinition Height="Auto"/>
    </Grid.RowDefinitions>

    <StackLayout>
        <Label Text="Titulo"/>
            <Entry Text="{Binding Title, Mode=TwoWay}"/>
            <Label Text="Fecha de publicacion"/>
            <DatePicker Date="{Binding PubDate, Mode=TwoWay}"/>
            <Label Text="Género"/>
            <Grid>
              <Grid.ColumnDefinitions>
                <ColumnDefinition/>
                <ColumnDefinition Width="Auto"/>
          </Grid.ColumnDefinitions>
          <Label Text="{Binding Genre}" />
          <Button Grid.Column="1" Text="..." Command="{Binding SelectGenreCommand}"/>
      </Grid>
    </StackLayout>
    <Button Text="Añadir" Grid.Row="1" Command="{Binding AddBookCommand}"/>
  </Grid>
</ContentPage>
```

---

### [Volver a inicio](../README.md)