using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownDocument
	 * Purpose: Creates a Markdown document
	 * Coder: Gui Miranda
	 * Date: 05/22/2023
     */
    public class MarkdownDocument : IDocument
	{
        private List<MarkdownElement> mdElementList { get; set; }
        private string filePath { get; set; }

        public MarkdownDocument(string path)
		{
            mdElementList = new List<MarkdownElement>();
            filePath = path;
        }

        public void AddElement(IElement e)
        {
            mdElementList.Add(e as MarkdownElement);
        }

        public bool RunDocument()
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", filePath);
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }
    }
}

