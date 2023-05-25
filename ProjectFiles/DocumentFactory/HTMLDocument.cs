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

        public void RunDocument()
        {
            try
            {
                string content = "";

                foreach (HTMLElement elem in htmlElementList)
                    content += elem.ToString() + "\n";

                File.WriteAllText(filePath, content);

                System.Diagnostics.Process.Start("/Applications/Google Chrome.app/Contents/MacOS/Google Chrome", filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

