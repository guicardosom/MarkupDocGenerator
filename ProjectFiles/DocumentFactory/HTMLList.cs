using System;
using System.Collections.Generic;

namespace DocumentFactory
{
    /**
	 * Class Name: HTMLList
	 * Purpose: Creates an HTML list element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class HTMLList : HTMLElement
    {
        private string listType { get; set; }
        private List<string>listContent { get; set; }

        public HTMLList(string type, List<string>content)
        {
            listType = type;
            listContent = content;
        }

        /*Method Name: ToString
         *Purpose: To output the list formatted as an HTML element
         *Accepts: Nothing
         *Returns: A string containing an HTML list element
         */
        override
        public string ToString()
        {
            string tag = listType == "Ordered" ? "ol" : "ul";
            string toReturn = $"<{tag}>";

            foreach (string content in listContent)
                toReturn += $"<li>{content}</li>";

            return toReturn + $"</{tag}>";
        }
    }
}

