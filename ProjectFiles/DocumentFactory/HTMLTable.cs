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
        private List<string>tableHeaders { get; set; }
        private List<string[]>tableRows { get; set; }

        public HTMLTable(string content)
        {
            string[] tableInfo = content.Split(';');

            tableHeaders = new List<string>(tableInfo[0].Split('$'));

            tableRows = new List<string[]>();
            for (int i = 1; i < tableInfo.Length; i++)
                tableRows.Add(tableInfo[i].Split('$'));
        }

        /*Method Name: ToString
         *Purpose: To output the table formatted as an HTML element
         *Accepts: Nothing
         *Returns: A string containing an HTML table element
         */
        override
        public string ToString()
        {
            //creates table header
            string toReturn = "<table>\n<thead>\n<tr>\n";

            foreach (string header in tableHeaders)
                toReturn += $"<th>{header}</th>\n";

            toReturn += "</tr>\n<thead>\n";

            //creates table rows
            toReturn += "<tbody>\n<tr>\n";

            foreach (string[] row in tableRows)
                for (int i = 1; i < row.Length; i++)
                    toReturn += $"<td>{row[i]}</td>\n";

            toReturn += "</tr>\n<tbody>\n";

            return toReturn + "</table>";
        }
    }
}

