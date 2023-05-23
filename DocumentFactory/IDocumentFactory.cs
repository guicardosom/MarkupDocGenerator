using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    /**
	 * Class Name: IDocumentFactory
	 * Purpose:		
	 * Coder: Gui Miranda	
	 * Date: 05/22/2023		
     */
    public interface IDocumentFactory
    {
        IDocument CreateDocument(string fileName);
        IElement CreateElement(string elementType, string props);
    }
}
