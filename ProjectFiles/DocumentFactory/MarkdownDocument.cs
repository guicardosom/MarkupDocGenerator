using System;
using System.Collections.Generic;
using System.IO;
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

        public void RunDocument()
        {
            try
            {
                string content = "";

                foreach (MarkdownElement elem in mdElementList)
                {
                    Console.WriteLine(elem.ToString());
                    content += elem.ToString() + "\n";
                }

                File.WriteAllText(filePath, content);

                System.Diagnostics.Process.Start("/Applications/Google Chrome.app/Contents/MacOS/Google Chrome", filePath);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

