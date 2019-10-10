# `ViewModel`s

El paradigma de programación basado en ViewModels, propio de aplicaciones XAML como ocurre en Xamarin y en WPF, consiste en la separación total del código de la vista y del modelo.

Se elimina también el _code behind_, o código que opera detrás de la vista. Este _code behind_ introduce lógica de negocio en las clases de la vista, por lo que necesitaremos eliminarlo.

Los ViewModels se basan en Propiedades que se representan en la vista, y son las que modificamos para obtener nuestra lógica de negocio.

Los cambios en estas Propiedades deben ser recogidos, escuchados, para poder actualizar las vistas y, por supuesto, almacenar esa información debidamente.

Basándonos en la interfaz `INotifyPropertyChanged`, creamos una Clase base de la cual nuestros ViewModels van a heredar... haciendo posible "escuchar" los cambios en las Propiedades que tendremos en nuestros ViewModels.

```cs
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
```

Con esta Clase heredada, podemos crear nuestros ViewModels que devuelvan datos y que, cuando cambien, ¡estos cambios se notifiquen!

```cs
    class ProjectsViewModel : BaseViewModel
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        // more properties and code!
    }
```

La vista asociada a ese ViewModel, puede entonces usar estas Propiedades a través del lenguaje XAML.

Haciendo `binding` a la propiedad, estaremos al tanto del valor inicial y de todos los cambios que sucedan sobre esa ella.

```xml
    <Entry Text="{Binding Title}" />
```

---

## [Volver a inicio](../README.md)
