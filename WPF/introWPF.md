# Windows Presentation Foundation

Windows Presentation Foundation o WPF es un nuevo paradigma, un nuevo patrón para crear potentes aplicaciones con código mínimo. El único código que no falla es el que no existe, y en eso nos basaremos.

El concepto de *zero code-behind* establece la escritura de cero código en C# más allá de la creación de un modelo de datos y la escritura mínima en XAML para la creación de interfaces.

La conexión con modelos de datos en XML o MySQL es posible y sencilla, pudiendo incluso sincronizar los almacenenes de datos (controles, como cajas de texto) y los datos en los dispositivos físicos (bases de datos en discos duros) de forma unidireccional o bidireccional.

A tener en cuenta para elegir WPF:

* Una nueva disposición del IDE:

La disposición ideal del IDE depende, como siempre, de gustos y/o necesidades. La pantalla partida de forma horizontal permite navegar de forma sencilla en el codigo XAML para ver cómo la interfaz gráfica cambia en tiempo real. Si sientes que te falta espacio en horizontal... no temas en saltar de línea para seguir añadiendo atributos al elemento XML con el que estés operando. No solo será más cómodo a la hora de visualizarlo, y así evitar cambios constantes, si no que te puede ayudar a tener criterios y ordenación de los atributos.

![](https://www.intersoftsolutions.com/Support/PremierStudio/Tutorial/images/WebUIExistingWPF1.png)

* XAML simplifica el código:

El desarrollo de GUIs es muy sencillo. A través de código XAML y con la ayuda de Visual Studio, puedes crear interfaces con modificaciones a tiempo real sin la necesidad de levantar las manos del teclado.

Una interfaz sencilla, con un control de lista y un botón, se reduce a esto.

```xaml
<Window x:Class="WpfApplication1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Titulo de ventana" Height="350" Width="525">
    <StackPanel>
        <GroupBox Header="Lista de películas">
            <ListBox Name="lsb_ListaPeliculas" Height="100"/>
        </GroupBox>
        <Button Name="btn_AnadirPelicula" Content="Nueva película" Width="80"/>
    </StackPanel>
</Window>
```

* _Data binding_
* Nuevas Clases
