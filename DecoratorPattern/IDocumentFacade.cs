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
        Document Convert(string path, SaveFormat saveFormat);

        Document ChangeStyleToOfficial(string path, SaveFormat saveFormat);

    }
}
