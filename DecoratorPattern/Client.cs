using Aspose.Words;

namespace DecoratorPattern
{
    internal class Client
    {
        public static Document Convert(IDocumentFacade documentFacade, string filePath, SaveFormat saveFormat)
        {
            return documentFacade.Convert(filePath, saveFormat);
        }

        public static Document ChangeStyleToOfficial(IDocumentFacade facade, string filePath, SaveFormat saveFormat)
        {
            return facade.ChangeStyleToOfficial(filePath, saveFormat);
        }
    }
}
