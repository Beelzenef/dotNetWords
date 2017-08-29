# Contenedores

Los contenedores son los elementos que recibirán en su interior los controles de nuestra aplicación. Por defecto, la aplicación se iniciará con un único contenedor, de tipo Grid, que conoremos más adelante. Si lo eliminas, no podrás hacer más que añadir un único control en tu aplicación.

Necesitarás un contenedor principal, pudiendo este contener otros contenedores en su interior. También puedes cambiarlo a cualquiera de tu preferencia, hasta conseguir la interfaz gráfica que desees.

## StackPanel

El StackPanel es un contenedor que apila de forma automática los controles que se colocan en su interior. Por defecto, lo hace en horizontal, pero esto puede ser cambiado.

Un StackPanel que está vacío:

```xaml
<StackPanel></StackPanel>
```

Un StackPanel que apila dos botones en su interior:

```xaml
<StackPanel>
    <Button Content="Un boton" Margin="5"/>
    <Button Content="Otro boton" Margin="5"/>
</StackPanel>
```

Un StackPanel que apila dos botones en horizontal:

```xaml
<StackPanel Orientation="Horizontal">
    <Button Content="Un boton" Margin="5"/>
    <Button Content="Otro boton" Margin="5"/>
</StackPanel>
```

## Grid

Es un panel, el más poderoso de WPF, por su flexibilidad que nos permite cualquier distribución. Está organizado en filas y columnas. Se considera innecesario otros paneles, pero ayudan a diferentes tareas. La joya de la corona. La intersección de filas y columnas es una celda, que puede ser considerada otro contenedor. Sus dimensiones se equilibrarán a partir del espacio disponible.

Para crear una rejilla hay que definir el número de celdas, que se define con número de filas y de columnas. Es una rejilla orientada a la distribución, por lo que no muestra sus líneas.

Un Grid que está vacío:

```xaml
<Grid></Grid>
```

Un Grid que tiene dos columnas y una fila:

```xaml
<Grid>
    <Grid.ColumnDefinitions>
        <ColumnDefinition/>
        <ColumnDefinition/>
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition/>
    </Grid.RowDefinitions>
</Grid>
```

## DockPanel

DockPanel es otro contenedor que tiene la particularidad de que apila todo de forma horizontal, haciendo *wrap* con los mismos como un procesador de texto hace con las palabras cuando llega al límite de la página.

Un DockPanel vacío:

```xaml
<DockPanel></DockPanel>
```

Un DockPanel con dos botones:

```xaml
<DockPanel>
    <Button Content="Un boton" Margin="5"/>
    <Button Content="Otro boton" Margin="5"/>
</DockPanel>
```

## WrapPanel

Es un panel que agrupa los controles de izquierda a derecha y de arriba a abajo. Por defecto, empieza a introducir controles arriba a la izquierda y sigue añadiendo en la estructura del lenguaje occidental.

Su propiedad Orientation me permite cambiar la orientación, empezando a agrupar en vertical en lugar de horizontal.

Dependiendo de las dimensiones de su contenido, irá distribuyendo de la forma más óptima aunque puede haber desaprovechamiento del espacio. Cuando la distribución está en horizontal y hay un número elemento superior a los que caben, los últimos elementos añadidos no se ven.

Un WrapPanel vacío:

```xaml
<WrapPanel></WrapPanel>
```

Un WrapPanel con dos botones:

```xaml
<WrapPanel>
    <Button Content="Un boton" Margin="5"/>
    <Button Content="Otro boton" Margin="5"/>
</WrapPanel>
```

Un WrapPanel con dos botones y orientación horizontal:

```xaml
<WrapPanel Orientation="Horizontal">
    <Button Content="Un boton" Margin="5"/>
    <Button Content="Otro boton" Margin="5"/>
</WrapPanel>
```

## Canvas

Un panel o contenedor que sirve para gestionar la distribución de forma absoluta de los controles que contiene. Se utiliza coordenada o posición absoluta, y necesita compararlo con algún punto del Canvas en el cual se encuentra. Para esto utiliza los nombres de Left, Top, Bottom, Right.

Un Canvas vacío:

```xaml
<Canvas></Canvas>
```

Un Canvas con un botón en una posición determinada con respecto al Canvas en el cual se ha definido, usando posiciones `Top` y `Left`:

```xaml
<Canvas>
    <Button Content="Un boton" Canvas.Left="40" Canvas.Top="31" Width="63" Height="41"/>
</Canvas>
```
