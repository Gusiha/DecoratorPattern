using Aspose.Words;
using DecoratorPattern;

string path = Environment.CurrentDirectory + @"\Example.txt";
DocumentFacade documentFacade = new();
//Converting to .pdf
var newdoc = Client.Convert(documentFacade,path, SaveFormat.Pdf);

//Changing font style and font size
Client.ChangeStyleToOfficial(documentFacade, newdoc.OriginalFileName, SaveFormat.Docx);