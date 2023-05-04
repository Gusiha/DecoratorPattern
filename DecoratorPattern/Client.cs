using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Client
    {

        public static void Execute(DocumentFacade documentFacade, string path)
        {
            documentFacade.ChangeStyleToOfficial();
        }

    }
}
