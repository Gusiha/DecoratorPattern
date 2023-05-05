using Aspose.Words;
using DecoratorPattern;

string path = Environment.CurrentDirectory + @"\Example.txt";
DocumentFacade documentFacade = new();
var newdoc = Client.Convert(documentFacade,path, SaveFormat.Pdf);
Client.ChangeStyleToOfficial(documentFacade, newdoc.OriginalFileName, SaveFormat.Docx);