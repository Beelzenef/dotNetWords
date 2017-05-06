# Recordando a Windows Forms

Si, como es mi caso, llegas a WPF después de haber aprendido el arte de Windows Forms... esta sección es para ti.

La búsqueda de equivalencias es algo natural, es como finalmente nos adaptamos a nuevos entornos. Pero entre WPF y Windows Forms no siempre es posible. Pero no todo está perdido, ¡busca tu equivalencia perdida y sigue programando! 

## OpenFileDialog

Esta Clase ya no representa a un control que abre un cuadro de diálogo en el cual nos deja buscar un fichero concreto. Ahora es una Clase final que necesita de sus miembros de instancia para conseguir el mismo efecto.

Para inicializar un OpenFileDialog necesitaremos de un namespace en particular:

```cs
using Microsoft.Win32;
```

Y si estamos trabajando con ficheros, probablemente necesitaremos también a System.IO.

Pero vamos a crear nuestra instancia de OpenFileDialog, que puede estar inicializada en, por ejemplo, el lanzamiento de la interfaz gráfica. Podemos especificar un filtro para el fichero, y así poder seleccionar solo los que se ajusten a esa extensión. Para evitar errores en el futuro, especifica siempre un filtro de ficheros. Para ficheros de texto, en extensión TXT: 

```cs
OpenFileDialog buscadorFicheros = new OpenFileDialog();
buscadorFicheros.Filter = "Ficheros de texto (*.txt)|*.txt";
```

Ahora solo tendremos a nuestro alcance ficheros de texto.

Queda la duda. ¿Cómo lanzar la ventana de diálogo para la búsqueda? Mediante la invocación del método ShowDialog(). Es un método que puede devolver tres valores: *true*, *false* o *null*. Es por eso que ante su invocación, necesitaremos comparar con *true* cuando la operación ha tenido éxito.

Si hemos seleccionado un fichero, se carga sobre la Propiedad FileName la ruta al fichero que hemos seleccionado. Podemos cargarla sobre una variable de tipo *string* o directamente operar con ella, por ejemplo, con las Clases IO.

```cs
string rutaFicheroABuscar = string.Emtpy;
string textoFichero = string.Empty;

if (buscadorFicheros.ShowDialog() == true)
{
  rutaFicheroABuscar = buscadorFicheros.FileName;
  textoFichero = File.ReadAllText(rutaFicheroABuscar);
}
```

Este código puede ir, por ejemplo, en el evento Click de un botón. Estaríamos simulando entonces ese control desaparecido que era OpenFileDialog.

Algunos filtros útiles:

```cs
"Ficheros de texto (*.txt)|*.txt|Todos (*.*)|*.*";
"JPGs (*.jpg)|*.jpg|PNGs (*.png)|*.png";
"Todos (*.*)|*.*";
"Ficheros de texto (*.txt)|*.txt";
"JPGs (*.jpg)|*.jpg";
```

## DatePicker

El control de errores es algo fundamental. Y con la introducción de fechas es algo habitual. ¿Por qué no evitarlo entonces? Puedes hacerlo con un control que te ofrezca un calendario para elegir una fecha existente, válida.

En Windows Forms, era DateTimePicker. En WPF, tenemos [DatePicker](https://msdn.microsoft.com/es-es/library/system.windows.controls.datepicker(v=vs.110).aspx).

Tanto en XAML como en C#, podemos especificar los valores de diferentes miembros.

* DisplayDate, Propiedad que obtiene o establece un DateTime con la fecha mostrada en el control
* SelectedDate, Propiedad que obtiene o establece la fecha seleccionada en el calendario como un DateTime
* CalendarStyle
* FirstDayOfWeek

Un ejemplo para instancia y cambio para la Propiedad de SelectedDate:

```cs
DatePicker dpFecha = new DatePicker();
dpFecha.SelectedDate = DateTime.Today;
```
