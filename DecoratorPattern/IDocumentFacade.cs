using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal interface IDocumentFacade
    {
        Document Convert(Document document, SaveFormat saveFormat);
        Document Convert(string path, SaveFormat saveFormat);


        Document ChangeStyleToOfficial(Document document);
        Document ChangeStyleToOfficial();

    }
}
