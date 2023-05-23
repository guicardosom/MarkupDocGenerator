using System;

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
        private string headerIntensity { get; set; }
        private string headerContent { get; set; }

		public HTMLHeader(string intensity, string content)
		{
            headerIntensity = intensity;
            headerContent = content;
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

