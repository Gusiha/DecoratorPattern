using Aspose.Words;

namespace DecoratorPattern
{
    internal class Client
    {
        public static Document Convert(DocumentFacade documentFacade, string filePath, SaveFormat saveFormat)
        {
            return documentFacade.Convert(filePath, saveFormat);
        }

        public static Document ChangeStyleToOfficial(DocumentFacade facade, string filePath, SaveFormat saveFormat)
        {
            return facade.ChangeStyleToOfficial(filePath, saveFormat);
        }
    }
}
