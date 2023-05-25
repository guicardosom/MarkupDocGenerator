using System;
using System.Runtime.Remoting.Contexts;

namespace DocumentFactory
{
    /**
	 * Class Name: HTMLHeader
	 * Purpose: Creates an HTML header element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class HTMLHeader : HTMLElement
	{
        private int headerIntensity{ get; set; }
        private string headerContent { get; set; }

		public HTMLHeader(string content)
		{
            string[] headerInfo = content.Split(';');

            headerIntensity = Int32.Parse(headerInfo[0]);
            headerContent = headerInfo[1];
        }

        /*Method Name: ToString
         *Purpose: To output the header formatted as an HTML element
         *Accepts: Nothing
         *Returns: A string containing an HTML header element
         */
        override
        public string ToString()
		{
            return $"<h{headerIntensity}>{headerContent}</h{headerIntensity}>";
		}
	}
}

