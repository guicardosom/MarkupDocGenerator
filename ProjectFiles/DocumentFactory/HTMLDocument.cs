using System;
using System.Collections.Generic;

namespace DocumentFactory
{
    /**
	 * Class Name: HTMLDocument
	 * Purpose:
	 * Coder: Gui Miranda
	 * Date: 05/22/2023
     */
    public class HTMLDocument : IDocument
	{
        public List<HTMLElement> htmlElementList;

		public HTMLDocument()
		{
		}

        public void AddElement(IElement e)
        {
            htmlElementList.Add(e as HTMLElement);
        }

        public bool RunDocument()
        {
            throw new NotImplementedException();
        }
    }
}

