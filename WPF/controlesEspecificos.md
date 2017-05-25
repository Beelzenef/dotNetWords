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
