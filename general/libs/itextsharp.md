# iTextSharp

Usando [Xam.iTextSharpLGPLv2](https://github.com/Sim-github/Xam.iTextSharpLGPLv2)

¡Código usable en Xamarin Forms!

```cs
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

public Stream GeneratePdf(Stream imageStream)
{
    using (MemoryStream ms = new MemoryStream())
    {
        Document doc = new Document(PageSize.A4);
        PdfWriter writer = PdfWriter.GetInstance(doc, ms);

        doc.AddTitle("some title");
        doc.Open();

        // add text
        Paragraph paragraph = new Paragraph();

        Font someFont = new Font(Font.COURIER, 9f);

        Phrase phrase = new Phrase();
        Chunk chunk = new Chunk("some text", someFont);
        phrase.Add(chunk);

        paragraph.Add(phrase);

        doc.Add(paragraph);

        // adding image
        Image image = Image.GetInstance(imageStream);
        Image
            .SetAbsolutePosition((PageSize.A4.Width - image.ScaledWidth) / 2,
            (PageSize.A4.Height - image.ScaledHeight) / 2);
        doc.Add(image);

        doc.Close();
        writer.Close();

        return ms;
    }
}
```

## Enlaces importantes

* [Working with images in Mikesdotnetting](https://www.mikesdotnetting.com/article/87/itextsharp-working-with-images)
* [Adding text with chunks, phrases and paragraphs](https://www.mikesdotnetting.com/article/82/itextsharp-adding-text-with-chunks-phrases-and-paragraphs)
* [center image in pdf using itextsharp](https://stackoverflow.com/a/39161476)
