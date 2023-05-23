using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownDocument
	 * Purpose: Creates an Markdown document
	 * Coder: Gui Miranda
	 * Date: 05/22/2023
     */
    public class MarkdownDocument : IDocument
	{
        public List<MarkdownElement> mdElementList { get; private set; }

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

