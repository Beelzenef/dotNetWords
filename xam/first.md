# Primera app

Saludando al _user_ y haciendo una pregunta, con código en XAML y en C#. Cuando declars un control o _view_ en XAML, puedes acceder al mismo sin necesidad de "inicializarlo". Ya es detectado, considerado por el IDE para que puedas

En XAML:

```xml
<StackLayout>
        <Label 
           x:Name="lbl_Answer"
           Text="Welcome to Xamarin.Forms!" 
           HorizontalOptions="Center"
           VerticalOptions="CenterAndExpand" />
        <Button Text="Press me!" Clicked="btnDisplay_Click"/>
    </StackLayout>
```

En C#:

```cs
    private async void btnDisplay_Click(object sender, System.EventArgs e)
        {
            var answer = await DisplayAlert("Key question", "Do you like Xam.Forms?", "Yay!", "Nope");
            lbl_Answer.Text = answer ? "yay!" : "not that much...";
        }
```

---
#### [Volver a inicio](../README.md)
#### ← [Introducción Xamarin](intro.md)