using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

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
        private List<string> tableHeaders { get; set; }
        private List<string[]> tableRows { get; set; }

        public MarkdownTable(string content)
        {
            string[] tableInfo = content.Split(';');

            tableHeaders = new List<string>(tableInfo[0].Split('$'));

            tableRows = new List<string[]>();
            for (int i = 1; i < tableInfo.Length; i++)
                tableRows.Add(tableInfo[i].Split('$'));
        }

        /*Method Name: ToString
         *Purpose: To output the image formatted as a Markdown element
         *Accepts: Nothing
         *Returns: A string containing a Markdown image element
         */
        override
        public string ToString()
        {
            //creates table header
            string toReturn = "|";

            int[] headersCharCount = new int[tableHeaders.Count];

            for (int i = 0; i <= tableHeaders.Count; i++)
            {
                toReturn += $"{tableHeaders[i]}|";
                headersCharCount[i] = tableHeaders[i].Length;
            }

            toReturn += "\n|";

            foreach (int count in headersCharCount)
            {
                toReturn += ":";
                for (int i = 1; i <= count; i++)
                    toReturn += "-";
                toReturn += ":|";
            }

            //creates table rows
            foreach (string[] row in tableRows)
            {
                toReturn += "\n|";
                for (int i = 1; i < row.Length; i++)
                    toReturn += $"{row[i]}|";
            }

            return toReturn;
        }
    }
}

