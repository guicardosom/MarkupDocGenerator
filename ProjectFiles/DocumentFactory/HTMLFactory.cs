using System;
namespace DocumentFactory
{
    /**
	 * Class Name: HTMLFactory
	 * Purpose:
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class HTMLFactory : IDocumentFactory
	{
        private static HTMLFactory _instance;

		private HTMLFactory()
		{
		}

        /*Method Name: GetInstance
         *Purpose: Gets the single instance of HTMLFactory
         *Accepts: Nothing
         *Returns: An instance of HTMLFactory
         */
        public static HTMLFactory GetInstance()
        {
            if (_instance == null)
                _instance = new HTMLFactory();

            return _instance;
        }

        /*Method Name: CreateDocument
         *Purpose: Creates an HTMLDocument object
         *Accepts: A string containing the file name
         *Returns: An HTMLDocument object
         */
        public IDocument CreateDocument(string fileName)
        {
            return new HTMLDocument(fileName);
        }

        /*Method Name: CreateElement
         *Purpose: Creates a new element for the HTML document
         *Accepts: string elementType, string props
         *Returns: An HTMLElement
         */
        public IElement CreateElement(string elementType, string props)
        {
            HTMLElement element = new HTMLElement();

            switch (elementType)
            {
                case "Header":
                    element = new HTMLHeader(props);
                    break;
                case "Image":
                    element = new HTMLImage(props);
                    break;
                case "List":
                    element = new HTMLList(props);
                    break;
                case "Table":
                    element = new HTMLTable(props);
                    break;
                default:
                    break;
            }

            return element;
        }
    }
}

