﻿using System;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownHeader
	 * Purpose: Creates a Markdown header element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class MarkdownHeader : MarkdownElement
	{
        private int headerIntensity { get; set; }
        private string headerContent { get; set; }

        public MarkdownHeader(string content)
        {
            string[] headerInfo = content.Split(';');

            headerIntensity = Int32.Parse(headerInfo[0]);
            headerContent = headerInfo[1];
        }

        /*Method Name: ToString
         *Purpose: To output the header formatted as a Markdown element
         *Accepts: Nothing
         *Returns: A string containing a Markdown header element
         */
        override
        public string ToString()
        {
            string headerLevel = "#";

            for (int i = 2; i <= headerIntensity; i++)
                headerLevel += "#";

            return $"{headerLevel} {headerContent}";
        }
    }
}

