# Controles generales

## Button

Es el control básico en todo programa, la forma de interacción más básica con el usuario. Es lo que se llama *content control*, un control que puede tener contenido en su interior. Ya puede ser texto u otro elemento como contenido básico.

Existen tres formas de definir un botón...

* Un botón que tiene contenido definido como un atributo:

```xaml
<Button Content="¡Púlsame!"/>
```

* Un botón con texto plano definido como contenido:

```xaml
<Button>
    ¡Pulsame!
</Button>
```

* Un botón que tiene como contenido otro control, en este caso una imagen:

```xaml
<Button>
    <Image Source Source="imagenDeBoton.png"/>
</Button>
```

## Label

El control `Label` o etiqueta es tan simple como una región de la aplicación donde se suele colocar un texto, probablemente informativo.

```xaml
<Label Content="Informando al usuario..."/>
```

Suele tener poca interacción, pues no está orientado a operaciones directas con el usuario. Podemos cambiar sus colores de fondo y de letra, con algunas propiedades:

```xaml
<Label Content="Texto blanco sobre fondo negro" Background="Black" Foreground="White"/>
```

## TextBox

Para un TextBox que solo admita números, basta con anular la propagación del evento PreviewTextInput. El código se traduce en:

```cs
private void textBoxX_PreviewTextInput(object sender, TextCompositionEventArgs e)
{
    if (!char.IsDigit(e.Text, e.Text.Length - 1))
        e.Handled = true;
}
```
