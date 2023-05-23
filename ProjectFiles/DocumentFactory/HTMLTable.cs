using System;
using System.Collections.Generic;

namespace DocumentFactory
{
    /**
	 * Class Name: HTMLTable
	 * Purpose: Creates an HTML table element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class HTMLTable : HTMLElement
    {
        private List<string>tableContent { get; set; }

        public HTMLTable(List<string>content)
        {
            tableContent = content;
        }

        /*Method Name: ToString
         *Purpose: To output the table formatted as an HTML element
         *Accepts: Nothing
         *Returns: A string containing an HTML table element
         */
        override
        public string ToString()
        {
            //TODO -> WILL HAVE TO REVIST THIS AFTER PARSING MARKDOWN TEXT FILE
            return $"<table>{tableContent}</table>";
        }
    }
}

