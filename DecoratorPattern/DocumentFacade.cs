using Aspose.Words;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class DocumentFacade : IDocumentFacade
    {
        Document MainDoc { get; set; }

        public DocumentFacade(string path)
        {
            MainDoc= new Document(path);
        }

        public Document ChangeStyleToOfficial(Document document)
        {
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            Style style = doc.Styles.Add(StyleType.Paragraph, "MyStyle1");

            style.Font.Size= 32;
            style.Font.Name = "Times New Roman";
            style.Font.Bold = true;

            builder.Document.Save("Разнообразный и богатый опыт повышение уровня гражданского сознания требует от нас системного анализа существующих финансовых и административных условий.docx");
            return doc;
        }

        public Document ChangeStyleToOfficial()
        {
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            Style style = doc.Styles.Add(StyleType.Paragraph, "MyStyle1");

            style.Font.Size = 32;
            style.Font.Name = "Times New Roman";
            style.Font.Bold = true;

            builder.ParagraphFormat.Style = style;
            builder.Write(MainDoc.GetText());

            builder.Document.Save("C:\\Users\\TUGARIN\\Downloads\\" + "Wow5.docx");

            return doc;
        }

        public Document Convert(Document document, SaveFormat saveFormat)
        {
            throw new NotImplementedException();
        }

        public Document Convert(string path, SaveFormat saveFormat)
        {
            Document doc = new Document(path);
            var a = doc.PageCount;
            Console.WriteLine(a);

            doc.Save("C:\\Users\\TUGARIN\\Downloads\\" + "Wow.pdf", saveFormat);

            return doc;
        }
    }
}
