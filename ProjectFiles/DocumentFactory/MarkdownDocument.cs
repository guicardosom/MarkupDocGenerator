using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownDocument
	 * Purpose:
	 * Coder: Gui Miranda
	 * Date: 05/22/2023
     */
    public class MarkdownDocument : IDocument
	{
        public List<MarkdownElement> mdElementList;

        public MarkdownDocument()
		{
		}

        public void AddElement(IElement e)
        {
            mdElementList.Add(e as MarkdownElement);
        }

        public bool RunDocument()
        {
            throw new NotImplementedException();
        }
    }
}

