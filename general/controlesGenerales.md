# Controles generales

## TextBox

Para un TextBox que solo admita números, basta con anular la propagación del evento PreviewTextInput. El código se traduce en:

```cs
private void textBoxX_PreviewTextInput(object sender, TextCompositionEventArgs e)
{
    if (!char.IsDigit(e.Text, e.Text.Length - 1))
        e.Handled = true;
}
```
