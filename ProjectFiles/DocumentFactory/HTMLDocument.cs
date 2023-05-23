using System;
using System.Collections.Generic;
using System.IO;

namespace DocumentFactory
{
    /**
	 * Class Name: HTMLDocument
	 * Purpose: Creates an HTML document
	 * Coder: Gui Miranda
	 * Date: 05/22/2023
     */
    public class HTMLDocument : IDocument
	{
        private List<HTMLElement> htmlElementList { get; set; }
        private string filePath { get; set; }

        public HTMLDocument(string path)
		{
            htmlElementList = new List<HTMLElement>();
            filePath = path;
        }

        public void AddElement(IElement e)
        {
            htmlElementList.Add(e as HTMLElement);
        }

        public bool RunDocument()
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", filePath);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}

