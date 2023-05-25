using System;

namespace DocumentFactory
{
    /**
	 * Class Name: HTMLImage
	 * Purpose: Creates an HTML image element
	 * Coder: Gui Miranda
	 * Date: 05/23/2023
     */
    public class HTMLImage : HTMLElement
	{
        private string imagePath { get; set; }
        private string imageTitle { get; set; }
        private string imageAlt { get; set; }

        public HTMLImage(string content)
        {
            string[] imageInfo = content.Split(';');

            imagePath = imageInfo[0];
            imageAlt = imageInfo[1];
            imageTitle = imageInfo[2];
        }

        /*Method Name: ToString
         *Purpose: To output the image formatted as an HTML element
         *Accepts: Nothing
         *Returns: A string containing an HTML image element
         */
        override
        public string ToString()
        {
            return $"<img src=\"{imagePath}\" title=\"{imageTitle}\" alt=\"{imageAlt}\"></img>";
        }
    }
}

