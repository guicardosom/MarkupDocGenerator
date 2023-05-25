using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using DocumentFactory;

namespace Director
{
    /**
	 * Class Name: Program
	 * Purpose:	To run and test the Document Factory functionality	
	 * Coder: Gui Miranda
	 * Date: 05/22/2023
     */
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands;
            string list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            //Creates an HTMLFactory object
            IDocumentFactory factory = null;
            //Creates a new document object
            IDocument document = null;

            foreach (var command in commands)
            {
                string strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                string[] commandList = strippedCommand.Split(':');
                switch (commandList[0])
                {
                    case "Document":
                        string[] docInfo = commandList[1].Split(';');

                        if (docInfo[0] == "Markdown")
                            factory = MarkdownFactory.GetInstance();
                        else if (docInfo[0] == "Html")
                            factory = HTMLFactory.GetInstance();

                        document = factory.CreateDocument(docInfo[1]);

                        break;
                    case "Element":
                        string elemType = commandList[1];
                        string elemInfo = commandList[2];

                        IElement elem = factory.CreateElement(elemType, elemInfo);

                        document.AddElement(elem);
                        break;
                    case "Run":
                        document.RunDocument();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
