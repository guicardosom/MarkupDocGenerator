﻿using System;

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
        private string imageContent { get; set; }

        public HTMLImage(string content)
        {
            imageContent = content;
        }

        /*Method Name: ToString
         *Purpose: To output the image formatted as an HTML element
         *Accepts: Nothing
         *Returns: A string containing an HTML image element
         */
        override
        public string ToString()
        {
            return $"<img src=\"{imageContent}\"></img>";
        }
    }
}
