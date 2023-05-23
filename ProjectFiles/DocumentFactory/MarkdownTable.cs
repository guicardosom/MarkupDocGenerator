using System;
using System.Collections.Generic;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownTable
	 * Purpose: Creates a Markdown table element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class MarkdownTable : MarkdownElement
	{
        private List<string>tableContent { get; set; }

        public MarkdownTable(string content)
        {
        }

        /*Method Name: ToString
         *Purpose: To output the image formatted as a Markdown element
         *Accepts: Nothing
         *Returns: A string containing a Markdown image element
         */
        override
        public string ToString()
        {
            //TODO -> WILL HAVE TO REVIST THIS AFTER PARSING MARKDOWN TEXT FILE
            return $"![image]({tableContent})";
        }
    }
}

