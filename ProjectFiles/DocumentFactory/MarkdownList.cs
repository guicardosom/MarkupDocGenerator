using System;
using System.Collections.Generic;

namespace DocumentFactory
{
    /**
	 * Class Name: MarkdownList
	 * Purpose: Creates a Markdown list element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class MarkdownList : MarkdownElement
	{
        private string listType { get; set; }
        private List<string> listContent { get; set; }

        public MarkdownList(string content)
        {
            string[] listInfo = content.Split(';');

            listType = listInfo[0];

            listContent = new List<string>();
            for (int i = 1; i < listInfo.Length; i++)
                listContent.Add(listInfo[i]);
        }

        /*Method Name: ToString
         *Purpose: To output the list formatted as a Markdown element
         *Accepts: Nothing
         *Returns: A string containing a Markdown list element
         */
        override
        public string ToString()
        {
            string toReturn = "";

            if (listType == "Ordered")
            {
                int count = 1;
                foreach (string element in listContent)
                {
                    toReturn += $"{count}. {element}";
                    count++;
                }
            }
            else if (listType == "Unordered")
            {
                foreach (string element in listContent)
                {
                    toReturn += $"- {element}";
                }
            }

            return toReturn;
        }
    }
}

