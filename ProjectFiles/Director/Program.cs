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
        //Creates an HTMLFactory object
        private static IDocumentFactory factory = null;


        static void Main(string[] args)
        {
            string[] commands;
            string list = File.ReadAllText("CreateDocumentScript.txt");
            commands = list.Split('#');

            //Creates an IDocument object
            IDocument document = null;

            foreach (var command in commands)
            {
                string strippedCommand = Regex.Replace(command, @"\t|\n|\r", "");
                string[] commandList = strippedCommand.Split(':');

                switch (commandList[0])
                {
                    case "Document":
                        document = CreateDocument(commandList[1]);
                        break;
                    case "Element":
                        document.AddElement(CreateElement(commandList[1], commandList[2]));
                        break;
                    case "Run":
                        document.RunDocument();
                        break;
                    default:
                        break;
                }
            }
        }


        /*Method Name: CreateDocument
         *Purpose: Creates a new (HTML or Markdown) document
         *Accepts: A string of commands, containing the type of document
         *Returns: A new IDocument object
         */
        private static IDocument CreateDocument(string commands)
        {
            string[] docInfo = commands.Split(';');

            if (docInfo[0] == "Markdown")
                factory = MarkdownFactory.GetInstance();
            else if (docInfo[0] == "Html")
                factory = HTMLFactory.GetInstance();

            return factory.CreateDocument(docInfo[1]);
        }


        /*Method Name: CreateElement
         *Purpose: Creates a new (HTML or Markdown) element
         *Accepts: string type, string props
         *Returns: A new IElement object
         */
        private static IElement CreateElement(string type, string props)
        {
            IElement element = null;

            if (factory != null)
                element = factory.CreateElement(type, props);

            return element;
        }
    }
}
