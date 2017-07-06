# Más controles

## Menús

### Menú

Un menú es una barra de herramientas que aparecerá, por defecto, en la parte superior del contenedor en el cual se ha especificado

```xml
<Menu>
  <MenuItem Header="Archivo"/>
  <MenuItem Header="Cerrar aplicación"/>
</Menu>
```

Incluso los items de un menú pueden contener sus propios items:

```xml
<Menu>
  <MenuItem Header="Archivo">
      <MenuItem Header="Guardar"/>
      <MenuItem Header="Abrir nuevo"/>
  </MenuItem>
  <MenuItem Header="Cerrar aplicación"/>
</Menu>
```

El elemento ```<Separator>``` crea una línea visual divisoria entre los diferentes items, que nos pueden ayudar a diferenciar las diversas funcionalidades existentes en nuestro menú.

### Menú contextual

El menú contextual es similar al anterior, pero con la particularidad de que aparece al hacer click derecho sobre el control que lo tiene definido. Como su nombre indica, depende del contexto.

Puede ser escrito en toda la ventana que se está ejecutando, sobre un textbox, sobre un botón... y solo aparecerá cuando se clickee sobre ese control. Usan las propiedades de dependencia del control sobre el que se definen para ser creados.

Como ejemplo, sobre toda la ventana:

```xml
<Window.ContextMenu>
  <ContextMenu>
    <MenuItem Header="Cerrar ventana"/>
    <Separator/>
    <MenuItem Header="Minimizar"/>
  </ContextMenu>
</Window.ContextMenu/>
```

Sobre un botón:

```xml
<Button.ContextMenu>
  <ContextMenu>
    <MenuItem Header="Cerrar ventana"/>
    <Separator
    <MenuItem Header="Minimizar"/>
  </ContextMenu>
</Button.ContextMenu/>
```
## CheckBox

El control de `CheckBox` es aquel que nos permite marcar una casilla con un texto asociado.

```xml
 <CheckBox>Me gusta leer</CheckBox>
```
Cuando inicia la aplicación, algunas de las opciones necesitan estar marcadas. Una opción habilitada por defecto. Para especificarlo, acudiremos a la Propiedad `IsChecked` que admite valores *booleanos*.

```xml
 <CheckBox IsChecked="True">Me gusta la ciencia ficción</CheckBox>
```
Este control también permite una particularidad que se conoce como tercer estado o *third state*. Hemos comentado que admite valores *booleanos*, pero también valores `null`. Es un estado indeterminado, ni marcado ni sin marcar. Podemos interpretarlo como el estado que tiene este control cuando todavía no ha recibido ninguna operación, nunca ha sido cambiado de valor.

Se marca con la Propiedad `IsThreeState`, que se marca como *booleano* a su vez. Así, puede tener el tercer estado, y podrá tomar valores `null`. Como en el ejemplo:
```xml
 <CheckBox IsThreeState="True" IsChecked="{x:Null}">Me gusta la ciencia ficción</CheckBox>
```
El valor de la Propiedad `IsChecked` es diferente. Está entre `{}` y además muestra una sintaxis adicional. Significa que es un valor interpretable por el sistema, no se toma como un literal. Los valores `null` se especifican de este modo en WPF.
