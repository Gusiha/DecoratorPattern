using Aspose.Words;

namespace DecoratorPattern
{
    internal class DocumentFacade : IDocumentFacade
    {

        public Document ChangeStyleToOfficial(string path, SaveFormat saveFormat)
        {
            Document mainDoc = new Document(path);
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            Style style = doc.Styles.Add(StyleType.Paragraph, "MyStyle1");

            style.Font.Size = 36;
            style.Font.Name = "Times New Roman";
            style.Font.Bold = true;

            builder.ParagraphFormat.Style = style;
            builder.Write(mainDoc.GetText());

            
            builder.Document.Save($"NewDoc.{saveFormat}", saveFormat);

            return doc;
        }


        public Document Convert(string path, SaveFormat saveFormat)
        {
            Document doc = new Document(path);

            doc.Save($"Wow.{saveFormat}", saveFormat);

            return doc;
        }
    }
}
