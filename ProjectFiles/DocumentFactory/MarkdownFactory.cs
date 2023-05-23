using System;
namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownFactory
	 * Purpose:
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class MarkdownFactory : IDocumentFactory
	{
        private static MarkdownFactory _instance;

        private MarkdownFactory()
		{
		}

        /*Method Name: GetInstance
         *Purpose: Gets the single instance of MarkdownFactory
         *Accepts: Nothing
         *Returns: An instance of MarkdownFactory
         */
        public static MarkdownFactory GetInstance()
        {
            if (_instance == null)
                _instance = new MarkdownFactory();

            return _instance;
        }

        /*Method Name: CreateDocument
         *Purpose: Creates a MarkdownDocument object
         *Accepts: A string containing the file name
         *Returns: A MarkdownDocument object
         */
        public IDocument CreateDocument(string fileName)
        {
            return new MarkdownDocument(fileName);
        }

        /*Method Name: CreateElement
         *Purpose: Creates a new element for the Markdown document
         *Accepts: string elementType, string props
         *Returns: A MarkdownElement
         */
        public IElement CreateElement(string elementType, string props)
        {
            MarkdownElement element = new MarkdownElement();

            switch (elementType)
            {
                case "Header":
                    element = new MarkdownHeader(props);
                    break;
                case "Image":
                    element = new MarkdownImage(props);
                    break;
                case "List":
                    element = new MarkdownList(props);
                    break;
                case "Table":
                    element = new MarkdownTable(props);
                    break;
                default:
                    break;
            }

            return element;
        }
    }
}

